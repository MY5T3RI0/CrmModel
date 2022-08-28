using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class LoginForm : Form
    {
        CrmContext db;
        public Customer customer { get; set; }
        public LoginForm(CrmContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            customer = db.Customers.FirstOrDefault(c => c.Name == textBox1.Text);
            if(customer == null)
            {
                customer = new Customer() { Name = textBox1.Text };
                db.Customers.Add(customer);
            }
            Close();
        }
    }
}
