using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalendarBefore1_1
{
    public partial class CountDownInfoControl : UserControl
    {
        public CountDownInfoControl()
        {
            InitializeComponent();
        }

        internal Guid Id
        {
            get;

            set;
        }

        public string DateLblText
        {
            get => dateLbl.Text;

            set => dateLbl.Text = value;
        }

        public string DeleteLLblText
        {
            get => deleteLLbl.Text;

            set => deleteLLbl.Text = value;
        }

        public string TextLblText
        {
            get => textLbl.Text;

            set => textLbl.Text = value;
        }

        internal EventHandler AddHandlerDeleteLLblClick
        {
            set => deleteLLbl.Click += value;
        }

        public Font TextLblFont
        {
            get => textLbl.Font;

            set => textLbl.Font = value;
        }
    }
}
