using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagn
{
    public partial class interactive_map : Form
    {
        public interactive_map()
        {
            InitializeComponent();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.Orange;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;
           
            
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.WhiteSmoke;
            label1.BackColor = Color.Orange;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.Orange;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.Orange;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.Orange;
            label3.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.Orange;
            label2.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            label1.BackColor = Color.WhiteSmoke;
            label2.BackColor = Color.WhiteSmoke;
            label3.BackColor = Color.WhiteSmoke;
            label4.BackColor = Color.WhiteSmoke;
            label5.BackColor = Color.WhiteSmoke;
            label6.BackColor = Color.WhiteSmoke;
           
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is find_out_more_information);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                find_out_more_information information = new find_out_more_information();
               
                information.Show();
            }
            //find_out_more_information information = new find_out_more_information();
            //this.Hide();
            //information.Show();
        }

        private void interactive_map_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
