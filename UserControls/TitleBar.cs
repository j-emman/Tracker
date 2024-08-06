using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tracker.UserControls
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
        }

        private void titleBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.ParentForm != null)
            {
                WindowManager.ReleaseCapture();
                WindowManager.SendMessage(this.ParentForm.Handle, 0x112, 0xf012, 0);
            }
        }

        private void TitleBarExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
