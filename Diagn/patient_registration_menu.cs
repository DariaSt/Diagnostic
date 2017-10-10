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
    public partial class patient_registration_menu : MaterialSkin.Controls.MaterialForm
    {
        int? ID = null;

        public patient_registration_menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "diagnosticDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.diagnosticDataSet.Gender);

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            int year = DifferenceDate();
            
            if (!Regex.IsMatch(metroTextBox1.Text, @"\A[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\z"))
            {
                MessageBox.Show("Вы не правильно ввели адрес почты. Повторите попытку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }

            else if (!Regex.IsMatch(metroTextBox2.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{6,}"))
                {
                MessageBox.Show("Пароль должен содержать: Минимум 6 символов. Минимум 1 прописная буква. Минимум 1 цифра. По крайней мере один из следующих символов: ! @ # $ % ^.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

            }
            else if (metroTextBox2.Text != metroTextBox3.Text)
            { MessageBox.Show("Пароль не совпадает! Пожалуйста, повторите пароль еще раз!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if ( year < 16 )
            { MessageBox.Show("Для регистрации ваш возраст должен быть не менее 16 лет", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if ((metroComboBox1.SelectedIndex < -1) ||
               ((metroTextBox1.Text.Equals("")) || (metroTextBox2.Text.Equals("")) || (metroTextBox3.Text.Equals("")) || (metroTextBox4.Text.Equals("")) || (metroTextBox5.Text.Equals(""))))
            { MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }


            else
            {
                DiagnosticDataSet1.View_UserDataTable View_User = new DiagnosticDataSet1.View_UserDataTable();
              //  View_User.Update_User(id, metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text);
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
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
        }

        private void materialFlatButton3_Click(object sender, EventArgs e)
        {
           register_as_a_runner reg = new register_as_a_runner();
            this.Hide();           
            reg.Show();
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

        private void patient_registration_menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
