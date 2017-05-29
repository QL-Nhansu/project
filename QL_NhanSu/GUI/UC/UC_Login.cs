using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UC.Login
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
        }

        public delegate bool Check(bool check);
        public Check myCheck;
        FormMain fm = new FormMain();
        public void btnSignIn_MouseClick(object sender, MouseEventArgs e)
        {
            bool check1 ;
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                check1 = false;
                erpSignIn.SetError(btnSignIn, "Chưa nhập tài khoản hoặc mật khẩu");
                // return check1;
               // myCheck = new Check(check1);


            }
            else if ( txtUsername.Text=="admin"&& txtPassword.Text=="admin")
            {
                erpSignIn.Clear();
                lblTryAgain.Visible = false;
                check1 = true;
                myCheck(check1);
                this.Dispose();
               // return check1;
            }
            else
            {
                check1 = false;
                erpSignIn.Clear();
                lblTryAgain.Visible = true;
                myCheck(check1);
                //  return check1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        public void btnSignIn_Load(object sender, EventArgs e)
        {
            bool check1;
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                check1 = false;
                erpSignIn.SetError(btnSignIn, "Chưa nhập tài khoản hoặc mật khẩu");
             //   return check1;
            }
            else if (txtUsername.Text == "admin" && txtPassword.Text == "admin")
            {
                erpSignIn.Clear();
                lblTryAgain.Visible = false;
                check1 = true;
                this.Dispose();
             //   return check1;
            }
            else
            {
                check1 = false;
                erpSignIn.Clear();
                lblTryAgain.Visible = true;
             //   return check1;
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTryAgain_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_MouseClick_1(object sender, MouseEventArgs e)
        {

        }
    }
}
