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
    public partial class edit_runner_profile : MaterialSkin.Controls.MaterialForm
    {
        public edit_runner_profile()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet.Gender);

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            runner_menu run = new runner_menu();
            this.Hide();
            run.Show();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            runner_menu run = new runner_menu();
            this.Hide();
            run.Show();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
            runner_menu run = new runner_menu();
            this.Hide();
            run.Show();
        }

        private void materialFlatButton4_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }
    }
}
