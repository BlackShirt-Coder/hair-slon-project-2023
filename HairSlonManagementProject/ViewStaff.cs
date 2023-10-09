using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HairSlonManagementProject
{
    public partial class ViewStaff : UserControl
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void ViewStaff_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select staff_name,phone,address from staff", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff");
            dt = ds.Tables["staff"];
            staffGridView.DataSource = dt;
            string count = "select count(*) from staff";
            SqlCommand cmd = new SqlCommand(count,conn);
            int res = 0;
            res=(int)cmd.ExecuteScalar();
            lblRecord.Text += res;
        }

        private void Staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select staff_name,phone,address from staff", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff");
            dt = ds.Tables["staff"];
            staffGridView.DataSource = dt;
            

        }

        private void LblRecord_Click(object sender, EventArgs e)
        {

        }

        private void StaffGridView_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
