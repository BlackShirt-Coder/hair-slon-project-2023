using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSlonManagementProject
{
    public partial class Payroll : UserControl
    {
        public Payroll()
        {
            InitializeComponent();
        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelCotainer.Controls.Clear();
            panelCotainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        private void BunifuButton3_Click(object sender, EventArgs e)
        {
            StaffPayRoll staffPay = new StaffPayRoll();
            addUserControl(staffPay);
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            Set_Salary set_Salary = new Set_Salary();
            addUserControl(set_Salary);
        }

        private void BtnViewSalary_Click(object sender, EventArgs e)
        {
            ViewSalary viewSalary = new ViewSalary();
            addUserControl(viewSalary);
        }
    }
}
