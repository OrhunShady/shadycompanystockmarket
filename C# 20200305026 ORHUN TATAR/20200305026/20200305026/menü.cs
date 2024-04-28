using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200305026
{
    public partial class menü : Form
    {
        public menü()
        {
            InitializeComponent();
        }

        private void SHADY_Click(object sender, EventArgs e)
        {


        }

        private void stockmanagementbutton_Click(object sender, EventArgs e)

        {

            stockmanagement stockmanagement = new stockmanagement();
            
            stockmanagement.Show();
            

        }

        private void currentstockbutton_Click(object sender, EventArgs e)
        {
            currentstockcs currentstockcs = new currentstockcs();
            currentstockcs.Show();
        }

        private void quıtbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
