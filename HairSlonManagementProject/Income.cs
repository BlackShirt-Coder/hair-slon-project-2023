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
    public partial class Income : UserControl
    {
        public Income()
        {
            InitializeComponent();
        }

        private void BunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Income_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from income", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "income");
            dt = ds.Tables["income"];
            incomeShow.DataSource = dt;
            string count = "select count(*) from income";
            SqlCommand cmd = new SqlCommand(count, conn);
            int res = 0;
            res = (int)cmd.ExecuteScalar();
            lblRecord.Text += res;
        }

    }
}