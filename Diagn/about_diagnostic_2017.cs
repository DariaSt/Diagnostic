﻿using System;
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
    public partial class about_diagnostic_2017 : MaterialSkin.Controls.MaterialForm
    {
        public about_diagnostic_2017()
        {
            InitializeComponent();
        }

        private void information_Load(object sender, EventArgs e)
        {
        
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            find_out_more_information f = new find_out_more_information();
            this.Hide();
            f.Show();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            interactive_map map = new interactive_map();
            this.Hide();
            map.Show();
        }

        private void about_diagnostic_2017_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
