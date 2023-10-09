using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace HairSlonManagementProject
{
    public partial class FeedBack : Form
    {
        public FeedBack()
        {
            InitializeComponent();
        }
        string role;
        int role_id;
        int uuid;
        int staff_id;
        int rating_count;
        int sid;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        private void BunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnMaximize_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;

            }
        }

        private void Guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       


    private void FeedBack_Load(object sender, EventArgs e)
        {
            
        }

        private void ComboRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            uuid = int.Parse(comboRole.SelectedIndex.ToString());
             //MessageBox.Show(uuid.ToString());
            comboStaff.Items.Clear();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query1 = "select  staff_id,staff_name from staff where role_id=@role_id";
            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", uuid);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_id = int.Parse(reader[0].ToString());
                string staff_name = reader[1].ToString();
                comboStaff.Items.Add(staff_name);

            }
        }

        private void FeedBack_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from role ";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                role_id = int.Parse(rdr[0].ToString());
                role = rdr[1].ToString();
                comboRole.Items.Add(role);
            }
            rdr.Close();
         
        }

        private void insert(int ratingCount,int sid)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string insert = "insert into rating values(@staff_id,@rating_count)";

            SqlCommand cmd2 = new SqlCommand(insert, conn);
            cmd2.Parameters.AddWithValue("@staff_id", sid);
            cmd2.Parameters.AddWithValue("@rating_count", ratingCount);
         
            cmd2.ExecuteNonQuery();
            

        }
        private void Checkbox1_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            checkbox2.Enabled = false;
            checkbox3.Enabled = false;
            checkbox4.Enabled = false;
            checkbox5.Enabled = false;
            rating_count = 5;
            
            insert(rating_count,sid);
            MessageBox.Show("Thank You For Your Feedback");
        }

        private void Checkbox2_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            rating_count = 4;
            checkbox1.Enabled = false;
            checkbox3.Enabled = false;
            checkbox4.Enabled = false;
            checkbox5.Enabled = false;
            insert(rating_count,sid);

            MessageBox.Show("Thank You For Your Feedback");
        }

        private void Checkbox3_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            rating_count = 3;
            checkbox2.Enabled = false;
            checkbox1.Enabled = false;
            checkbox4.Enabled = false;
            checkbox5.Enabled = false;
            insert(rating_count,sid);

            MessageBox.Show("Thank You For Your Feedback");
        }

        private void Checkbox4_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            rating_count = 2;
            checkbox2.Enabled = false;
            checkbox1.Enabled = false;
            checkbox3.Enabled = false;
            checkbox5.Enabled = false;
            insert(rating_count,sid);

            MessageBox.Show("Thank You For Your Feedback");
        }

        private void Checkbox5_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            rating_count = 1;
            checkbox2.Enabled = false;
            checkbox1.Enabled = false;
            checkbox3.Enabled = false;
            checkbox4.Enabled = false;
            insert(rating_count,sid);

            MessageBox.Show("Thank You For Your Feedback");
        }

        private void ComboStaff_SelectedValueChanged(object sender, EventArgs e)
        {
         
        }

        private void ComboStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string staff_name = comboStaff.SelectedItem.ToString();
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select staff_id from staff where staff_name='" + staff_name + "' ";

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                sid = int.Parse(rdr[0].ToString());
               // MessageBox.Show(sid.ToString());

            }
            rdr.Close();
        }
    }
}
