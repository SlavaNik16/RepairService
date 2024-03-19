using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairService.UI.Forms;
using System.Data.Entity.Migrations;

namespace RepairService.UI
{
    public partial class OrderView : UserControl
    {
        public Order order { get; set; }
        public event Action<Report> ReportAdd;
        public OrderView(Order order)
        {
            InitializeComponent();
            this.order = order;
            loadOrder(order);
        }
        private void loadOrder(Order order)
        {
            this.order = order;
            labelId.Text = order.Id.ToString();
            labelPrioritet.Text = order.Priority.ToString();
            switch (order.Status)
            {
                case StatusType.complete:
                    labelStatus.Text = "Выполнено";
                    break;
                case StatusType.work:
                    labelStatus.Text = "В работе";
                    break;
                case StatusType.notComplete:
                    labelStatus.Text = "Не выполнено";
                    break;


            }
            labelBrokenType.Text = order.BrokenType.Title;
            labelEquippmentsTitle.Text = order.Equipment.Title;
            labelEqipmentsType.Text = order.Equipment.EquipmentType.Title;
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var orderDb = db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType).FirstOrDefault(x => x.Id == order.Id);
                if (orderDb == null) return;
                var form = new AddOrdersForm(orderDb);
                if(form.ShowDialog() == DialogResult.OK)
                {
                    db.SaveChanges();
                    var ord = db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType).First(x => x.Id == orderDb.Id);
                    loadOrder(ord);
                }
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var orderDB = db.Orders.FirstOrDefault(x => x.Id == order.Id);
                if (orderDB == null)
                {
                    this.Hide();
                    return;
                }
                if (MessageBox.Show("Вы действительно хотите удалить этот заказ!", "Предупреждение!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    db.Orders.Remove(orderDB);
                    db.SaveChanges();
                    this.Hide();
                }
            }
              
        }

        private void добавитьВОтчетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ReportAddForm(order);
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RepairServiceContext())
                {
                    var ord = db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType).Include(x => x.Workers).Include(x => x.Client).FirstOrDefault(x => x.Id == order.Id);
                    ord.Status = StatusType.complete;
                    var report = form.Report;
                    report.OrderId = ord.Id;

                    report.SparesCounts.Clear();
                    var ids = form.GetSpearesIds().Select(x=>x.Id);
                    report.SparesCounts = db.SparesCounts.Where(t => ids.Contains(t.Id)).ToList();
                    db.Reports.AddOrUpdate(report);
                    db.SaveChanges();
                    order = ord;

                    loadOrder(ord);
                    ReportAdd?.Invoke(report);
                }
            }
           
        }


        private void изменитьСостоянияРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var ord = db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType).Include(x => x.Workers).Include(x => x.Client).FirstOrDefault(x => x.Id == order.Id);
                var form = new EditOrdersForm(ord);
                if (form.ShowDialog() == DialogResult.OK)
                {

                    var ids = form.GetCheckedUser();
                    ord.Status = ids.Count != 0 ? StatusType.work : StatusType.notComplete;
                    ord.Workers.Clear();
                    ord.Workers = db.Users.Where(x => ids.Contains(x.Id)).ToList();
                    db.SaveChanges();
                    order = ord;
                    loadOrder(ord);
                }
            }
        }
    }
}
