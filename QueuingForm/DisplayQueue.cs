using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class DisplayQueue : Form
    {
        public DisplayQueue()
        {
            InitializeComponent();
        }

        private void DisplayQueue_Load(object sender, EventArgs e)
        {

        }

        public void DisplayView(string msg)
        {
             lblDisplay.Text = msg;
        }
    }
}
