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
    public partial class ViewSalary : UserControl
    {
        public ViewSalary()
        {
            InitializeComponent();
        }

        private void ViewSalary_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select staff_name,role,salary from Salary inner join staff on staff.staff_id=Salary.staff_id inner join role on role.role_id=Salary.role_id", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Salary");
            dt = ds.Tables["Salary"];
            salarygridView.DataSource = dt;
            string count = "select count(*) from Salary";
            SqlCommand cmd = new SqlCommand(count, conn);
            int res = 0;
            res = (int)cmd.ExecuteScalar();
            lblRecord.Text = "Numbers Of Records ";
            lblRecord.Text += res;
        }
    }
}
