using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        public CashierWindowQueueForm WindowQueue;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            //nakalimutan kong isama sa pag commit yung step 6 sa step 4 & 5
            // sorry po nag double commit 
            WindowQueue = new CashierWindowQueueForm();
            WindowQueue.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

     
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
