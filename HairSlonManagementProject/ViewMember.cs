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
    public partial class ViewMember : UserControl
    {
        public ViewMember()
        {
            InitializeComponent();
        }

        private void ViewMember_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select member_id,member_name,phone,address,card_create_date,card_expire_date from members", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "members");
            dt = ds.Tables["members"];
            memberDataGrid.DataSource = dt;
            string count = "select count(*) from members";
            SqlCommand cmd = new SqlCommand(count, conn);
            int res = 0;
            res = (int)cmd.ExecuteScalar();
            lblRecord.Text += res;
        }

        private void LblRecord_Click(object sender, EventArgs e)
        {

        }

        private void MemberDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
