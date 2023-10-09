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
    public partial class MemberIncome : UserControl
    {
        public MemberIncome()
        {
            InitializeComponent();
        }

        private void MemberIncome_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select customer_id,income,discount,actual_income,date from income where customer_id!='" + 1010101 + "'", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "income");
            dt = ds.Tables["income"];
            MIncome.DataSource = dt;
        }
    }
}
