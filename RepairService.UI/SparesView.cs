using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairService.UI
{
    public partial class SparesView : UserControl
    {
        public SparesCount SparesCount { get; set; }
        public SparesView()
        {
            InitializeComponent();
            this.SparesCount = new SparesCount();
            using (var db = new RepairServiceContext())
            {
                comboBoxSpearesType.DisplayMember = nameof(SparesType.Title);
                comboBoxSpearesType.Items.Clear();
                comboBoxSpearesType.Items.AddRange(db.SparesTypes.ToArray());

                comboBoxSpearesType.SelectedIndex = 0;  
            }
        }

        public SparesView(SparesCount SparesCount):this()
        {
            this.SparesCount = SparesCount;
            comboBoxSpearesType.SelectedItem = comboBoxSpearesType.Items.Cast<SparesType>().FirstOrDefault(x => x.Id == SparesCount.SparesTypeId);
            numericUpDownCount.Value = SparesCount.Count;
        }

        private void numericUpDownCount_ValueChanged(object sender, EventArgs e)
        {
            SparesCount.Count = (int)numericUpDownCount.Value;
        }

        private void comboBoxSpearesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SparesCount.SparesTypeId = ((SparesType)comboBoxSpearesType.SelectedItem).Id;
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
