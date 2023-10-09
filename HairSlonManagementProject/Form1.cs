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
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryInsert = "insert into staff values(@staff_name,@staff_role,@phone,@address)";
            SqlCommand cmd = new SqlCommand(queryInsert,conn);
           
            cmd.Parameters.AddWithValue("@staff_name",txtName.Text.ToString());
            cmd.Parameters.AddWithValue("@staff_role", txtRole.Text.ToString());
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.ToString());
            cmd.Parameters.AddWithValue("@address", txtAddress.Text.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtRole_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryselect = "select *from staff";
            SqlDataAdapter adp = new SqlDataAdapter(queryselect,conn);
            SqlCommandBuilder builder = new SqlCommandBuilder(adp);
            DataSet ds = new DataSet();
            adp.Fill(ds, "staff");
            DataTable tb = new DataTable();
            tb = ds.Tables["staff"];
            datagridview.DataSource = tb;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
          
            try
            {
                string delete = "delete from staff";
                conn.Open();
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand(delete, conn);
                cmd.Transaction = tran;
                cmd.ExecuteNonQuery();
               
                MessageBox.Show("deleted");
                tran.Rollback();
                tran.Commit();

            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UndoBtn_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlTransaction tran = conn.BeginTransaction();
                if (tran != null)
                {
                    tran.Rollback();
                    tran.Dispose();
                    tran = null;
                    MessageBox.Show("Test");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }
    }
    }

