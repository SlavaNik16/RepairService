using RepairService.Context.Manager;
using RepairService.UI.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            var user = Current.CurrentUser;
            toolStripStatusLabelFIO.Text = $"{user.Surname} {user.Name} {user?.Patronymic}";
            toolStripStatusLabelRole.Text = user.RoleType.ToString();
            sparesToolStripMenuItem.Enabled = user.RoleType != Context.Models.RoleTypes.User;
        }

        private void equipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new EquipmentsForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
