using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MachineApp
{
    public partial class InventoryForm : MetroFramework.Forms.MetroForm
    {
        SqlConnection conn = new SqlConnection(@"");
        //SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ToolCrib;Integrated Security=True");
        public InventoryForm()
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
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "remove from [CheckOutForm] where ToolID'" + txt_ToolID.Text + "'";
            cmd.ExecuteNonQuery();
            conn.Close();

            txt_ToolID.Text = "";
            txt_Name.Text = "";
            txt_Instructor.Text = "";
            txt_Date.Text = "";

            btnAdd.Enabled = true;
            btnEdit.Enabled = true;
            btnRemove.Enabled = false;

            MessageBox.Show("Data Removed successfully");
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Edit [toolTbl] set name='" + txt_name.text "";

            cmd.ExecuteNonQuery();
            conn.Close();
            //display_data();
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string search = btnSearch.Text;
            SqlCommand sqcmd = new SqlCommand("Select * from [CheckOutForm] where Name like '%" + search + "%' OR Instructor like '%" + search + "%' OR Date like '%", conn);
            SqlDataAdapter da = new SqlDataAdapter(sqcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);



            if (dt.Rows.Count > 0)
            {
                InventoryList.DataSource = dt;
                conn.Close();
            }
            else
            {
                MessageBox.Show("No Record found");
                conn.Close();
            }
        }
    }
}
