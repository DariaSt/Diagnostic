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
    public partial class about_diagnostic_2017 : Form
    {
        public about_diagnostic_2017()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is interactive_map);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                interactive_map map = new interactive_map();
               
                map.Show();
            }
            //interactive_map map = new interactive_map();
            //this.Hide();
            //map.Show();
        }

        private void about_diagnostic_2017_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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
                find_out_more_information f = new find_out_more_information();
                
                f.Show();
            }
            //find_out_more_information f = new find_out_more_information();
            //this.Hide();
            //f.Show();
        }

       
    }
}
