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
            comboBoxBrokenType.DisplayMember = nameof(BrokenType.Title);
            comboBoxRequipment.DisplayMember = nameof(Equipment.Title);
        }

        private void AddOrdersForm_Load(object sender, EventArgs e)
        {
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
