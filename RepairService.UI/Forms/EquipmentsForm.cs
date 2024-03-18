using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepairService.Context.Manager;

namespace RepairService.UI.Forms
{
    public partial class EquipmentsForm : Form
    {
        public EquipmentsForm()
        {
            InitializeComponent(); 
            comboBoxBrokenType.DisplayMember = nameof(BrokenType.Title);
            comboBoxequipmentType.DisplayMember = nameof(EquipmentType.Title);
        }

        private void EquipmentsForm_Load(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                comboBoxBrokenType.Items.Clear();
                comboBoxBrokenType.Items.AddRange(db.BrokenTypes.ToArray());
                comboBoxBrokenType.Items.Insert(0, new BrokenType()
                {
                    Id = -1,
                    Title = "Все неисправности"
                });
                comboBoxequipmentType.Items.Clear();
                comboBoxequipmentType.Items.AddRange(db.EquipmentTypes.ToArray());
                comboBoxequipmentType.Items.Insert(0, new EquipmentType()
                {
                    Id = -1,
                    Title = "Все типы"
                });

                comboBoxBrokenType.SelectedIndex = 0;
                comboBoxequipmentType.SelectedIndex = 0;
                CreateOrderView();
            }
        }
        public void CreateOrderView(bool isCreatedAt = true)
        {
            using (var db = new RepairServiceContext())
            {
                flowLayoutPanel1.Controls.Clear();
                var orders = db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType);
                orders = isCreatedAt ? orders.OrderBy(x => x.CreatedAt).AsQueryable() : orders.OrderByDescending(x => x.CreatedAt).AsQueryable();
                foreach (var order in orders.ToList())
                {
                    CreateOrderViewItem(order);
                }
            }
        }
        private void CreateOrderViewItem(Order order) {
            var item = new OrderView(order);
            item.Parent = flowLayoutPanel1;
        }
        private void UpdateFilter()
        {
            foreach(var item in flowLayoutPanel1.Controls)
            {
                if (comboBoxBrokenType.SelectedItem == null || comboBoxequipmentType.SelectedItem == null) return;
                var selectedIdBroken = ((BrokenType)comboBoxBrokenType.SelectedItem).Id;
                var selectedIdEquipment = ((EquipmentType)comboBoxequipmentType.SelectedItem).Id;
                if (item is OrderView orderView)
                {
                    var visible = true;
                    if (selectedIdBroken != -1 && 
                        orderView.order.BrokenType.Id != selectedIdBroken)
                    {
                        visible = false;
                    }
                    if (selectedIdEquipment != -1 &&
                       orderView.order.Equipment.EquipmentType.Id != selectedIdEquipment)
                    {
                        visible = false;
                    }

                    if(!(string.IsNullOrEmpty(textBoxSearch.Text) ||
                        orderView.order.Equipment.Title.Contains(textBoxSearch.Text)))
                    {
                        visible = false;
                    }
                    orderView.Visible = visible;
                }
            }
        }

        private void comboBoxequipmentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void comboBoxBrokenType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            UpdateFilter();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CreateOrderView(checkBox1.Checked);
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var form = new AddOrdersForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                using (var db = new RepairServiceContext())
                {
                    var ord = form.Order;
                    ord.ClientId = Current.CurrentUser.Id;
                    db.Orders.Add(form.Order);
                    db.SaveChanges();
                    var order = 
                        db.Orders.Include(x => x.Equipment).Include(x => x.Equipment.EquipmentType).Include(x => x.BrokenType).First(x=>x.Id == form.Order.Id);
                    CreateOrderViewItem(order);
                 }
            }
        }
    }
}
