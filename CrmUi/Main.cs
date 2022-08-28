using CrmBL.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class Main : Form
    {

        CrmContext db;
        Cart cart;
        CashDesk cashDesk;
        Customer customer;

        public Main()
        {
            InitializeComponent();
            cart = new Cart(null);
            db = new CrmContext();
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db)
            {
                IsModel = false
            };
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Product>(db.Products, db);

            catalogForm.Show();
        }

        private void CustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Customer>(db.Customers, db);

            catalogForm.Show();
        }

        private void SellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Seller>(db.Sellers, db);

            catalogForm.Show();
        }

        private void CheksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogForm = new Catalog<Check>(db.Checks, db);

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

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new CustomerForm();

            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(customerForm.Customer);
                db.SaveChanges();
            }
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productsForm = new ProductForm();

            if (productsForm.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(productsForm.Product);
                db.SaveChanges();
            }
        }

        private void ModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var modelForm = new ModelForm();

            modelForm.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                listBox1.Invoke((Action)delegate
                {
                    UpdateLists();
                });
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Product product)
            {
                cart.Add(product);
                listBox2.Items.Add(product);
            }
            
        }

        private void UpdateLists()
        {
            listBox1.Items.AddRange(db.Products.ToArray());
            listBox2.Items.AddRange(cart.GetAll().ToArray());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customer != null)
            {
                cart.Customer = customer;
                cashDesk.Enqueue(cart);
                cashDesk.Dequeue();
                listBox2.Items.Clear();
                cart = new Cart(customer);
            }
            else
            {
                MessageBox.Show("Сначала войдите");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var login = new LoginForm(db);
            login.ShowDialog();
            if(login.DialogResult == DialogResult.OK)
            {
                customer = login.customer;
                linkLabel1.Text = $"Привет, {customer.Name}";
            }
        }
    }
}
