using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPractice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        BelajarDataContext db = new BelajarDataContext();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = (from s in db.TB_M_USERs where s.username == txtUser.Text select s).First();
            if (user.password == txtPass.Text)
            {
                this.Hide();
                Form1 a = new Form1();
                a.Show();
            }
            else
            {
                MessageBox.Show("Password Error");
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
