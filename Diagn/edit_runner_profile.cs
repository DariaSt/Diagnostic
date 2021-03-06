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
    public partial class edit_runner_profile : Form
    {
        public edit_runner_profile()
        {
            InitializeComponent();
        }
        int? User_id;
        public edit_runner_profile(int? Id_User)
        {
            InitializeComponent();
            //  User_id = Id_User;
            User_id = ClassRole._UserID;
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet.Gender);
            People();
        }
        public void People() {
            DiagnosticDataSetTableAdapters.View_UserTableAdapter view_UserTableAdapter = new DiagnosticDataSetTableAdapters.View_UserTableAdapter();
            var rows = view_UserTableAdapter.GetData().Where(l => l.Id == User_id).ToArray();
            if (rows != null)
            {
                textBox3.Text = rows[0].Email;
                textBox2.Text = rows[0].FirstName;
                textBox1.Text = rows[0].LastName;
                dateTimePicker1.Value = rows[0].DateOfBirth;
                textBox5.Text = rows[0].Password;
                textBox4.Text = rows[0].Password;
                comboBox1.Text = rows[0].Gender;

            }
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runner_menu);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runner_menu run = new runner_menu();
               
                run.Show();
            }
            /*  runner_menu run = new runner_menu();
              this.Hide();
              run.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClassRole.Role = 1;
            ClassRole._UserID = 0;
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is main_screen_of_the_system);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                main_screen_of_the_system main = new main_screen_of_the_system();
               
                main.Show();
            }
            //main_screen_of_the_system main = new main_screen_of_the_system();
            //this.Hide();
            //main.Show();
        }

        public object TextBoxsProverka(string v)
        {
            throw new NotImplementedException();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        public bool TextBoxsProverka(string tx1, string tx2, string tx3)
        {
            return  (tx1.Equals("") || tx2.Equals("") || tx3.Equals("")) ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex < -1) || TextBoxsProverka(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            //else if (metroTextBox2.Text.Length < 6)
            //{ MessageBox.Show("Пароль не может содержать меньше 6 символов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            //else if (metroTextBox2.Text != metroTextBox3.Text)
            //{ MessageBox.Show("Пароль не совпадает! Пожалуйста, повторите пароль еще раз!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }
            
            else
            {
                DiagnosticDataSetTableAdapters.View_UserTableAdapter view_UserTableAdapter = new DiagnosticDataSetTableAdapters.View_UserTableAdapter();
                view_UserTableAdapter.Update_User(User_id, textBox2.Text, textBox1.Text, (int)comboBox1.SelectedValue, dateTimePicker1.Value, textBox3.Text, textBox4.Text, 2, null);

                this.Hide();
                var formToShow = Application.OpenForms.Cast<Form>()
               .FirstOrDefault(c => c is service_registration);
                if (formToShow != null)
                {

                    if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                    formToShow.TopMost = true;
                    formToShow.Visible = true;
                }
                else
                {
                    service_registration service = new service_registration();
                    
                    service.Show();
                }
                //service_registration service = new service_registration();
                //this.Hide();
                //service.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formToShow = Application.OpenForms.Cast<Form>()
           .FirstOrDefault(c => c is runner_menu);
            if (formToShow != null)
            {

                if (formToShow.WindowState == FormWindowState.Minimized) formToShow.WindowState = FormWindowState.Normal;
                formToShow.TopMost = true;
                formToShow.Visible = true;
            }
            else
            {
                runner_menu run = new runner_menu();
               
                run.Show();
            }
            //runner_menu run = new runner_menu();
            //this.Hide();
            //run.Show();
        }

        
    }
}
