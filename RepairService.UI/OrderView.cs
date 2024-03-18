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

namespace RepairService.UI
{
    public partial class OrderView : UserControl
    {
        public Order order { get; set; }
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
            labelStatus.Text = order.Status.ToString();
            labelBrokenType.Text = order.BrokenType.Title;
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
    }
}
