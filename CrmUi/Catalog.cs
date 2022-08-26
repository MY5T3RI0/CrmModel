using CrmBL.Model;
using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Catalog<T> : Form
        where T : class
    {
        CrmContext db;
        

        public Catalog(DbSet<T> set, CrmContext db)
        {
            this.db = db;
            set.Load();
            InitializeComponent();
            dataGridView.DataSource = set.Local.ToBindingList();
        }

    }
}
