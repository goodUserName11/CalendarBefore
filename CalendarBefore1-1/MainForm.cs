using Newtonsoft.Json;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CalendarBefore1_1
{


    public partial class MainForm : Form
    {

        #region Hackish scrollbar solution
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            try
            {
                ScrollbarOverrider.ShowScrollBar(eventsTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_VERT, true);
                ScrollbarOverrider.ShowScrollBar(eventsTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_HORZ, false);

                ScrollbarOverrider.ShowScrollBar(countDownTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_VERT, true);
                ScrollbarOverrider.ShowScrollBar(countDownTable.Handle, (int)ScrollbarOverrider.ScrollBarDirection.SB_HORZ, false);
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                File.AppendAllText("log.txt", $"message:{e.Message}, stack: {e.StackTrace}");
            }

            base.WndProc(ref m);
        }
        #endregion

        const string _eventsSaveFile = @"events.json";
        const string _countDownsSaveFile = @"countDowns.json";

        const short _maxEventTextSize = 30;
        const short _maxCountDownTextSize = 30;

        DateTime _currDateTime;
        DateTime _displayDate;

        EventsList _eventsList;
        CountDownDateList _countDownList;

        internal bool CanChangeDay = true;

        event Action DayChange;
        event Action HourChange;

        public MainForm()
        {
            InitializeComponent();

            _eventsList = new EventsList();
            _countDownList = new CountDownDateList();

            DayChange += OnDayChange;
            HourChange += OnHourChange;

            eventsTable.MouseWheel += eventsTable_MouseWheel;
            countDownTable.MouseWheel += eventsTable_MouseWheel;
        }

        private void minuteTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLbl.Text = 
                DateTime.Now.ToString(@"HH:mm");

            if (currentTimeLbl.Text == "00:00")
                DayChange?.Invoke();

            if (currentTimeLbl.Text.EndsWith("00")) 
                HourChange?.Invoke();

            if (minuteTimer.Interval != 60000)
                minuteTimer.Interval = 60000;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _currDateTime = DateTime.Now;

            _displayDate = _currDateTime;

            currentTimeLbl.Text =
                _currDateTime.ToString(@"HH:mm");

            dateLbl.Text =
                _displayDate.ToString(
                    @"dd MMMM yyyy");

            minuteTimer.Interval = 
                (60000 - _currDateTime.Second * 1000) +
                (1000 - _currDateTime.Millisecond);

            minuteTimer.Start();

            #region Event
            if (File.Exists(_eventsSaveFile))
            {
                _eventsList =
                    JsonConvert.
                    DeserializeObject<EventsList>(
                        File.ReadAllText(_eventsSaveFile));

                eventsTable.Controls.Clear();

                var eventList = 
                    _eventsList.EventList.
                     Where(myEvent => myEvent.Date.Date == _displayDate.Date).ToList();

                foreach (var item in eventList)
                {
                    var newCBox = new CheckboxWithId()
                    {
                        Id = item.Id,
                        CheckBoxText = item.Text,
                    };

                    newCBox.deleteBtn.Click += deleteEventBtn_Click;

                    eventsTable.Controls.Add(newCBox);
                }
            }
            #endregion

            #region CountDown

            if (File.Exists(_countDownsSaveFile))
            {
                _countDownList = JsonConvert.
                    DeserializeObject<CountDownDateList>(
                        File.ReadAllText(_countDownsSaveFile));

                countDownTable.Controls.Clear();

                var countDownList = _countDownList.CountDownList;

                foreach (var item in countDownList)
                {
                    var newCountDown = new CountDownControl()
                    {
                        Id = item.Id,
                        CountDownText =
                        $"До {item.Text}: {item.TillCurrentDateRemained(_displayDate)}",
                    };

                    countDownTable.Controls.Add(newCountDown);
                    countDownTable.RowStyles[0].SizeType = SizeType.AutoSize;
                    newCountDown.Anchor = AnchorStyles.Top;
                }
            }
            #endregion
        }

        private void OnDayChange()
        {
            _currDateTime = DateTime.Now;

            if (CanChangeDay)
            {
                dateLbl.Text =
                    _currDateTime.ToString(@"dd MMMM yyyy");

                eventsTable.Controls.Clear();

                var eventList =
                    _eventsList.EventList.
                     Where(myEvent => myEvent.Date.Date == _displayDate.Date).ToList();

                foreach (var item in eventList)
                {
                    var newCBox = new CheckboxWithId()
                    {
                        Id = item.Id,
                        CheckBoxText = item.Text,
                    };

                    newCBox.deleteBtn.Click += deleteEventBtn_Click;

                    eventsTable.Controls.Add(newCBox);
                }
            }
        }

        private void OnHourChange()
        {
            countDownTable.Controls.Clear();

            var countDownList = _countDownList.CountDownList;

            foreach (var item in countDownList)
            {
                var newCountDown = new CountDownControl()
                {
                    Id = item.Id,
                    CountDownText = 
                    $"До {item.Text}: {item.TillCurrentDateRemained(_displayDate)}",
                    AutoSize = true
                };

                countDownTable.Controls.Add(newCountDown);
                newCountDown.Anchor = AnchorStyles.Top;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show(
                 "Сохранить данные?",
                 "Закрыть приложение",
                 MessageBoxButtons.YesNoCancel);

            e.Cancel = (window == DialogResult.Cancel);

            if(window == DialogResult.Yes)
            {
                File.WriteAllText(_eventsSaveFile,
                    JsonConvert.SerializeObject(_eventsList));

                File.WriteAllText(_countDownsSaveFile,
                    JsonConvert.SerializeObject(_countDownList));
            }
        }

        private void monthLbl_Click(object sender, EventArgs e)
        {
            CalendarDialogForm cf = 
                new CalendarDialogForm("Календарь", DateTime.Now, _displayDate);

            if (cf.ShowDialog() == DialogResult.OK)
            {
                _displayDate = cf.SelectedDate;

                dateLbl.Text = _displayDate.Date.ToString(@"dd MMMM yyyy");

                CanChangeDay = cf.CanChangeDate;

                todayLbl.Visible = CanChangeDay;
                todayLbl.Enabled = CanChangeDay;

                todayLLbl.Visible = !CanChangeDay;
                todayLLbl.Visible = !CanChangeDay;

                #region Event
                eventsTable.Controls.Clear();

                var eventList =
                    _eventsList.EventList.
                    Where(myEvent => myEvent.Date.Date == _displayDate.Date).ToList();

                foreach (var item in eventList)
                {
                    var newCBox = new CheckboxWithId()
                    {
                        Id = item.Id,
                        CheckBoxText = item.Text,
                    };

                    newCBox.deleteBtn.Click += deleteEventBtn_Click;

                    eventsTable.Controls.Add(newCBox);
                }
                #endregion

                #region CountDown
                countDownTable.Controls.Clear();

                var countDownList = _countDownList.CountDownList;

                foreach (var item in countDownList)
                {
                    var newCountDown = new CountDownControl()
                    {
                        Id = item.Id,
                        CountDownText =
                        $"До {item.Text}: {item.TillCurrentDateRemained(_displayDate)}",
                        AutoSize = true
                    };

                    countDownTable.Controls.Add(newCountDown);
                    newCountDown.Anchor = AnchorStyles.Top;
                }
                #endregion


            }
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            AddEventDialog addForm = new AddEventDialog(_maxEventTextSize);

            if (addForm.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(addForm.Event.Text))
                    addForm.Event.Text = " ";

                _eventsList.
                    EventList.
                    Add(addForm.Event);

                if (addForm.Event.Date.Date == _displayDate.Date)
                {
                    var newCBox = new CheckboxWithId()
                    {
                        CheckBoxText = addForm.Event.Text,
                        Id = addForm.Event.Id,
                    };

                    newCBox.deleteBtn.Click += deleteEventBtn_Click;

                    eventsTable.Controls.Add(newCBox);
                }
            }
        }

        private void chooseDateBtn_Click(object sender, EventArgs e)
        {
            AddCountDownDialog cd = 
                new AddCountDownDialog(_currDateTime.Date, _maxCountDownTextSize);

            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(cd.CountDown.Text))
                    cd.CountDown.Text = " ";

                _countDownList.
                    CountDownList.
                    Add(cd.CountDown);

                var newCountDown = new CountDownControl()
                {
                    CountDownText = $"До {cd.CountDown.Text}: " +
                    $"{cd.CountDown.TillCurrentDateRemained(_displayDate)}",
                    Id = cd.CountDown.Id,
                    AutoSize = true
                };

                //countDownTable.RowStyles[0].SizeType = SizeType.AutoSize;
                countDownTable.Controls.Add(newCountDown);
                newCountDown.Anchor = AnchorStyles.Top;
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

        private void chooseDateBtn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            btn.ImageIndex = 2;
        }

        private void chooseDateBtn_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            btn.ImageIndex = 1;
        }

        private void chooseDateBtn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            
            btn.ImageIndex = 0;
        }

        private void chooseDateBtn_MouseUp(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;

            btn.ImageIndex = 1;
        }

        private void deleteEventBtn_Click(object sender, EventArgs e)
        {
            var eventControl = (CheckboxWithId)((Button)sender).Parent;

            _eventsList.EventList = _eventsList.EventList.FindAll(myEvent => myEvent.Id != eventControl.Id);

            eventsTable.Controls.Remove(eventControl);
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            minuteTimer.Stop();

            _currDateTime = DateTime.Now;

            if(CanChangeDay)
                _displayDate = _currDateTime;

            currentTimeLbl.Text =
                _currDateTime.ToString(@"HH:mm");

            dateLbl.Text =
                _displayDate.ToString(
                    @"dd MMMM yyyy");

            minuteTimer.Interval =
                (60000 - _currDateTime.Second * 1000) +
                (1000 - _currDateTime.Millisecond);

            minuteTimer.Start();

            #region Event
            eventsTable.Controls.Clear();

            var eventList =
                _eventsList.EventList.
                 Where(myEvent => myEvent.Date.Date == _displayDate.Date).ToList();

            foreach (var item in eventList)
            {
                var newCBox = new CheckboxWithId()
                {
                    Id = item.Id,
                    CheckBoxText = item.Text,
                };

                newCBox.deleteBtn.Click += deleteEventBtn_Click;

                eventsTable.Controls.Add(newCBox);
            }
            #endregion

            #region CountDown
            countDownTable.Controls.Clear();

            var countDownList = _countDownList.CountDownList;

            foreach (var item in countDownList)
            {
                var newCountDown = new CountDownControl()
                {
                    Id = item.Id,
                    CountDownText =
                    $"До {item.Text}: {item.TillCurrentDateRemained(_displayDate)}",
                };

                countDownTable.Controls.Add(newCountDown);
                countDownTable.RowStyles[0].SizeType = SizeType.AutoSize;
                newCountDown.Anchor = AnchorStyles.Top;
            }
            #endregion
        }

        private void deleteCountDownBtn_Click(object sender, EventArgs e)
        {
            CountDownDeleteForm cd = new CountDownDeleteForm(_countDownList);

            cd.ShowDialog();
        }

        private void todayLLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _displayDate = _currDateTime;

            dateLbl.Text = _displayDate.Date.ToString(@"dd MMMM yyyy");

            CanChangeDay = true;

            todayLbl.Visible = CanChangeDay;
            todayLbl.Enabled = CanChangeDay;

            todayLLbl.Visible = !CanChangeDay;
            todayLLbl.Visible = !CanChangeDay;
        }
    }
}
