using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarBefore1_1
{
    public partial class CheckboxWithId : UserControl
    {
        public CheckboxWithId()
        {
            InitializeComponent();
        }

        public Guid Id { get; set; }

        public string CheckBoxText
        {
            get =>
                checkBox.Text;

            set =>
                checkBox.Text = value;
        }

        public bool CheckBoxChecked
        {
            get =>
                checkBox.Checked;

            set =>
                checkBox.Checked = value;
        }

        public Font CheckBoxFontStyle
        {
            get =>
                checkBox.Font;

            set =>
                checkBox.Font = value;
        }

        private void deleteBtn_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.ImageIndex = 1;
        }

        private void deleteBtn_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button.ImageIndex = 0;
        }

        private void deleteBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            button.ImageIndex = 2;
        }

        private void deleteBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;

            button.ImageIndex = 1;
        }
    }
}
