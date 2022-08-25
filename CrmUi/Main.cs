using CrmBL.Model;
using System;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Main : Form
    {

        CrmContext db;
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Product>(db.Products);

            catalogForm.Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Customer>(db.Customers);

            catalogForm.Show();
        }

        private void SellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Seller>(db.Sellers);

            catalogForm.Show();
        }

        private void CheksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Check>(db.Checks);

            catalogForm.Show();
        }

        private void AddSellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sellerForm = new SellerForm();

            if (sellerForm.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(sellerForm.Seller);
                db.SaveChanges();
            }
        }
    }
}
