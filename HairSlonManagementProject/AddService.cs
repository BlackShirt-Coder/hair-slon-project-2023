using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSlonManagementProject
{
    public partial class AddService : Form
    {
        public AddService()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           string service= txtService.Text.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "insert into service values(@service)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            txtService.Clear();
        }

        private void LblService_Click(object sender, EventArgs e)
        {

        }

        private void TxtService_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
