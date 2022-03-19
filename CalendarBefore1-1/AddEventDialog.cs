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
    public partial class AddEventDialog : Form
    {
        int _maxTextSize = 30;

        public AddEventDialog()
        {
            InitializeComponent();
        }

        public AddEventDialog(int maxTextSize) : this()
        {
            _maxTextSize = maxTextSize;

            maxTextLbl.Text = $"/{_maxTextSize}";
        }

        internal MyEvent Event
        {
            get;

            private set;
        } 

        private void addBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            Event = 
                new MyEvent(
                    textTxt.Text,
                    dateTimePicker.Value);

            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void textTxt_TextChanged(object sender, EventArgs e)
        {
            if(textTxt.Text.Length > _maxTextSize)
            {
                textTxt.Text = textTxt.Text.Substring(0, _maxTextSize);
                textTxt.SelectionStart = _maxTextSize;
            }

            maxCounterLbl.Text = textTxt.Text.Length.ToString();
        }

        private void addBtn_MouseDown(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;

            btn.ImageIndex = 2;
        }

        private void addBtn_MouseEnter(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            btn.ImageIndex = 1;
        }

        private void addBtn_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            btn.ImageIndex = 0;
        }

        private void addBtn_MouseUp(object sender, MouseEventArgs e)
        {
            var btn = (Button)sender;

            btn.ImageIndex = 1;
        }
    }
}
