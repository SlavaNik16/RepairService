using RepairService.Context.DB;
using RepairService.Context.Manager;
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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var user = db.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
                if(user== null)
                {
                    MessageBox.Show("Пользователь не найден!","Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Current.CurrentUser = user;
                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                Application.Exit();
            }
    
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
