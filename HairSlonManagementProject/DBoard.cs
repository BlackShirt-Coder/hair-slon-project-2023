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
    public partial class DBoard : UserControl
    {
        public DBoard()
        {
            InitializeComponent();
        }

        private void DBoard_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select staff_name , COUNT(staff_name) As Count  from staff_record GROUP BY staff_name HAVING COUNT(staff_name) >4 ";
           
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            dboardgrid.DataSource = dt;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            DateTime date = DateTime.Now;
            string cdate = date.ToShortDateString();
            string query1 = "select  member_name,address,card_fees from members where card_create_date='"+cdate+"'";

            SqlDataAdapter adp = new SqlDataAdapter(query1, con);
            DataSet ds1 = new DataSet();
            DataTable dta = new DataTable();
            adp.Fill(ds1, "members");
            dta = ds1.Tables["members"];
            memberGrid.DataSource = dta;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
