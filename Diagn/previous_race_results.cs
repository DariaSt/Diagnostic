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
    public partial class previous_race_results : MaterialSkin.Controls.MaterialForm
    {
        public previous_race_results()
        {
            InitializeComponent();
        }

        private void Rez_Load(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            find_out_more_information find = new find_out_more_information();
            find.ShowDialog();
        }
    }
}
