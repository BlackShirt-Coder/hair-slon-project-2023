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
    public partial class Login : Form
    {
        public Login()
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
        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string password = txtPassword.Text;
         
          
                if (user == "admin" && password == "admin")
                {
                    Main main = new Main();
                    this.Hide();
                    main.Show();
                }
                else if (user == "cashier" && password == "cashier")
                {
                    Cashier rc = new Cashier();
                    this.Hide();
                    rc.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Credential");
                }
            }
        }
    }
