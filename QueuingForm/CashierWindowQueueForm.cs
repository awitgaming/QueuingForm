using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QueuingForm.CashierWindowQueueForm;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {

        public DisplayQueue display;
        
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            display = new DisplayQueue();

        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            listCashierQueue.View = View.List;

            Timer timer = new Timer();
            timer.Interval = (1 * 1500);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {

            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }

        }

        

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (CashierClass.CashierQueue.Count > 0)
            {
                var msg = CashierClass.CashierQueue.Dequeue();
                display.Show();
                display.DisplayView(msg);
            }
            else
            {
                MessageBox.Show("Empty Queue",
                                 "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }

        }
    }
}
