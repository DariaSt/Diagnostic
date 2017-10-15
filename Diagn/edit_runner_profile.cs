using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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
            int year = DifferenceDate();

             if (!((metroTextBox2.Text.Equals("")) && (metroTextBox3.Text.Equals(""))) ||
                (!Regex.IsMatch(metroTextBox2.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}")))
            {
                MessageBox.Show("Пароль должен содержать: Минимум 6 символов. Минимум 1 прописная буква. Минимум 1 цифра. По крайней мере один из следующих символов: ! @ # $ % ^.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (metroTextBox2.Text != metroTextBox3.Text)
            { MessageBox.Show("Пароль не совпадает! Пожалуйста, повторите пароль еще раз!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if (year < 16)
            { MessageBox.Show("Для регистрации ваш возраст должен быть не менее 16 лет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if ((metroComboBox1.SelectedIndex < -1) ||
               ((metroTextBox4.Text.Equals("")) || (metroTextBox5.Text.Equals(""))))
            { MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }


            else
            {
                service_registration service = new service_registration();
                this.Hide();
                service.Show();
            }

           
        }

        int DifferenceDate()
        {
            DateTime thisdate = DateTime.Now;
            DateTime date = dateTimePicker1.Value;


            TimeSpan difference = thisdate - date;

            int year = difference.Days;
            return year / 365;
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

        private void metroTextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void metroTextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)e.KeyChar == (Char)Keys.Back) return;
            if (char.IsLetter(e.KeyChar)) return;
            e.Handled = true;
        }

        private void edit_runner_profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
