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
    public partial class CalendarDialogForm : Form
    {
        DateTime _selectedDate;
        DateTime _currentTime;

        public bool CanChangeDate;

        public CalendarDialogForm()
        {
            InitializeComponent();
        }

        public CalendarDialogForm(string caption, DateTime currDate, DateTime selectedDate) : this()
        {
            this.Text = caption;

            _currentTime = currDate;

            monthCalendar.TodayDate = currDate;
            monthCalendar.SelectionStart = selectedDate;

            SelectedDate = selectedDate;
        }

        public DateTime SelectedDate
        {
            get => 
                new DateTime(_selectedDate.Ticks);
            
            private set => 
                _selectedDate = value;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            CanChangeDate = (SelectedDate.Date == monthCalendar.TodayDate.Date);

            this.Close();
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = e.Start;

            SelectedDate = SelectedDate.AddHours(_currentTime.Hour);
        }
    }
}
