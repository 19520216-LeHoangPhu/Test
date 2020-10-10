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
    public partial class FTodos : Form
    {
        dynamic parent;
        public FTodos(dynamic parent)
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

        private void fTodos_Load(object sender, EventArgs e)
        {
            this.parent.Hide();
        }

        private void btlogout_Click(object sender, EventArgs e)
        {
            try
            {
                parent.Show();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void fTodos_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                parent.Show();
                e.Cancel = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            FDialog dialog = new FDialog(this);
            dialog.Show();
            this.Enabled = false;
        }
    }
}
