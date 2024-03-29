﻿using RepairService.Context.DB;
using RepairService.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairService.UI.Forms
{
    public partial class ReportAddForm : Form
    {
        public Report Report { get; set; } = new Report();
        public List<int> list = new List<int>();
        public ReportAddForm(Order order)
        {
            InitializeComponent();

            CreateOrderView(order);
            
        }
        public void CreateOrderView(Order order)
        {
            using (var db = new RepairServiceContext())
            {
                flowLayoutPanel1.Controls.Clear();
                var spares = db.SparesCounts.Include(x => x.Reports).Include(x => x.SparesType).ToList();
                var ids = spares.Select(x=>x.Id).ToList();
                var dbs = spares.Where(x => x.Reports.Any(y=>y.OrderId== order.Id &&  ids.Contains(x.Id) )).ToList();
                foreach (var spare in dbs)
                {
                    
                    CreateOrderViewItem(spare);
                }
            }
        }
        private void CreateOrderViewItem(SparesCount sparesCount)
        {
            var item = new SparesView(sparesCount);
            item.Parent = flowLayoutPanel1;
        }
        private void CreateOrderViewItemAdd()
        {
            var item = new SparesView();
            item.Parent = flowLayoutPanel1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Report.Price = numericUpDown1.Value;
        }

        private void textBoxReason_TextChanged(object sender, EventArgs e)
        {
            Report.Reason = textBoxReason.Text;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CreateOrderViewItemAdd();
        }
        private List<SparesCount> GetSpearesIds()
        {
            var list = new List<SparesCount>();
            foreach (var item in flowLayoutPanel1.Controls)
            {
                if(item is SparesView sparesView)
                {
                    list.Add(sparesView.SparesCount);
                }
            }
            return list;
        }
        public List<int> GetDBSpearesIds()
        {
            return list;
        }
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            using (var db = new RepairServiceContext())
            {
                list = new List<int>();
                var getSpearesIds = GetSpearesIds();
                foreach (var item in getSpearesIds)
                {
                    var sparesDb = db.SparesCounts.ToList();
                    var item3 = sparesDb.FirstOrDefault(x => x.SparesTypeId == item.SparesTypeId && x.Count == item.Count);
                    if(item3 == null)
                    {
                         db.SparesCounts.Add(item);
                        db.SaveChanges();
                        item3 = db.SparesCounts.First(x => x.SparesTypeId == item.SparesTypeId && x.Count == item.Count);
                    }
                    list.Add(item3.Id);
                    
                }
                DialogResult = DialogResult.OK;
            }
        }
    }
}
