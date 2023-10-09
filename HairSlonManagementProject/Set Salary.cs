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
    public partial class Set_Salary : UserControl
    {
        public Set_Salary()
        {
            InitializeComponent();
        }
        string role;
        int role_id;
        int uuid;
        int staff_id;
        private void Guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Set_Salary_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from role ";

            SqlCommand cmd = new SqlCommand(query, conn);
           
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                role_id = int.Parse(rdr[0].ToString());
                role = rdr[1].ToString();
              comboRole.Items.Add(role);
            }
            rdr.Close();
        }

        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            uuid= int.Parse(comboRole.SelectedIndex.ToString());
            // MessageBox.Show(uuid.ToString());
            comboStaff.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query1 = "select  staff_id,staff_name from staff where role_id=@role_id";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", uuid);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                 staff_id =int.Parse(reader[0].ToString());
                string staff_name = reader[1].ToString();
                comboStaff.Items.Add(staff_name);

            }


        }

        private void ComboRole_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void Clear()
        {
            txtSalary.Text = "";
            comboRole.SelectedItem = null;
            comboStaff.SelectedItem = null;
        }
        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            string salary = txtSalary.Text.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query2 = "insert into Salary values(@staff_id,@role_id,@salary)";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@staff_id", staff_id);
            cmd2.Parameters.AddWithValue("@role_id", uuid);
            cmd2.Parameters.AddWithValue("@salary", salary);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Saved");
            Clear();
        }
    }
}
