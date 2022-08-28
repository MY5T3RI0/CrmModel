using CrmBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    class CashDeskView
    {
        CashDesk CashDesk;
        public Label CashDeskName { get; set; }
        public Label ExitCustomers { get; set; }
        public NumericUpDown Sum { get; set; }
        public ProgressBar Queue { get; set; }

        public int Y { get; set; } = 20;

        public CashDeskView(CashDesk cashDesk, int number, ModelForm model)
        {
            CashDesk = cashDesk;
            CashDeskName = new Label();
            Sum = new NumericUpDown();
            Queue = new ProgressBar();
            ExitCustomers = new Label();

            CashDeskName.AutoSize = true;
            CashDeskName.Location = new System.Drawing.Point(12, number * 33 + Y);
            CashDeskName.Name = "label" + number;
            CashDeskName.Size = new System.Drawing.Size(52, 13);
            CashDeskName.TabIndex = number;
            CashDeskName.Text = cashDesk.ToString();
            CashDeskName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom; ;

            Sum.Location = new System.Drawing.Point(85, number * 31 + Y);
            Sum.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            Sum.Name = "numericUpDown" + number;
            Sum.Size = new System.Drawing.Size(120, 20);
            Sum.TabIndex = number;
            Sum.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom; ;

            Queue.Location = new System.Drawing.Point(238, number * 31 + Y);
            Queue.Maximum = 10;
            Queue.Name = "progressBar" + number;
            Queue.Size = new System.Drawing.Size(100, 23);
            Queue.TabIndex = number;
            Queue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right ;

            ExitCustomers.AutoSize = true;
            ExitCustomers.Location = new System.Drawing.Point(357, number * 33 + Y);
            ExitCustomers.Name = "label" + number;
            ExitCustomers.Size = new System.Drawing.Size(5, 13);
            ExitCustomers.TabIndex = number;
            ExitCustomers.Text = cashDesk.ExitCustomer.ToString();
            ExitCustomers.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            cashDesk.CartOut += CashDesk_CartOut;
        }

        private void CashDesk_CartOut(object sender, Check e)
        {
            try
            {
                Sum.Invoke((Action)delegate
                    {
                        Sum.Value = e.Price;
                        Queue.Value = CashDesk.Carts.Count;
                        ExitCustomers.Text = CashDesk.ExitCustomer.ToString();
                    });
            }
            catch { };

        }
    }
}
