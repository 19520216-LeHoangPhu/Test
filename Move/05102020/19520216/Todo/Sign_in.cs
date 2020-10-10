using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class FSignin : Form
    {
        USER person;
        string pathUser = @"./users";
        string pathID = @"./ids";
        public FSignin()
        {
            try
            {
                InitializeComponent();
                Directory.CreateDirectory(pathUser);
                Directory.CreateDirectory(pathID);
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void fsignin_Load(object sender, EventArgs e)
        {

        }

        private void btSignin_Click(object sender, EventArgs e)
        {
            try
            {
                person = new USER(tbUsername.Text, tbPassword.Text);
                if (IO.InputUser(pathUser, pathID, ref person))
                {
                    FTodos todos = new FTodos(this);
                    todos.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên dăng nhập hoặc mật khẩu không đúng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbUsername.Select();
                    tbUsername.Text = tbPassword.Text = "";
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }

        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fsignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void btsignup_Click(object sender, EventArgs e)
        {
            try
            {
                FSignup Signup = new FSignup(this);
                Signup.Show();
                this.Hide();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Keys.Return == e.KeyCode)
                {
                    if (tbUsername.Text == "")
                    {
                        MessageBox.Show("Tên dăng nhập bị rỗng!", "Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        tbPassword.Text = "";
                        tbUsername.Select();
                    }
                    else
                    {
                        btSignin_Click(sender, e);
                    }
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (Keys.Return == e.KeyCode)
            {
                if (tbUsername.Text == "")
                    MessageBox.Show("Tên dăng nhập bị rỗng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    tbPassword.Select();
            }
        }
    }
}
