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
    public partial class MemberCardCreate : Form
    {
        public MemberCardCreate()
        {
            InitializeComponent();
        }

        //generate 6 random numbers
        private static string GenerateRandomNumber()
        {
            Random generator = new Random();
            string r = generator.Next(0, 1000000).ToString("D6");
            if (r.Distinct().Count() == 1)
            {
                r = GenerateRandomNumber();
            }
            return r;
        }
        public static int memberId;
        public static string memberName, phone, address, date,exp_date;

        private void MemberCardCreate_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
           if(txtMemberName.Text !="" && txtFee.Text !="" && txtAddress.Text !="" && txtPhone.Text != "")
            {
                memberId = int.Parse(MemberCardCreate.GenerateRandomNumber());
                memberName = txtMemberName.Text.ToString();
                int fees = int.Parse(txtFee.Text.ToString());
                phone = txtPhone.Text.ToString();
                address = txtAddress.Text.ToString();
                date = datePicker.Value.ToString();
                exp_date = DateTime.Parse(MemberCardCreate.date).AddMonths(6).ToString();
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\database fle\counter.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                string query = "insert into members values(@member_id,@member_name,@phone,@address,@card_create_date,@card_expire_date,@card_fees)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@member_id", memberId);
                cmd.Parameters.AddWithValue("@member_name", memberName);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@card_create_date", date);
                cmd.Parameters.AddWithValue("@card_expire_date", exp_date);
                cmd.Parameters.AddWithValue("@card_fees", fees);

                cmd.ExecuteNonQuery();

                new CardDesign().ShowDialog();

            }
            else
            {
                btnGenerate.Enabled = false;
            }



        }
    }
}
