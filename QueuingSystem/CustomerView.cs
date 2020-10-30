using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingSystem
{

    public partial class CustomerView : Form
    {

        public CustomerView()
        {

            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            Location = new Point(300, 350);

                
            try
            {
                if (CashierClass.CashierQueue.Count == 0)
                {
                    throw new ArgumentNullException(" No customer ");
                }
                else
                {
                    lblNum.Text = CashierClass.CashierQueue.Peek();
                    timer1.Start();
                }

            }
            catch (ArgumentNullException ae)
            {
                MessageBox.Show(ae.Message);


            }

        }
        private int serveTime = 1;

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (serveTime <= 3)
            {
                lblNum.Text = serveTime.ToString();
                lblNum.Text = "Next Customer please " + serveTime;
                serveTime++;
            }
            else
            {
                
                CashierClass.CashierQueue.Dequeue();
                timer1.Stop();
                this.Hide();
            }
        }
    }
}
