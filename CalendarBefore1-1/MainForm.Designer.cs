namespace CalendarBefore1_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.currentTimeLbl = new System.Windows.Forms.Label();
            this.minuteTimer = new System.Windows.Forms.Timer(this.components);
            this.centerMarkV1 = new System.Windows.Forms.Label();
            this.centerMarkV2 = new System.Windows.Forms.Label();
            this.centerMarkH1 = new System.Windows.Forms.Label();
            this.centerMarkH2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.centerMarkC = new System.Windows.Forms.Label();
            this.dateLbl = new System.Windows.Forms.Label();
            this.eventsTable = new System.Windows.Forms.TableLayoutPanel();
            this.checkboxWithId3 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId2 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId1 = new CalendarBefore1_1.CheckboxWithId();
            this.deleteCountDownBtn = new System.Windows.Forms.Button();
            this.BtnDeleteImgList = new System.Windows.Forms.ImageList(this.components);
            this.BtnsImgList = new System.Windows.Forms.ImageList(this.components);
            this.addEventBtn = new System.Windows.Forms.Button();
            this.chooseDateBtn = new System.Windows.Forms.Button();
            this.todayLbl = new System.Windows.Forms.Label();
            this.monthLLbl = new System.Windows.Forms.LinkLabel();
            this.yearLLbl = new System.Windows.Forms.LinkLabel();
            this.cerpPicBox = new System.Windows.Forms.PictureBox();
            this.hammerPicBox = new System.Windows.Forms.PictureBox();
            this.countDownTable = new System.Windows.Forms.TableLayoutPanel();
            this.todayLLbl = new System.Windows.Forms.LinkLabel();
            this.countDownControl1 = new CalendarBefore1_1.CountDownControl();
            this.etaloneEventChBox = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId7 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId8 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId9 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId4 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId5 = new CalendarBefore1_1.CheckboxWithId();
            this.checkboxWithId6 = new CalendarBefore1_1.CheckboxWithId();
            this.eventsTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerpPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // currentTimeLbl
            // 
            this.currentTimeLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.currentTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTimeLbl.ForeColor = System.Drawing.Color.White;
            this.currentTimeLbl.Location = new System.Drawing.Point(600, 32);
            this.currentTimeLbl.Name = "currentTimeLbl";
            this.currentTimeLbl.Size = new System.Drawing.Size(188, 72);
            this.currentTimeLbl.TabIndex = 0;
            this.currentTimeLbl.Text = "33:33";
            this.currentTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minuteTimer
            // 
            this.minuteTimer.Interval = 10000;
            this.minuteTimer.Tick += new System.EventHandler(this.minuteTimer_Tick);
            // 
            // centerMarkV1
            // 
            this.centerMarkV1.AutoSize = true;
            this.centerMarkV1.BackColor = System.Drawing.Color.Transparent;
            this.centerMarkV1.ForeColor = System.Drawing.Color.Red;
            this.centerMarkV1.Location = new System.Drawing.Point(683, 128);
            this.centerMarkV1.Name = "centerMarkV1";
            this.centerMarkV1.Size = new System.Drawing.Size(9, 143);
            this.centerMarkV1.TabIndex = 7;
            this.centerMarkV1.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            this.centerMarkV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerMarkV1.Visible = false;
            // 
            // centerMarkV2
            // 
            this.centerMarkV2.AutoSize = true;
            this.centerMarkV2.BackColor = System.Drawing.Color.Transparent;
            this.centerMarkV2.ForeColor = System.Drawing.Color.Red;
            this.centerMarkV2.Location = new System.Drawing.Point(683, 584);
            this.centerMarkV2.Name = "centerMarkV2";
            this.centerMarkV2.Size = new System.Drawing.Size(9, 143);
            this.centerMarkV2.TabIndex = 7;
            this.centerMarkV2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            this.centerMarkV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerMarkV2.Visible = false;
            // 
            // centerMarkH1
            // 
            this.centerMarkH1.AutoSize = true;
            this.centerMarkH1.BackColor = System.Drawing.Color.Transparent;
            this.centerMarkH1.ForeColor = System.Drawing.Color.Red;
            this.centerMarkH1.Location = new System.Drawing.Point(0, 384);
            this.centerMarkH1.Name = "centerMarkH1";
            this.centerMarkH1.Size = new System.Drawing.Size(373, 13);
            this.centerMarkH1.TabIndex = 7;
            this.centerMarkH1.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            this.centerMarkH1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerMarkH1.Visible = false;
            // 
            // centerMarkH2
            // 
            this.centerMarkH2.AutoSize = true;
            this.centerMarkH2.BackColor = System.Drawing.Color.Transparent;
            this.centerMarkH2.ForeColor = System.Drawing.Color.Red;
            this.centerMarkH2.Location = new System.Drawing.Point(976, 384);
            this.centerMarkH2.Name = "centerMarkH2";
            this.centerMarkH2.Size = new System.Drawing.Size(373, 13);
            this.centerMarkH2.TabIndex = 7;
            this.centerMarkH2.Text = "---------------------------------------------------------------------------------" +
    "-----------------------------------------";
            this.centerMarkH2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerMarkH2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(688, -56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "+";
            this.label2.Visible = false;
            // 
            // centerMarkC
            // 
            this.centerMarkC.AutoSize = true;
            this.centerMarkC.BackColor = System.Drawing.Color.Transparent;
            this.centerMarkC.ForeColor = System.Drawing.Color.Red;
            this.centerMarkC.Location = new System.Drawing.Point(683, 384);
            this.centerMarkC.Name = "centerMarkC";
            this.centerMarkC.Size = new System.Drawing.Size(13, 13);
            this.centerMarkC.TabIndex = 7;
            this.centerMarkC.Text = "+";
            this.centerMarkC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.centerMarkC.Visible = false;
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(448, 392);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(485, 72);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "33 декабря 3333";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventsTable
            // 
            this.eventsTable.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.eventsTable.AutoScroll = true;
            this.eventsTable.BackColor = System.Drawing.Color.Transparent;
            this.eventsTable.ColumnCount = 1;
            this.eventsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventsTable.Controls.Add(this.checkboxWithId3, 0, 2);
            this.eventsTable.Controls.Add(this.checkboxWithId2, 0, 1);
            this.eventsTable.Controls.Add(this.checkboxWithId1, 0, 0);
            this.eventsTable.Location = new System.Drawing.Point(464, 488);
            this.eventsTable.Name = "eventsTable";
            this.eventsTable.RowCount = 3;
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.Size = new System.Drawing.Size(488, 160);
            this.eventsTable.TabIndex = 5;
            this.eventsTable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.eventsTable_Scroll);
            // 
            // checkboxWithId3
            // 
            this.checkboxWithId3.AutoSize = true;
            this.checkboxWithId3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId3.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId3.CheckBoxChecked = false;
            this.checkboxWithId3.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId3.CheckBoxText = "checkBox1";
            this.checkboxWithId3.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId3.Location = new System.Drawing.Point(3, 91);
            this.checkboxWithId3.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId3.Name = "checkboxWithId3";
            this.checkboxWithId3.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId3.TabIndex = 10;
            // 
            // checkboxWithId2
            // 
            this.checkboxWithId2.AutoSize = true;
            this.checkboxWithId2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId2.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId2.CheckBoxChecked = false;
            this.checkboxWithId2.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId2.CheckBoxText = "checkBox1";
            this.checkboxWithId2.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId2.Location = new System.Drawing.Point(3, 47);
            this.checkboxWithId2.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId2.Name = "checkboxWithId2";
            this.checkboxWithId2.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId2.TabIndex = 10;
            // 
            // checkboxWithId1
            // 
            this.checkboxWithId1.AutoSize = true;
            this.checkboxWithId1.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkboxWithId1.CheckBoxChecked = false;
            this.checkboxWithId1.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId1.CheckBoxText = "checkBox1";
            this.checkboxWithId1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId1.Location = new System.Drawing.Point(3, 3);
            this.checkboxWithId1.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId1.Name = "checkboxWithId1";
            this.checkboxWithId1.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId1.TabIndex = 10;
            // 
            // deleteCountDownBtn
            // 
            this.deleteCountDownBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteCountDownBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteCountDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.deleteCountDownBtn.FlatAppearance.BorderSize = 0;
            this.deleteCountDownBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteCountDownBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteCountDownBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCountDownBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteCountDownBtn.ImageIndex = 0;
            this.deleteCountDownBtn.ImageList = this.BtnDeleteImgList;
            this.deleteCountDownBtn.Location = new System.Drawing.Point(968, 672);
            this.deleteCountDownBtn.Name = "deleteCountDownBtn";
            this.deleteCountDownBtn.Size = new System.Drawing.Size(264, 45);
            this.deleteCountDownBtn.TabIndex = 8;
            this.deleteCountDownBtn.Text = "        Удалить дату для отсчета";
            this.deleteCountDownBtn.UseVisualStyleBackColor = false;
            this.deleteCountDownBtn.Click += new System.EventHandler(this.deleteCountDownBtn_Click);
            this.deleteCountDownBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseDown);
            this.deleteCountDownBtn.MouseLeave += new System.EventHandler(this.chooseDateBtn_MouseLeave);
            this.deleteCountDownBtn.MouseHover += new System.EventHandler(this.chooseDateBtn_MouseHover);
            this.deleteCountDownBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseUp);
            // 
            // BtnDeleteImgList
            // 
            this.BtnDeleteImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BtnDeleteImgList.ImageStream")));
            this.BtnDeleteImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.BtnDeleteImgList.Images.SetKeyName(0, "button-back-minus.png");
            this.BtnDeleteImgList.Images.SetKeyName(1, "button-back-minus-howered.png");
            this.BtnDeleteImgList.Images.SetKeyName(2, "button-back-minus-clicked.png");
            // 
            // BtnsImgList
            // 
            this.BtnsImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BtnsImgList.ImageStream")));
            this.BtnsImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.BtnsImgList.Images.SetKeyName(0, "button-back-1.png");
            this.BtnsImgList.Images.SetKeyName(1, "button-back-howered.png");
            this.BtnsImgList.Images.SetKeyName(2, "button-back-clicked.png");
            // 
            // addEventBtn
            // 
            this.addEventBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addEventBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEventBtn.BackColor = System.Drawing.Color.Transparent;
            this.addEventBtn.FlatAppearance.BorderSize = 0;
            this.addEventBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addEventBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEventBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEventBtn.ImageIndex = 0;
            this.addEventBtn.ImageList = this.BtnsImgList;
            this.addEventBtn.Location = new System.Drawing.Point(560, 664);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(344, 61);
            this.addEventBtn.TabIndex = 8;
            this.addEventBtn.Text = "        Добавить событие";
            this.addEventBtn.UseVisualStyleBackColor = false;
            this.addEventBtn.Click += new System.EventHandler(this.addEventBtn_Click);
            this.addEventBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseDown);
            this.addEventBtn.MouseLeave += new System.EventHandler(this.chooseDateBtn_MouseLeave);
            this.addEventBtn.MouseHover += new System.EventHandler(this.chooseDateBtn_MouseHover);
            this.addEventBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseUp);
            // 
            // chooseDateBtn
            // 
            this.chooseDateBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chooseDateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.chooseDateBtn.BackColor = System.Drawing.Color.Transparent;
            this.chooseDateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chooseDateBtn.FlatAppearance.BorderSize = 0;
            this.chooseDateBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chooseDateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chooseDateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseDateBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseDateBtn.ImageIndex = 0;
            this.chooseDateBtn.ImageList = this.BtnsImgList;
            this.chooseDateBtn.Location = new System.Drawing.Point(176, 656);
            this.chooseDateBtn.Name = "chooseDateBtn";
            this.chooseDateBtn.Size = new System.Drawing.Size(360, 72);
            this.chooseDateBtn.TabIndex = 8;
            this.chooseDateBtn.Text = "        Выбрать дату для отсчета";
            this.chooseDateBtn.UseVisualStyleBackColor = true;
            this.chooseDateBtn.Click += new System.EventHandler(this.chooseDateBtn_Click);
            this.chooseDateBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseDown);
            this.chooseDateBtn.MouseLeave += new System.EventHandler(this.chooseDateBtn_MouseLeave);
            this.chooseDateBtn.MouseHover += new System.EventHandler(this.chooseDateBtn_MouseHover);
            this.chooseDateBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.chooseDateBtn_MouseUp);
            // 
            // todayLbl
            // 
            this.todayLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todayLbl.AutoSize = true;
            this.todayLbl.BackColor = System.Drawing.Color.Transparent;
            this.todayLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayLbl.ForeColor = System.Drawing.Color.White;
            this.todayLbl.Location = new System.Drawing.Point(536, 312);
            this.todayLbl.Name = "todayLbl";
            this.todayLbl.Size = new System.Drawing.Size(326, 81);
            this.todayLbl.TabIndex = 0;
            this.todayLbl.Text = "СЕГОДНЯ";
            this.todayLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthLLbl
            // 
            this.monthLLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.monthLLbl.AutoSize = true;
            this.monthLLbl.BackColor = System.Drawing.Color.Transparent;
            this.monthLLbl.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.monthLLbl.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.monthLLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.monthLLbl.LinkColor = System.Drawing.Color.Silver;
            this.monthLLbl.Location = new System.Drawing.Point(352, 336);
            this.monthLLbl.Name = "monthLLbl";
            this.monthLLbl.Size = new System.Drawing.Size(124, 39);
            this.monthLLbl.TabIndex = 11;
            this.monthLLbl.TabStop = true;
            this.monthLLbl.Text = "МЕСЯЦ";
            this.monthLLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.monthLLbl.Click += new System.EventHandler(this.monthLbl_Click);
            // 
            // yearLLbl
            // 
            this.yearLLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yearLLbl.AutoSize = true;
            this.yearLLbl.BackColor = System.Drawing.Color.Transparent;
            this.yearLLbl.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.yearLLbl.Font = new System.Drawing.Font("Bahnschrift", 24F);
            this.yearLLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.yearLLbl.LinkColor = System.Drawing.Color.Silver;
            this.yearLLbl.Location = new System.Drawing.Point(936, 336);
            this.yearLLbl.Name = "yearLLbl";
            this.yearLLbl.Size = new System.Drawing.Size(76, 39);
            this.yearLLbl.TabIndex = 11;
            this.yearLLbl.TabStop = true;
            this.yearLLbl.Text = "ГОД";
            this.yearLLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.yearLLbl.Click += new System.EventHandler(this.monthLbl_Click);
            // 
            // cerpPicBox
            // 
            this.cerpPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cerpPicBox.BackColor = System.Drawing.Color.Transparent;
            this.cerpPicBox.Image = global::CalendarBefore1_1.Properties.Resources.cerp;
            this.cerpPicBox.Location = new System.Drawing.Point(480, 8);
            this.cerpPicBox.Name = "cerpPicBox";
            this.cerpPicBox.Size = new System.Drawing.Size(96, 104);
            this.cerpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cerpPicBox.TabIndex = 12;
            this.cerpPicBox.TabStop = false;
            // 
            // hammerPicBox
            // 
            this.hammerPicBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.hammerPicBox.BackColor = System.Drawing.Color.Transparent;
            this.hammerPicBox.Image = global::CalendarBefore1_1.Properties.Resources.hammer;
            this.hammerPicBox.Location = new System.Drawing.Point(800, 8);
            this.hammerPicBox.Name = "hammerPicBox";
            this.hammerPicBox.Size = new System.Drawing.Size(96, 104);
            this.hammerPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hammerPicBox.TabIndex = 12;
            this.hammerPicBox.TabStop = false;
            // 
            // countDownTable
            // 
            this.countDownTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.countDownTable.AutoScroll = true;
            this.countDownTable.BackColor = System.Drawing.Color.Transparent;
            this.countDownTable.ColumnCount = 1;
            this.countDownTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 696F));
            this.countDownTable.Location = new System.Drawing.Point(344, 136);
            this.countDownTable.Name = "countDownTable";
            this.countDownTable.RowCount = 1;
            this.countDownTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countDownTable.Size = new System.Drawing.Size(696, 160);
            this.countDownTable.TabIndex = 5;
            this.countDownTable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.eventsTable_Scroll);
            // 
            // todayLLbl
            // 
            this.todayLLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.todayLLbl.AutoSize = true;
            this.todayLLbl.BackColor = System.Drawing.Color.Transparent;
            this.todayLLbl.DisabledLinkColor = System.Drawing.Color.DimGray;
            this.todayLLbl.Enabled = false;
            this.todayLLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.todayLLbl.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.todayLLbl.LinkColor = System.Drawing.Color.Silver;
            this.todayLLbl.Location = new System.Drawing.Point(536, 312);
            this.todayLLbl.Name = "todayLLbl";
            this.todayLLbl.Size = new System.Drawing.Size(326, 81);
            this.todayLLbl.TabIndex = 11;
            this.todayLLbl.TabStop = true;
            this.todayLLbl.Text = "СЕГОДНЯ";
            this.todayLLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.todayLLbl.Visible = false;
            this.todayLLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.todayLLbl_LinkClicked);
            // 
            // countDownControl1
            // 
            this.countDownControl1.AutoSize = true;
            this.countDownControl1.BackColor = System.Drawing.Color.Transparent;
            this.countDownControl1.CountDownText = "countDown1";
            this.countDownControl1.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.countDownControl1.Location = new System.Drawing.Point(1112, 472);
            this.countDownControl1.Name = "countDownControl1";
            this.countDownControl1.Size = new System.Drawing.Size(215, 48);
            this.countDownControl1.TabIndex = 13;
            this.countDownControl1.Visible = false;
            // 
            // etaloneEventChBox
            // 
            this.etaloneEventChBox.AutoSize = true;
            this.etaloneEventChBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.etaloneEventChBox.BackColor = System.Drawing.Color.Transparent;
            this.etaloneEventChBox.CheckBoxChecked = false;
            this.etaloneEventChBox.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etaloneEventChBox.CheckBoxText = "checkBox1";
            this.etaloneEventChBox.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.etaloneEventChBox.Location = new System.Drawing.Point(1128, 536);
            this.etaloneEventChBox.MaximumSize = new System.Drawing.Size(469, 0);
            this.etaloneEventChBox.Name = "etaloneEventChBox";
            this.etaloneEventChBox.Size = new System.Drawing.Size(163, 38);
            this.etaloneEventChBox.TabIndex = 10;
            this.etaloneEventChBox.Visible = false;
            // 
            // checkboxWithId7
            // 
            this.checkboxWithId7.AutoSize = true;
            this.checkboxWithId7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId7.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId7.CheckBoxChecked = false;
            this.checkboxWithId7.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId7.CheckBoxText = "checkBox1";
            this.checkboxWithId7.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId7.Location = new System.Drawing.Point(3, 91);
            this.checkboxWithId7.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId7.Name = "checkboxWithId7";
            this.checkboxWithId7.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId7.TabIndex = 10;
            // 
            // checkboxWithId8
            // 
            this.checkboxWithId8.AutoSize = true;
            this.checkboxWithId8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId8.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId8.CheckBoxChecked = false;
            this.checkboxWithId8.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId8.CheckBoxText = "checkBox1";
            this.checkboxWithId8.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId8.Location = new System.Drawing.Point(3, 47);
            this.checkboxWithId8.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId8.Name = "checkboxWithId8";
            this.checkboxWithId8.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId8.TabIndex = 10;
            // 
            // checkboxWithId9
            // 
            this.checkboxWithId9.AutoSize = true;
            this.checkboxWithId9.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkboxWithId9.CheckBoxChecked = false;
            this.checkboxWithId9.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId9.CheckBoxText = "checkBox1";
            this.checkboxWithId9.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId9.Location = new System.Drawing.Point(3, 3);
            this.checkboxWithId9.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId9.Name = "checkboxWithId9";
            this.checkboxWithId9.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId9.TabIndex = 10;
            // 
            // checkboxWithId4
            // 
            this.checkboxWithId4.AutoSize = true;
            this.checkboxWithId4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId4.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId4.CheckBoxChecked = false;
            this.checkboxWithId4.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId4.CheckBoxText = "checkBox1";
            this.checkboxWithId4.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId4.Location = new System.Drawing.Point(3, 91);
            this.checkboxWithId4.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId4.Name = "checkboxWithId4";
            this.checkboxWithId4.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId4.TabIndex = 10;
            // 
            // checkboxWithId5
            // 
            this.checkboxWithId5.AutoSize = true;
            this.checkboxWithId5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.checkboxWithId5.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId5.CheckBoxChecked = false;
            this.checkboxWithId5.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId5.CheckBoxText = "checkBox1";
            this.checkboxWithId5.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId5.Location = new System.Drawing.Point(3, 47);
            this.checkboxWithId5.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId5.Name = "checkboxWithId5";
            this.checkboxWithId5.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId5.TabIndex = 10;
            // 
            // checkboxWithId6
            // 
            this.checkboxWithId6.AutoSize = true;
            this.checkboxWithId6.BackColor = System.Drawing.Color.Transparent;
            this.checkboxWithId6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkboxWithId6.CheckBoxChecked = false;
            this.checkboxWithId6.CheckBoxFontStyle = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkboxWithId6.CheckBoxText = "checkBox1";
            this.checkboxWithId6.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.checkboxWithId6.Location = new System.Drawing.Point(3, 3);
            this.checkboxWithId6.MaximumSize = new System.Drawing.Size(469, 0);
            this.checkboxWithId6.Name = "checkboxWithId6";
            this.checkboxWithId6.Size = new System.Drawing.Size(211, 38);
            this.checkboxWithId6.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::CalendarBefore1_1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.countDownControl1);
            this.Controls.Add(this.hammerPicBox);
            this.Controls.Add(this.cerpPicBox);
            this.Controls.Add(this.yearLLbl);
            this.Controls.Add(this.monthLLbl);
            this.Controls.Add(this.etaloneEventChBox);
            this.Controls.Add(this.chooseDateBtn);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.deleteCountDownBtn);
            this.Controls.Add(this.centerMarkH2);
            this.Controls.Add(this.centerMarkH1);
            this.Controls.Add(this.centerMarkC);
            this.Controls.Add(this.centerMarkV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.centerMarkV1);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.currentTimeLbl);
            this.Controls.Add(this.countDownTable);
            this.Controls.Add(this.eventsTable);
            this.Controls.Add(this.todayLLbl);
            this.Controls.Add(this.todayLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Календарь до";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.eventsTable.ResumeLayout(false);
            this.eventsTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cerpPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hammerPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLbl;
        private System.Windows.Forms.Timer minuteTimer;
        private System.Windows.Forms.Label centerMarkV1;
        private System.Windows.Forms.Label centerMarkV2;
        private System.Windows.Forms.Label centerMarkH1;
        private System.Windows.Forms.Label centerMarkH2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label centerMarkC;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.TableLayoutPanel eventsTable;
        private System.Windows.Forms.Button deleteCountDownBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button chooseDateBtn;
        private System.Windows.Forms.Label todayLbl;
        private CheckboxWithId etaloneEventChBox;
        private CheckboxWithId checkboxWithId3;
        private CheckboxWithId checkboxWithId2;
        private CheckboxWithId checkboxWithId1;
        private System.Windows.Forms.LinkLabel monthLLbl;
        private System.Windows.Forms.LinkLabel yearLLbl;
        private System.Windows.Forms.ImageList BtnsImgList;
        private System.Windows.Forms.PictureBox cerpPicBox;
        private System.Windows.Forms.PictureBox hammerPicBox;
        private CheckboxWithId checkboxWithId4;
        private CheckboxWithId checkboxWithId5;
        private CheckboxWithId checkboxWithId6;
        private CheckboxWithId checkboxWithId7;
        private CheckboxWithId checkboxWithId8;
        private CheckboxWithId checkboxWithId9;
        private System.Windows.Forms.TableLayoutPanel countDownTable;
        private CountDownControl countDownControl1;
        private System.Windows.Forms.LinkLabel todayLLbl;
        private System.Windows.Forms.ImageList BtnDeleteImgList;
    }
}