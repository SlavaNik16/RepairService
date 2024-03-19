using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairService.UI.Forms
{
    public partial class AddFormSpearesTypeForm : Form
    {
        public AddFormSpearesTypeForm()
        {
            InitializeComponent();
            this.SparesType = new SparesType();
            buttonEnter.Enabled = !string.IsNullOrEmpty(SparesType.Title);
            buttonEdit.Enabled = !string.IsNullOrEmpty(SparesType.Title);
            using (var db = new RepairServiceContext())
            {
                listBox1.DisplayMember = nameof(SparesType.Title);
                listBox1.DataSource = db.SparesTypes.ToList();
            }
        }
        private void Load()
        {
            using (var db = new RepairServiceContext())
            {
                listBox1.DataSource = db.SparesTypes.ToList();
            }
        }
        public SparesType SparesType { get; set; }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                var exist = db.SparesTypes.Any(x => x.Title == SparesType.Title);
                if (exist)
                {
                    MessageBox.Show("Тип уже создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                db.SparesTypes.Add(SparesType);
                db.SaveChanges();
                Load();
            }
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            SparesType.Title = textBoxType.Text;
            buttonEnter.Enabled = !string.IsNullOrEmpty(SparesType.Title);
            buttonEdit.Enabled = !string.IsNullOrEmpty(SparesType.Title);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                if(listBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите элемент, который вы хотите изменить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var sp = ((SparesType)listBox1.SelectedItem);
                var speare = db.SparesTypes.FirstOrDefault(x => x.Id == sp.Id);

                var exist = db.SparesTypes.Any(x => x.Title == SparesType.Title);
                if (exist)
                {
                    MessageBox.Show("Тип уже создан!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                speare.Title = SparesType.Title;
                db.SaveChanges();
                Load();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var sp = ((SparesType)listBox1.SelectedItem);
                if (MessageBox.Show($"Вы действительно хотите удалить {sp.Title}!", "Предупреждени!", 
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    using (var db = new RepairServiceContext())
                    {
                        var spera = db.SparesTypes.FirstOrDefault(x => x.Id == sp.Id);
                        if (spera == null) return;
                        db.SparesTypes.Remove(spera);
                        db.SaveChanges();
                        Load();
                    }
                }
            }
        }
    }
}
