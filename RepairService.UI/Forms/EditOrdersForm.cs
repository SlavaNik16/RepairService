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

namespace RepairService.UI.Forms
{
    public partial class EditOrdersForm : Form
    {
        
        public EditOrdersForm(Order order)
        {
            InitializeComponent();
            using (var db = new RepairServiceContext())
            {
                var userWorker = db.Users.Where(x => x.RoleType != RoleTypes.User).ToArray();
                checkedListBox1.DisplayMember = nameof(User.Surname);
                checkedListBox1.Items.Clear();
                checkedListBox1.Items.AddRange(userWorker);

                var ids = order.Workers.Select(x => x.Id).ToList();
                for(int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (ids.Contains(((User)checkedListBox1.Items[i]).Id))
                    {
                        checkedListBox1.SetItemChecked(i, true);
                    }
                }
            }
        }
        public List<int> GetCheckedUser() =>
            checkedListBox1
            .CheckedItems
            .Cast<User>()
            .Select(x=>x.Id)
            .ToList();
    }
}
