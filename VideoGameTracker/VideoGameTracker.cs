using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoGameTracker
{
    public partial class VideoGameTrackerForm : Form
    {
        int buttonchoice = 0;
        public VideoGameTrackerForm()
        {
            InitializeComponent();
        }

        private void btngamelist_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Video Games:");
        }

        private void btnrent_Click(object sender, EventArgs e)
        {
            buttonchoice = 1;
            btnexit.Visible = false;
            btnexit.Enabled = false;
            txtinput.Enabled = true;
            txtinput.Visible = true;
            btnconfirm.Enabled = true;
            btnconfirm.Visible = true;



        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            if (txtinput.Text.Length <= 0)
            {
                MessageBox.Show("Enter a Game");
            }
            if (txtinput.Text.Length > 0)
            {
                if(buttonchoice == 1)
                {
                    MessageBox.Show(txtinput.Text + " Successfully Rented!");
                    txtinput.Clear();
                }
                else if (buttonchoice == 2)
                {
                    MessageBox.Show(txtinput.Text + " Successfully Returned!");
                    txtinput.Clear();
                }
            }

            btnexit.Visible = true;
            btnexit.Enabled = true;
            txtinput.Enabled = false;
            txtinput.Visible = false;
            btnconfirm.Enabled = false;
            btnconfirm.Visible = false;
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {   
            btnexit.Visible = false;
            btnexit.Enabled = false;
            txtinput.Enabled = true;
            txtinput.Visible = true;
            btnconfirm.Enabled = true;
            btnconfirm.Visible = true;

        }

        private void btncustomers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Customer: \nCustomer 1\nCustomer 2");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
