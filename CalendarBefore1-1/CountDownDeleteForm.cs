using System;
using System.IO;
using System.Windows.Forms;

namespace CalendarBefore1_1
{
    internal partial class CountDownDeleteForm : Form
    {
        #region Hackish scrollbar solution
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            try
            {
                ScrollbarOverrider.ShowScrollBar(countDownInfoTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_VERT, true);
                ScrollbarOverrider.ShowScrollBar(countDownInfoTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_HORZ, false);
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                File.AppendAllText("log.txt", $"message:{e.Message}, stack: {e.StackTrace}");
            }

            base.WndProc(ref m);
        }
        #endregion

        CountDownInfoControl _tableHeader;

        CountDownDateList _countDownList;

        public CountDownDeleteForm()
        {
            InitializeComponent();

            _tableHeader = (CountDownInfoControl)countDownInfoTable.Controls[0];

            countDownInfoTable.MouseWheel += eventsTable_MouseWheel;
        }

        public CountDownDeleteForm(CountDownDateList countDownList) : this()
        {
            _countDownList = countDownList;
        }

        private void CountDownDeleteForm_Load(object sender, EventArgs e)
        {
            countDownInfoTable.Controls.Clear();

            countDownInfoTable.Controls.Add(_tableHeader);
            countDownInfoTable.RowStyles[0].SizeType = SizeType.AutoSize;

            var countDownList = _countDownList.CountDownList;

            foreach (var item in countDownList)
            {
                var newCountDownInfo = new CountDownInfoControl()
                {
                    Id = item.Id,
                    TextLblText = $"{item.Text}",
                    DateLblText = item.Date.ToShortDateString(),
                    AddHandlerDeleteLLblClick = countDownDelete_Click
                };

                countDownInfoTable.Controls.Add(newCountDownInfo);
                countDownInfoTable.RowStyles[1].SizeType = SizeType.AutoSize;
            }
        }

        private void eventsTable_Scroll(object sender, ScrollEventArgs e)
        {
            var table = (TableLayoutPanel)sender;

            table.PerformLayout();
        }

        private void eventsTable_MouseWheel(object sender, MouseEventArgs e)
        {
            var table = (TableLayoutPanel)sender;

            table.PerformLayout();
        }

        private void countDownDelete_Click(object sender, EventArgs e)
        {
            var countDownInfoControl = 
                (CountDownInfoControl)((LinkLabel)sender).Parent;

            _countDownList.CountDownList = _countDownList.CountDownList.FindAll(myCd => myCd.Id != countDownInfoControl.Id);

            countDownInfoTable.Controls.Remove(countDownInfoControl);
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
