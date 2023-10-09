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
    public partial class ManageStaff : UserControl
    {
        public ManageStaff()
        {
            InitializeComponent();
        }

       
        private void StaffGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StaffGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pContainer.Controls.Clear();
            pContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void BunifuButton4_Click(object sender, EventArgs e)
        {
            ViewStaff viewStaff = new ViewStaff();
            addUserControl(viewStaff);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddStaff addStaff = new AddStaff();
            addUserControl(addStaff);
        }

        private void ManageStaff_Load(object sender, EventArgs e)
        {
            StaffRecords sr = new StaffRecords();
            addUserControl(sr);
        }

        private void BunifuButton1_Click(object sender, EventArgs e)
        {
            StaffRecords sr = new StaffRecords();
            addUserControl(sr);
        }

        private void PContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
