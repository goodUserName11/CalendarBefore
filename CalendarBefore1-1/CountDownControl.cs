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
    public partial class CountDownControl : UserControl
    {
        public CountDownControl()
        {
            InitializeComponent();
        }

        public Guid Id { get; set; }

        public string CountDownText
        {
            get =>
                countDownTextBtn.Text;

            set =>
                countDownTextBtn.Text = value;
        }
    }
}
