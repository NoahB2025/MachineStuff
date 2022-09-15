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
        SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=hafsay;Integrated Security=True");
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hafsayDataSet.toolTbl' table. You can move, or remove it, as needed.
            this.toolTblTableAdapter.Fill(this.hafsayDataSet.toolTbl);
            Student_Intvy_Page();
        }

        public void display_data()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [toolTbl]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_displayAll_Click(object sender, EventArgs e)
        {

        }
    }
}
