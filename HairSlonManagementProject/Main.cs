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

namespace HairSlonManagementProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
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



        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconButton1_Click(object sender, EventArgs e)
        {

        }

        private void IconButton6_Click(object sender, EventArgs e)
        {
            Payroll payroll = new Payroll();
            addUserControl(payroll);
        }

        private void IconButton4_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            addUserControl(dashboard);
        }

        private void IconButton1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        public  void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCotainer.Controls.Clear();
            panelCotainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        

        private void IconButton2_Click(object sender, EventArgs e)
        {
            ManageStaff ms = new ManageStaff();
            addUserControl(ms);
        }

        private void IconButton3_Click(object sender, EventArgs e)
        {
            ViewMember mv = new ViewMember();
            addUserControl(mv);
        }

        private void IconButton7_Click(object sender, EventArgs e)
        {
            ViewFeedback fb = new ViewFeedback();
            addUserControl(fb);
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void IconButton9_Click(object sender, EventArgs e)
        {

        }

        private void IconButton5_Click(object sender, EventArgs e)
        {
            Income ic = new Income();
            addUserControl(ic);
        }

        private void PanelCotainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IconButton8_Click(object sender, EventArgs e)
        {
            MemberIncome ic = new MemberIncome();
            addUserControl(ic);
        }
    }
}
    
