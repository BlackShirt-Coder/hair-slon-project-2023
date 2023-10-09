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
    public partial class ViewFeedback : UserControl
    {
        public ViewFeedback()
        {
            InitializeComponent();
        }

        private void ViewFeedback_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select staff.staff_name ,rating.rating_count from rating inner join staff on staff.staff_id=rating.staff_id", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "rating");
            dt = ds.Tables["rating"];
            feedGrid.DataSource = dt;
           

        }
    }
}
