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
    public partial class certificate_preview : MaterialSkin.Controls.MaterialForm
    {
        public certificate_preview()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void certificate_preview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
