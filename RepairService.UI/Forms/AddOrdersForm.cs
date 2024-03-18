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

namespace RepairService.UI.Forms
{
    public partial class AddOrdersForm : Form
    {
        public Order Order { get; set; } = new Order();
        public AddOrdersForm()
        {
            InitializeComponent();
            Text = "Добавить заказ";
            buttonEnter.Text = "Добавить";
            comboBoxBrokenType.DisplayMember = nameof(BrokenType.Title);
            comboBoxRequipment.DisplayMember = nameof(Equipment.Title);
            using (var db = new RepairServiceContext())
            {
                comboBoxBrokenType.Items.Clear();
                comboBoxBrokenType.Items.AddRange(db.BrokenTypes.ToArray());

                comboBoxRequipment.Items.Clear();
                comboBoxRequipment.Items.AddRange(db.Equipments.ToArray());

                comboBoxBrokenType.SelectedIndex = 0;
                comboBoxRequipment.SelectedIndex = 0;
            }
        }
        public AddOrdersForm(Order order):this()
        {
            this.Order = order;
            textBoxDesc.Text = order.Description;
            numericUpDownPrioritet.Value = order.Priority;
            comboBoxRequipment.SelectedItem = comboBoxRequipment.Items.Cast<Equipment>().FirstOrDefault(x => x.Id == order.EquipmentId);
            comboBoxBrokenType.SelectedItem = comboBoxBrokenType.Items.Cast<BrokenType>().FirstOrDefault(x => x.Id == order.BrokenTypeId);
        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {
        }

        private void comboBoxRequipment_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.EquipmentId = ((Equipment)comboBoxRequipment.SelectedItem).Id;
           
        }

        private void comboBoxBrokenType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order.BrokenTypeId = ((BrokenType)comboBoxBrokenType.SelectedItem).Id;

        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            Order.Description = textBoxDesc.Text;
        }

        private void numericUpDownPrioritet_ValueChanged(object sender, EventArgs e)
        {
            Order.Priority = (int)numericUpDownPrioritet.Value;
        }
    }
}
