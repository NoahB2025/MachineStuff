﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MachineShopInventoryPage
{
    public partial class Inventory : MetroFramework.Forms.MetroForm
    {
        public Inventory()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student_Intvy_Page();
        }

        public void Student_Intvy_Page()
        {
            btnAdd.Hide();
            btnEdit.Hide();
            btnRemove.Hide();
            btnSignout.Hide();
            btnSignin.Show();
            btnCheckedout.Hide();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            btnSignin.Hide();
            btnSignout.Show();
            btnAdd.Show();
            btnEdit.Show();
            btnRemove.Show();
            btnCheckedout.Show();
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Student_Intvy_Page();
        }

        private void btnCheckedout_Click(object sender, EventArgs e)
        {

        }
    }
}
