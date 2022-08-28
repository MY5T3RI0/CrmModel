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
    public partial class ModelForm : Form
    {
        public ShopModel model { get; set; }
        public ModelForm()
        {
            InitializeComponent();
            model = new ShopModel(3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashDesks = new List<CashDeskView>();

            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var cashDeskView = new CashDeskView(model.CashDesks[i], i, this);
                cashDesks.Add(cashDeskView);
            }

            foreach (var cashDesk in cashDesks)
            {
                Controls.Add(cashDesk.CashDeskName);
                Controls.Add(cashDesk.ExitCustomers);
                Controls.Add(cashDesk.Queue);
                Controls.Add(cashDesk.Sum);               
            }

            MinimumSize = new System.Drawing.Size(410, 105 + (33 * cashDesks.Count));

            model.Start();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            model.Stop();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDown2.Value;
        }
    }
}
