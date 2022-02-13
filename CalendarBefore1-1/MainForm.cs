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
    public partial class MainForm : Form
    {
        event Action DayChange;

        public MainForm()
        {
            InitializeComponent();

            DayChange += OnDayChange;
        }

        private void minuteTimer_Tick(object sender, EventArgs e)
        {
            currentTimeLbl.Text = 
                DateTime.Now.ToString(@"HH:mm");

            if (currentTimeLbl.Text == "00:00")
                DayChange?.Invoke();

            if (minuteTimer.Interval != 60000)
                minuteTimer.Interval = 60000;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var currenttime = DateTime.Now;
            
            currentTimeLbl.Text =
                currenttime.ToString(@"HH:mm");

            dateLbl.Text = 
                currenttime.ToString(
                    @"dd MMMM yyyy");

            minuteTimer.Interval = 
                (60000 - currenttime.Second * 1000) +
                (1000 - currenttime.Millisecond);

            minuteTimer.Start();
        }

        private void OnDayChange()
        {
            dateLbl.Text = 
                DateTime.Now.ToString(
                    @"dd MMMM yyyy");
        }
    }
}
