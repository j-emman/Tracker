using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tracker.Forms;

namespace Tracker
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        Main_Form main_Form;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_Form = new Main_Form();
            main_Form.Show();
        }
    }
}
