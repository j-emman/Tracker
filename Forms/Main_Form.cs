using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker.Forms
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        ActivityManager_Form AM_Form;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AM_Form = new ActivityManager_Form();
            AM_Form.Show();
        }
    }
}
