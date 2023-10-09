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
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCotainer.Controls.Clear();
            panelCotainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DBoard db = new DBoard();
            addUserControl(db);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            DateTime date = DateTime.Now;
            string cdate=date.ToShortDateString();
            string query = "select sum(actual_income) from income  where date='"+date+"'";
            SqlCommand cmd = new SqlCommand(query, conn);
            var income = cmd.ExecuteScalar();
            if (income!=DBNull.Value)
            {
                int todayIncome = Convert.ToInt32(income);
                lblIncome.Text = todayIncome.ToString();
            }
            else
            {
                lblIncome.Text = "0";
            }
          
            string member = "select count(member_id) from members ";
            SqlCommand cmd1 = new SqlCommand(member, conn);
            int memberCount=(int)cmd1.ExecuteScalar();
            lblMember.Text = memberCount.ToString() ;
            string staff = "select count(staff_id) from staff ";
            SqlCommand cmd2 = new SqlCommand(staff, conn);
            int staffCount = (int)cmd2.ExecuteScalar();
            lblStaff.Text = staffCount.ToString();
            string rid = "select count(staff_id) from rating ";
            SqlCommand cmd3 = new SqlCommand(rid, conn);
            int ratingId = (int)cmd3.ExecuteScalar();
            lblFeedBack.Text =ratingId.ToString();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void IconPictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
