using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MachineApp;

namespace MachineApp
{
    public partial class WelcomeForm : MetroFramework.Forms.MetroForm
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            //CheckOutForm check = new CheckOutForm();
            //this.Hide();
            //check.ShowDialog();
            //this.Close();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnForm ret = new ReturnForm();
            this.Hide();
            ret.ShowDialog();
            this.Close();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inv = new InventoryForm();
            this.Hide();
            inv.ShowDialog();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}