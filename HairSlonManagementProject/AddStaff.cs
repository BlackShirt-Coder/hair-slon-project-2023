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
    public partial class AddStaff : UserControl
    {
        public AddStaff()
        {
            InitializeComponent();
        }

        private void Guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
       

     

        private void Guna2ShadowPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void AddStaff_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role from role";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                staffRole.Items.Add(rdr[0].ToString());
            }
        }
        private void Clear()
        {
            txtName.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
            staffRole.SelectedItem = null;
        }
        private void BtnSave_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryInsert = "insert into staff values(@staff_name,@staff_role,@phone,@address)";
            SqlCommand cmd = new SqlCommand(queryInsert, conn);

            cmd.Parameters.AddWithValue("@staff_name", txtName.Text.ToString());
            cmd.Parameters.AddWithValue("@staff_role", staffRole.SelectedIndex.ToString());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.ToString());
            cmd.Parameters.AddWithValue("@address", txtAddress.Text.ToString());
            if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && staffRole.SelectedItem != null)
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved");

                Clear();
            }
        }
       
      
    }
}
