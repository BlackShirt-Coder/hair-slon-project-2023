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
using System.Collections;

namespace HairSlonManagementProject
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

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



        private void PanelCotainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        int role_id;
        int staff_id;
        int serviceId;
        int amount1, amount2, amount3, amount4, amount5, amount6;
        int sum = 0;
        int pay_percent;
        int old_fee;
        int cal_result;
        ArrayList stylists = new ArrayList();
        ArrayList service_name = new ArrayList();
        ArrayList serviceFee = new ArrayList();

        string today = DateTime.Now.ToString("MM/dd/yyyy");
      
     
       

        private void staff_name_load()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from staff";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            string res = "";
            while (rdr.Read())
            {
                res = rdr[1].ToString();
                staff_id = int.Parse(rdr[0].ToString());
                comboStyle1.Items.Add(res);
                combostyle2.Items.Add(res);
            }
        }

        private void pay_percent_load(int staffId)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from payroll where staff_id=@staff_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@staff_id", staffId);
            SqlDataReader rdr = cmd.ExecuteReader();
            string res = "";
            while (rdr.Read())
            {
                res = rdr[1].ToString();
                pay_percent = int.Parse(res.ToString());
            }

        }

        private void role_load()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from role";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            string res = "";
            while (rdr.Read())
            {
                res = rdr[1].ToString();
                role_id = int.Parse(rdr[0].ToString());
                comboFee1.Items.Add(res);
                comboFee2.Items.Add(res);
                comboFee3.Items.Add(res);
                comboFee4.Items.Add(res);
                comboFee5.Items.Add(res);
                comboFee6.Items.Add(res);
            }

        }
        private void service_fee_load(int staff_id)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from service_fee where role_id=@role_id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role_id", role_id);
            SqlDataReader rdr = cmd.ExecuteReader();
            string res = "";
            while (rdr.Read())
            {
                res = rdr[1].ToString();

                comboService1.Items.Add(res);
                comboService2.Items.Add(res);
                comboService3.Items.Add(res);
                comboService4.Items.Add(res);
                comboService5.Items.Add(res);
                comboService6.Items.Add(res);

            }
        }
        private void service_type_load()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select * from service";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            string res = "";
            while (rdr.Read())
            {
                res = rdr[1].ToString();
                serviceList.Items.Add(res);
                comboService1.Items.Add(res);
                comboService2.Items.Add(res);
                comboService3.Items.Add(res);
                comboService4.Items.Add(res);
                comboService5.Items.Add(res);
                comboService6.Items.Add(res);

            }
        }
        private void StaffRecord_Load(object sender, EventArgs e)
        {
            // staff_name_load();
            service_type_load();
            role_load();
            btnSave.Enabled = true;


        }

        private void ServiceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<string> stored = new List<string>();
            string selectedItems = "";
            if (serviceList.CheckedItems.Count != 0)
            {
                switch (serviceList.CheckedItems.Count)
                {
                    case 1:
                        comboStyle1.Visible = true;
                        comboService1.Visible = true;
                        comboFee1.Visible = true;
                        sb1.Visible = true;
                        break;
                    case 2:
                        combostyle2.Visible = true;
                        comboService2.Visible = true;
                        comboFee2.Visible = true;
                        sb2.Visible = true;

                        break;
                    case 3:
                        combostyle3.Visible = true;
                        comboService3.Visible = true;
                        comboFee3.Visible = true;
                        sb3.Visible = true;

                        break;
                    case 4:
                        combostyle4.Visible = true;
                        comboService4.Visible = true;
                        comboFee4.Visible = true;
                        sb4.Visible = true;

                        break;
                    case 5:
                        combostyle5.Visible = true;
                        comboService5.Visible = true;
                        comboFee5.Visible = true;
                        sb5.Visible = true;

                        break;
                    case 6:
                        combostyle6.Visible = true;
                        comboService6.Visible = true;
                        comboFee6.Visible = true;

                        sb6.Visible = true;

                        break;



                }



            }




        }
        int roleId;
        string staff_name;

        private void ComboService1_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService1.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString(); //get service-fee
                sb1.Text = service_fee;
                amount1 = int.Parse(sb1.Text);
                serviceFee.Add(amount1);
            }
            reader.Close();

        }

        private void BtnClear_Click_1(object sender, EventArgs e)
        {
            txtMember.Text = "";
        }



        private void ComboService6_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService6.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb6.Text = service_fee;
                amount6 = int.Parse(sb4.Text);
                serviceFee.Add(amount6);

            }
        }



        private void comboService4_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService4.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb4.Text = service_fee;
                amount4 = int.Parse(sb4.Text);
                serviceFee.Add(amount4);

            }
        }

        private void ComboService5_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService5.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);


            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb5.Text = service_fee;
                amount5 = int.Parse(sb5.Text);
                serviceFee.Add(amount5);

            }
        }


        private void ComboService2_SelectedValueChanged_1(object sender, EventArgs e)
        {
            object b = comboService2.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb2.Text = service_fee;
                amount2 = int.Parse(sb2.Text);
                serviceFee.Add(amount2);

            }
        }


        private void ComboFee1_SelectedValueChanged(object sender, EventArgs e)
        {

            comboStyle1.Items.Clear();
            object b = comboFee1.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                roleId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                comboStyle1.Items.Add(staff_name);

            }
        }

        private void ComboFee2_SelectedValueChanged(object sender, EventArgs e)
        {
            combostyle2.Items.Clear();
            object b = comboFee2.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                roleId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                combostyle2.Items.Add(staff_name);

            }
        }

        private void ComboFee3_SelectedValueChanged(object sender, EventArgs e)
        {
            combostyle3.Items.Clear();
            object b = comboFee3.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                roleId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                combostyle3.Items.Add(staff_name);

            }
        }

        private void ComboFee4_SelectedValueChanged(object sender, EventArgs e)
        {
            combostyle4.Items.Clear();
            object b = comboFee4.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                roleId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                combostyle4.Items.Add(staff_name);

            }
        }

        private void ComboFee5_SelectedValueChanged(object sender, EventArgs e)
        {
            combostyle5.Items.Clear();
            object b = comboFee5.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                roleId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                combostyle5.Items.Add(staff_name);

            }
        }

        private void ComboFee6_SelectedValueChanged(object sender, EventArgs e)
        {
            combostyle6.Items.Clear();
            object b = comboFee6.SelectedItem;
            string role_type = Convert.ToString(b);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select role_id from role where role=@role";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@role", role_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            string query1 = "select staff_name from staff where role_id=@role_id";

            SqlCommand cmd1 = new SqlCommand(query1, conn);
            cmd1.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                staff_name = reader[0].ToString();
                combostyle6.Items.Add(staff_name);

            }
        }

        private void comboService2_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService2.SelectedItem;
            string service_type = Convert.ToString(b);

            service_name.Add(service_type);

            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb2.Text = service_fee;
                amount2 = int.Parse(sb2.Text);
                serviceFee.Add(amount2);

            }
        }

        private void comboService3_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboService3.SelectedItem;
            string service_type = Convert.ToString(b);
            service_name.Add(service_type);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string query = "select service_id from service where service=@service";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@service", service_type);
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                serviceId = int.Parse(rdr[0].ToString());

            }
            rdr.Close();
            // MessageBox.Show(serviceId.ToString());  get service_id;
            string query2 = "select service_fee from service_fee where service_id=@service_id and role_id=@role_id";

            SqlCommand cmd2 = new SqlCommand(query2, conn);
            cmd2.Parameters.AddWithValue("@service_id", serviceId);
            cmd2.Parameters.AddWithValue("@role_id", roleId);

            SqlDataReader reader = cmd2.ExecuteReader();
            while (reader.Read())
            {
                string service_fee = reader[0].ToString();
                sb3.Text = service_fee;
                amount3 = int.Parse(sb3.Text);
                serviceFee.Add(amount3);

            }
        }

        // non---use--method
        private void staff_record_insert(string staff_name, string service_type, string service_fee, string percent, DateTime date)
        {
            double serviceFee = double.Parse(service_fee);
            double percent_pay = serviceFee * 0.1;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            DateTime today = DateTime.Now;
            string queryInsert = "insert into staff_record values(@staff_name,@service_type,@service_fee,@staff_percent_fee,date)";
            SqlCommand cmd = new SqlCommand(queryInsert, conn);

            cmd.Parameters.AddWithValue("@service_type", service_type);
            cmd.Parameters.AddWithValue("@service_fee", percent);
            cmd.Parameters.AddWithValue("@staff_percent_fee", percent_pay);
            cmd.Parameters.AddWithValue("@date", date);
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtMember.Text != "")
            {
                SqlConnection conn1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
                conn1.Open();
                int memberId = int.Parse(txtMember.Text);
                int income = int.Parse(txtCalculate.Text);
                int discount = int.Parse(txtDiscount.Text);
                int actualIncome = int.Parse(txtActualFee.Text);
                DateTime date = DateTime.Now;
                string query2 = "insert into income (customer_id,income,discount,actual_income,date) values(@customer_id,@income,@discount,@actual_income,@date)";
                SqlCommand cmd1 = new SqlCommand(query2, conn1);
                cmd1.Parameters.AddWithValue("customer_id", memberId);
                cmd1.Parameters.AddWithValue("income", income);
                cmd1.Parameters.AddWithValue("discount", discount);
                cmd1.Parameters.AddWithValue("actual_income", actualIncome);
                cmd1.Parameters.AddWithValue("date", date);
                cmd1.ExecuteNonQuery();
            }
            else
            {
                
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
                    con.Open();
                    int memberId = int.Parse("1010101");
                    int income = int.Parse(txtCalculate.Text);
                    int actualIncome = income;
                    DateTime date = DateTime.Now;
                    string query1 = "insert into income (customer_id,income,actual_income,date) values(@customer_id,@income,@actual_income,@date)";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    cmd1.Parameters.AddWithValue("customer_id", memberId);
                    cmd1.Parameters.AddWithValue("income", income);

                    cmd1.Parameters.AddWithValue("actual_income", actualIncome);
                    cmd1.Parameters.AddWithValue("date", date);
                    cmd1.ExecuteNonQuery();

                
            }
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            for (int i = 0; i < stylists.Count; i++)
            {
                string staffName = stylists[i].ToString();
                string serviceName = service_name[i].ToString();
               int serviceFees = (int)serviceFee[i];
                double staff_percent = (double)serviceFees * 0.10;
                DateTime cdate = DateTime.Now;
                 string queryInsert = "insert into staff_record(staff_name,service_type,service_fee,staff_percent_fee,date) values('" + staffName + "','" + serviceName + "','" + serviceFees + "','" + staff_percent + "','" + cdate + "')";
                 SqlCommand cmd = new SqlCommand(queryInsert, conn);
                cmd.ExecuteNonQuery();
               
               // MessageBox.Show(serviceFee.Count.ToString());
            }

            MessageBox.Show("inserted");
           
            string queryShow = "select staff_name , service_type,service_fee, date from staff_record where date='"+ today + "'";
            SqlDataAdapter da = new SqlDataAdapter(queryShow, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            recordShow.DataSource = dt;
        }

        private void ComboStyle1_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = comboStyle1.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);
        }

        private void Combostyle2_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = combostyle2.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);
        }

        private void Combostyle3_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = combostyle3.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);
        }

        private void Combostyle4_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = combostyle4.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);
        }

        private void Combostyle5_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = combostyle5.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);

        }

        private void BtnMemberLoad_Click(object sender, EventArgs e)
        {
            if (txtMember.Text != "")
            {

                lblMessage.Text = "Valid Member Card";
                lblMessage.ForeColor = System.Drawing.Color.Green;
                btnSave.Enabled = true;
                lblAmount.Visible = true;
                lblDiscount.Visible = true;
                lblActualFee.Visible = true;
                txtDiscount.Visible = true;
                txtActualFee.Visible = true;
                old_fee = cal_result;

                double fee = (double)cal_result;
                fee -= fee * 0.30;
                string new_fee = fee.ToString();//70000
                int discount_fee = old_fee - int.Parse(new_fee);
                txtDiscount.Text = discount_fee.ToString();
                txtActualFee.Text = new_fee;





            }

            else
            {
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Text = "Member Id is Not Exist";
                btnSave.Enabled = true;
                lblDiscount.Visible = true;
                lblActualFee.Visible = true;
                txtDiscount.Visible = true;
                lblAmount.Visible = true;
                txtDiscount.Text = "0";
                txtActualFee.Visible = true;
                txtActualFee.Text = cal_result.ToString();
             
            }
        }

        private void ComboStyle1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            btnMemberLoad.Enabled = true;
            if (sb1.Text != "" && sb2.Text != "" && sb3.Text != "" && sb4.Text != "" && sb5.Text != "" && sb6.Text != "")
            {
                sum = amount1 + amount2 + amount3 + amount4 + amount5 + amount6;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }
            else if (sb1.Text != "" && sb2.Text != "" && sb3.Text != "" && sb4.Text != "" && sb5.Text != "")
            {
                sum = amount1 + amount2 + amount3 + amount4 + amount5;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }
            else if (sb1.Text != "" && sb2.Text != "" && sb3.Text != "" && sb4.Text != "")
            {
                sum = amount1 + amount2 + amount3 + amount4;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }
            else if (sb1.Text != "" && sb2.Text != "" && sb3.Text != "")
            {
                sum = amount1 + amount2 + amount3;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }
            else if (sb1.Text != "" && sb2.Text != "")
            {
                sum = amount1 + amount2;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }

            else if (sb1.Text != "")
            {
                sum = amount1;
                txtCalculate.Text = sum.ToString();
                cal_result = int.Parse(txtCalculate.Text);
            }
            else
            {
                txtCalculate.Text = "0";
                cal_result = int.Parse(txtCalculate.Text);
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ShowRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryShow = "select * from staff_record";
            SqlDataAdapter da = new SqlDataAdapter(queryShow, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            recordShow.DataSource = dt;
        }

        private void RecordShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sb6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sb5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sb4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sb3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboFee1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ServiceList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedItems = "";
            if (serviceList.CheckedItems.Count != 0)
            {
                switch (serviceList.CheckedItems.Count)
                {
                    case 1:
                        comboStyle1.Visible = true;
                        comboService1.Visible = true;
                        comboFee1.Visible = true;
                        sb1.Visible = true;
                        break;
                    case 2:
                        combostyle2.Visible = true;
                        comboService2.Visible = true;
                        comboFee2.Visible = true;
                        sb2.Visible = true;

                        break;
                    case 3:
                        combostyle3.Visible = true;
                        comboService3.Visible = true;
                        comboFee3.Visible = true;
                        sb3.Visible = true;

                        break;
                    case 4:
                        combostyle4.Visible = true;
                        comboService4.Visible = true;
                        comboFee4.Visible = true;
                        sb4.Visible = true;

                        break;
                    case 5:
                        combostyle5.Visible = true;
                        comboService5.Visible = true;
                        comboFee5.Visible = true;
                        sb5.Visible = true;

                        break;
                    case 6:
                        combostyle6.Visible = true;
                        comboService6.Visible = true;
                        comboFee6.Visible = true;

                        sb6.Visible = true;

                        break;



                }



            }

        }

        private void Combostyle6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboService6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboService5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combostyle5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboService4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combostyle4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combostyle3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboService3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboService2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Combostyle2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboStyle1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ShowRecordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string queryShow = "select staff_name , service_type,service_fee, date from staff_record";
            SqlDataAdapter da = new SqlDataAdapter(queryShow, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            recordShow.DataSource = dt;
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Reload_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryShow = "select staff_name , service_type,service_fee, date from staff_record where date='"+today+"'";
            SqlDataAdapter da = new SqlDataAdapter(queryShow, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            recordShow.DataSource = dt;
          
        }

        private void BtnClearAll_Click(object sender, EventArgs e)
        {
            comboFee1.SelectedItem = null;
            comboFee2.SelectedItem = null;
            comboFee3.SelectedItem = null;
            comboFee4.SelectedItem = null;
            comboFee5.SelectedItem = null;
            comboFee6.SelectedItem = null;
            comboStyle1.SelectedItem = null;
            combostyle2.SelectedItem = null;
            combostyle3.SelectedItem = null;
            combostyle4.SelectedItem = null;
            combostyle5.SelectedItem = null;
            combostyle6.SelectedItem = null;
            comboService1.SelectedItem = null;
            comboService2.SelectedItem = null;
            comboService3.SelectedItem = null;
            comboService4.SelectedItem = null;
            comboService5.SelectedItem = null;
            comboService6.SelectedItem = null;
            txtDiscount.Text = null;
            txtActualFee.Text = null;
            txtCalculate.Text = null;
            sb1.Text = null;
            sb2.Text = null;
            sb3.Text = null;
            sb4.Text = null;
            sb5.Text = null;
            sb6.Text = null;
           
        }

        private void RecordShow_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatePicker_ValueChanged_1(object sender, EventArgs e)
        {
            
            string pickDate=datePicker.Value.ToString("MM/dd/yyyy");
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            string queryShow = "select staff_name , service_type,service_fee, date from staff_record where date='" + pickDate + "'";
            SqlDataAdapter da = new SqlDataAdapter(queryShow, conn);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "staff_record");
            dt = ds.Tables["staff_record"];
            recordShow.DataSource = dt;
        }

        private void BtnGenerateCard_Click(object sender, EventArgs e)
        {
            MemberCardCreate mb = new MemberCardCreate();
    
            mb.Show();
        }

        private void ComboFee1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboService5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void BunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void PanelCotainer_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Sb6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sb5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sb4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sb2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sb3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Sb1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TxtCalculate_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtMember_TextChanged(object sender, EventArgs e)
        {

        }

        private void RdoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdoYes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void LblMessage_Click(object sender, EventArgs e)
        {

        }

        private void LblActualFee_Click(object sender, EventArgs e)
        {

        }

        private void TxtActualFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblDiscount_Click(object sender, EventArgs e)
        {

        }

        private void TxtDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void ComboFee6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboFee5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboFee4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboFee2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboFee3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Combostyle6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboService6_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Combostyle5_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboService4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Combostyle4_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Combostyle3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboService3_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void ComboService2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Combostyle2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

       
        private void Combostyle6_SelectedValueChanged(object sender, EventArgs e)
        {
            object b = combostyle6.SelectedItem;
            string stylist_name = Convert.ToString(b);
            stylists.Add(stylist_name);
        }






        private void RdoYes_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }

        private void RdoNo_CheckedChanged_1(object sender, EventArgs e)
        {
            
        }




        private void BtnInsertRecord_Click_1(object sender, EventArgs e)
        {

        }

    }
}

    


