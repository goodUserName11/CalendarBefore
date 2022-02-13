using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarBefore1_1
{
    public partial class MdiParentForm : Form
    {
        public MdiParentForm()
        {
            InitializeComponent();

            MainForm mform = new MainForm();
            mform.MdiParent = this;
            mform.Show();
            ActivateMdiChild(MdiChildren[0]);

            DateTime.Today.ToShortDateString();
        }

        private void MdiParentForm_Shown(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
