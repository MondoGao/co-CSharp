using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Homework1.Contexts;
using System.Data.Entity;
using Homework1.Models;

namespace Homework2
{
    public partial class Main : Form
    {
        HomeworkContext ctx;
        public Main()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new HomeworkContext();

            ctx.Students.Load();
            studentBindingSource.DataSource = ctx.Students.Local.ToBindingList();
            dataGridViewTextBoxColumnSex.DataSource = Enum.GetValues(typeof(Sex));
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            ctx.SaveChanges();

            studentDataGridView.Refresh();
        }

        private void studentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
