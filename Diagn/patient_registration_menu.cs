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
    public partial class patient_registration_menu : MaterialSkin.Controls.MaterialForm
    {
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
            if ((metroComboBox1.SelectedIndex < -1) ||
               ((metroTextBox1.Text.Equals("")) || (metroTextBox2.Text.Equals("")) || (metroTextBox3.Text.Equals("")) || (metroTextBox4.Text.Equals("")) || (metroTextBox5.Text.Equals(""))))
            { MessageBox.Show("Вы не ввели все необходимые данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if (metroTextBox2.Text.Length < 6)
            { MessageBox.Show("Пароль не может содержать меньше 6 символов", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else if (metroTextBox2.Text != metroTextBox3.Text)
            { MessageBox.Show("Пароль не совпадает! Пожалуйста, повторите пароль еще раз!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1); }

            else
            {
                DiagnosticDataSet1.View_UserDataTable View_User = new DiagnosticDataSet1.View_UserDataTable();
              //  View_User.Update_User(id, metroTextBox1.Text, metroTextBox2.Text, metroTextBox3.Text, metroTextBox4.Text, metroTextBox5.Text);
                service_registration service = new service_registration();
                this.Hide();
                service.Show();
            }

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
            

            //if (e.KeyChar != 8 && (e.KeyChar <= 97 || e.KeyChar >= 122))
            //{
            //    e.Handled = true;
            //}


            //char l = e.KeyChar;
            //if ((l < 'А' || l > 'я') && l != '8')
            //    e.Handled = true;
        }


    }
}
