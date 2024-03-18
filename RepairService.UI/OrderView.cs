using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                db.Orders.Remove(orderDB);
                db.SaveChanges();
                this.Hide();
            }
              
        }
    }
}
