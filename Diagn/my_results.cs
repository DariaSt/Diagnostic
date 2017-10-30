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
    public partial class my_results : Form
    {
        public my_results()
        {
            InitializeComponent();
        }
        int? User_id;
        public my_results(int? Id_User)
        {
            InitializeComponent();
            User_id = Id_User;
            People();
        }
        public void People() {
            DiagnosticDataSetTableAdapters.View_UserTableAdapter view_UserTableAdapter = new DiagnosticDataSetTableAdapters.View_UserTableAdapter();
            var rows = view_UserTableAdapter.GetData().Where(l => l.Id == User_id).ToArray();
            if (rows != null)
            {
                label8.Text = rows[0].Gender;
                DateTime date = rows[0].DateOfBirth;
                label9.Text = ((DateTime.Today.Year - date.Year)+ (DateTime.Today.Month < date.Month ? -1:0)).ToString();

            }

            DiagnosticDataSetTableAdapters.RegistrationServiceTableAdapter registrationServiceTableAdapter = new DiagnosticDataSetTableAdapters.RegistrationServiceTableAdapter();
            var serv = registrationServiceTableAdapter.GetData().Where(l => l.User_id == User_id).ToArray();
            if (serv != null)
            {
                var e = serv.Where(l => l.Service_id == 3);
                if (e.Count() > 0)
                {
                    label13.Text = e.First().last_service_date.ToShortDateString();
                    label14.Text = e.First().service_count.ToString();
                }
                else {
                    label13.Text = "-";
                    label14.Text = "0";

                }
                e = serv.Where(l => l.Service_id == 1);
                if (e.Count() > 0)
                {
                    label15.Text = e.First().last_service_date.ToShortDateString();
                    label16.Text = e.First().service_count.ToString();
                }
                else
                {
                    label15.Text = "-";
                    label16.Text = "0";

                }
                e = serv.Where(l => l.Service_id == 2);
                if (e.Count() > 0)
                {
                    label17.Text = e.First().last_service_date.ToShortDateString();
                    label18.Text = e.First().service_count.ToString();
                }
                else
                {
                    label17.Text = "-";
                    label18.Text = "0";

                }
            }
        }
        private void my_rez_Load(object sender, EventArgs e)
        {

        }

        private void my_results_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            runner_menu menu = new runner_menu();
            this.Hide();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            runner_menu menu = new runner_menu();
            this.Hide();
            menu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            previous_race_results previous = new previous_race_results();
            this.Hide();
            previous.Show();
        }
    }
}
