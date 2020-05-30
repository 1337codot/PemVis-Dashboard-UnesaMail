using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnesaMail.UserControls;

namespace UnesaMail
{
    public partial class Form1 : Form
    {
        public Form1 ()
        {
            InitializeComponent();
            
            
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 118, b.Location.Y - 30);
            imgSlide.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            {
                uC_Inbox1.Visible = false;
                uC_Sent1.Visible = true;
                uC_Outbox1.Visible = false;
                uC_Spam1.Visible = false;
                uC_Draft1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_Inbox1.Visible = true;
            uC_Sent1.Visible = false;
            uC_Outbox1.Visible = false;
            uC_Spam1.Visible = false;
            uC_Draft1.Visible = false;
        }
        private void Form1_Load (object sender, EventArgs e)
        {
            uC_Inbox1.Visible = true;
            uC_Sent1.Visible = false;
            uC_Outbox1.Visible = false;
            uC_Spam1.Visible = false;
            uC_Draft1.Visible = false;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            {
                uC_Inbox1.Visible = false;
                uC_Sent1.Visible = false;
                uC_Outbox1.Visible = true;
                uC_Spam1.Visible = false;
                uC_Draft1.Visible = false;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            {
                uC_Inbox1.Visible = false;
                uC_Sent1.Visible = false;
                uC_Outbox1.Visible = false;
                uC_Spam1.Visible = true;
                uC_Draft1.Visible = false;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            {
                uC_Inbox1.Visible = false;
                uC_Sent1.Visible = false;
                uC_Outbox1.Visible = false;
                uC_Spam1.Visible = false;
                uC_Draft1.Visible = true;
            }
        }

        private void uC_Spam1_Load(object sender, EventArgs e)
        {

        }
    }
}
