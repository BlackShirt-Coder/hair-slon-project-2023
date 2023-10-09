using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HairSlonManagementProject
{
    public partial class CardDesign : Form
    {
        public CardDesign()
        {
            InitializeComponent();
        }

        private void CardDesign_Load(object sender, EventArgs e)
        {
            label1.Text=MemberCardCreate.memberId.ToString();
            label2.Text = MemberCardCreate.memberName.ToString();
            label3.Text = "Phone :"+MemberCardCreate.phone.ToString();
            label4.Text = "Address :"+MemberCardCreate.address.ToString();

            label5.Text = "Expire Date :" + MemberCardCreate.exp_date.ToString() ;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
