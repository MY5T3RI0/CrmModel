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
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = NameTextBox.Text,
                Count = Convert.ToInt32(CountTextBox.Text),
                Price = Convert.ToDecimal(PriceTextBox.Text),
            };
            Close();
        }
    }
}
