using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class FSignup : Form
    {
        dynamic parent;
        private bool CheckSignUp = false; 
        public FSignup(dynamic parent)
        {
            try
            {
                InitializeComponent();
                this.parent = parent;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FSignup_Load(object sender, EventArgs e)
        {
            
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            try 
            {
                this.parent.Show();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btsigup_Click(object sender, EventArgs e)
        {
            try
            {
                FTodos Todo = new FTodos(this.parent);
                if (IO.SignUp(this)
                    Todo.Show();
                CheckSignUp = true;
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void FSignup_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!CheckSignUp)
                    this.parent.Show();
                e.Cancel = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Keys.Return == e.KeyCode)
                {
                    if (tbUsername.Text == "")
                    {
                        MessageBox.Show("Username không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tbpassword.Select();   
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbpassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Keys.Return == e.KeyCode)
                {
                    if (tbpassword.Text == "")
                    {
                        MessageBox.Show("Password không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    tbconfirmpass.Select();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void tbconfirmpass_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (Keys.Return == e.KeyCode)
                {
                    if (tbconfirmpass.Text == "")
                    {
                        MessageBox.Show("Confirm password không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    btsigup_Click(sender, e);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
