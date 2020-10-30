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
    public partial class QueuingForm1 : Form
    {
        private CashierClass cashier;
        
        public QueuingForm1() 
        {
            cashier = new CashierClass();
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text; 
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void QueuingForm1_Load(object sender, EventArgs e) 
        {
            Location = new Point(200, 100);
            new CashierWindowQueue().Show();
           
        }
    }
}
