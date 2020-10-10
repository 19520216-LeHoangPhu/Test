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
    public partial class FDialog : Form
    {
        FTodos parent;
        public FDialog(FTodos parent)
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

        private void Dialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.parent.Show();
                e.Cancel = false;
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void btcancel_Click(object sender, EventArgs e)
        {
            try
            {
                this.parent.Enabled = true; ;
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }
        private void btok_Click(object sender, EventArgs e)
        {
            this.parent.Enabled = true;
            this.Close();
        }
    }
}
