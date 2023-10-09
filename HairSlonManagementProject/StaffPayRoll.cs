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
    public partial class StaffPayRoll : UserControl
    {
        public StaffPayRoll()
        {
            InitializeComponent();
        }

        string selectedDate;
        private void StaffPayRoll_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from staff_record", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            staffRecord.DataSource = dt;
           
            string query = "select staff_name from staff";
            SqlCommand cmd1 = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd1.ExecuteReader();
            while(rdr.Read())
            {
               staffCombo.Items.Add(rdr[0].ToString()) ;
            }

        }

        private void StaffCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
          string staffName= staffCombo.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from staff_record where staff_name='"+staffName+"'", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            staffRecord.DataSource = dt;
           
           

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            string staffName = staffCombo.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query= "select sum(staff_percent_fee) from staff_record where staff_name = '" + staffName + "' and date='"+ selectedDate + "'";
            SqlCommand command = new SqlCommand(query, conn);
            var res = command.ExecuteScalar();
            int salary = Convert.ToInt32(res);
            txtCalculate.Text = salary.ToString();

        }

        private void BunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtCalculate.Text = "";
            selectedDate=dpicker.Value.ToShortDateString();
            string staffName = staffCombo.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from staff_record where staff_name='" + staffName + "' and date='"+selectedDate+"'", conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            staffRecord.DataSource = dt;
        }
    }
}
