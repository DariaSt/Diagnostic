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
    public partial class edit_runner_profile : Form
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

     

        private void button1_Click(object sender, EventArgs e)
        {
            runner_menu run = new runner_menu();
            this.Hide();
            run.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main_screen_of_the_system main = new main_screen_of_the_system();
            this.Hide();
            main.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            if ((comboBox1.SelectedIndex < -1) ||
               (textBox3.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox1.Text.Equals("")))
            { MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            //else if (metroTextBox2.Text.Length < 6)
            //{ MessageBox.Show("Пароль не может содержать меньше 6 символов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            //else if (metroTextBox2.Text != metroTextBox3.Text)
            //{ MessageBox.Show("Пароль не совпадает! Пожалуйста, повторите пароль еще раз!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else
            {
                service_registration service = new service_registration();
                this.Hide();
                service.Show();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            runner_menu run = new runner_menu();
            this.Hide();
            run.Show();
        }

        
    }
}
