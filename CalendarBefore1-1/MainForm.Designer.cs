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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.minuteTimer = new System.Windows.Forms.Timer(this.components);
            this.etaloneEventChBox = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.centerMarkV1 = new System.Windows.Forms.Label();
            this.centerMarkV2 = new System.Windows.Forms.Label();
            this.centerMarkH1 = new System.Windows.Forms.Label();
            this.centerMarkH2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.centerMarkC = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.eventsTable = new System.Windows.Forms.TableLayoutPanel();
            this.deleteEventBtn = new System.Windows.Forms.Button();
            this.addEventBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2.SuspendLayout();
            this.eventsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentTimeLbl
            // 
            this.currentTimeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.currentTimeLbl.AutoSize = true;
            this.currentTimeLbl.BackColor = System.Drawing.Color.Transparent;
            this.currentTimeLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentTimeLbl.ForeColor = System.Drawing.Color.White;
            this.currentTimeLbl.Location = new System.Drawing.Point(616, 32);
            this.currentTimeLbl.Name = "currentTimeLbl";
            this.currentTimeLbl.Size = new System.Drawing.Size(158, 72);
            this.currentTimeLbl.TabIndex = 0;
            this.currentTimeLbl.Text = "10:00";
            this.currentTimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(992, 496);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(340, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // minuteTimer
            // 
            this.minuteTimer.Interval = 10000;
            this.minuteTimer.Tick += new System.EventHandler(this.minuteTimer_Tick);
            // 
            // etaloneEventChBox
            // 
            this.etaloneEventChBox.AutoSize = true;
            this.etaloneEventChBox.BackColor = System.Drawing.Color.Transparent;
            this.etaloneEventChBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etaloneEventChBox.Location = new System.Drawing.Point(968, 544);
            this.etaloneEventChBox.Name = "etaloneEventChBox";
            this.etaloneEventChBox.Size = new System.Drawing.Size(103, 29);
            this.etaloneEventChBox.TabIndex = 2;
            this.etaloneEventChBox.Text = "checkBox1";
            this.etaloneEventChBox.UseVisualStyleBackColor = false;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(224, 472);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 3;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoScroll = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.checkBox7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.checkBox8, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.checkBox9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.checkBox10, 0, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(448, 848);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 184);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(3, 26);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(80, 17);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "checkBox1";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(3, 49);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.Text = "checkBox1";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(3, 72);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(80, 17);
            this.checkBox9.TabIndex = 2;
            this.checkBox9.Text = "checkBox1";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(3, 95);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(80, 17);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "checkBox1";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Bahnschrift SemiBold", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(448, 400);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(485, 72);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "33 декабря 3333";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.BackColor = System.Drawing.Color.Transparent;
            this.checkBox11.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox11.Location = new System.Drawing.Point(3, 73);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(103, 29);
            this.checkBox11.TabIndex = 2;
            this.checkBox11.Text = "checkBox1";
            this.checkBox11.UseVisualStyleBackColor = false;
            this.checkBox11.Visible = false;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.BackColor = System.Drawing.Color.Transparent;
            this.checkBox12.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox12.Location = new System.Drawing.Point(3, 38);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(103, 29);
            this.checkBox12.TabIndex = 2;
            this.checkBox12.Text = "checkBox1";
            this.checkBox12.UseVisualStyleBackColor = false;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.BackColor = System.Drawing.Color.Transparent;
            this.checkBox13.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox13.Location = new System.Drawing.Point(3, 3);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(103, 29);
            this.checkBox13.TabIndex = 2;
            this.checkBox13.Text = "checkBox1";
            this.checkBox13.UseVisualStyleBackColor = false;
            // 
            // eventsTable
            // 
            this.eventsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsTable.AutoScroll = true;
            this.eventsTable.BackColor = System.Drawing.Color.Transparent;
            this.eventsTable.ColumnCount = 1;
            this.eventsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.eventsTable.Controls.Add(this.checkBox13, 0, 0);
            this.eventsTable.Controls.Add(this.checkBox12, 0, 1);
            this.eventsTable.Controls.Add(this.checkBox11, 0, 2);
            this.eventsTable.Location = new System.Drawing.Point(448, 488);
            this.eventsTable.Name = "eventsTable";
            this.eventsTable.RowCount = 3;
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.eventsTable.Size = new System.Drawing.Size(472, 160);
            this.eventsTable.TabIndex = 5;
            // 
            // deleteEventBtn
            // 
            this.deleteEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteEventBtn.AutoSize = true;
            this.deleteEventBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteEventBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteEventBtn.Location = new System.Drawing.Point(976, 664);
            this.deleteEventBtn.Name = "deleteEventBtn";
            this.deleteEventBtn.Size = new System.Drawing.Size(232, 37);
            this.deleteEventBtn.TabIndex = 8;
            this.deleteEventBtn.Text = "—  Удалить дату для отсчета";
            this.deleteEventBtn.UseVisualStyleBackColor = true;
            // 
            // addEventBtn
            // 
            this.addEventBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addEventBtn.AutoSize = true;
            this.addEventBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addEventBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEventBtn.Location = new System.Drawing.Point(576, 664);
            this.addEventBtn.Name = "addEventBtn";
            this.addEventBtn.Size = new System.Drawing.Size(233, 37);
            this.addEventBtn.TabIndex = 8;
            this.addEventBtn.Text = "+  Добавить дату для отсчета";
            this.addEventBtn.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(184, 664);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "+  Удалить дату для отсчета";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "СЕГОДНЯ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(928, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "ГОД";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(360, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 39);
            this.label4.TabIndex = 9;
            this.label4.Text = "МЕСЯЦ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.addEventBtn);
            this.Controls.Add(this.deleteEventBtn);
            this.Controls.Add(this.centerMarkH2);
            this.Controls.Add(this.centerMarkH1);
            this.Controls.Add(this.centerMarkC);
            this.Controls.Add(this.centerMarkV2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.centerMarkV1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.currentTimeLbl);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.etaloneEventChBox);
            this.Controls.Add(this.eventsTable);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Календарь до";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.eventsTable.ResumeLayout(false);
            this.eventsTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label currentTimeLbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Timer minuteTimer;
        private System.Windows.Forms.CheckBox etaloneEventChBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label centerMarkV1;
        private System.Windows.Forms.Label centerMarkV2;
        private System.Windows.Forms.Label centerMarkH1;
        private System.Windows.Forms.Label centerMarkH2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label centerMarkC;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.TableLayoutPanel eventsTable;
        private System.Windows.Forms.Button deleteEventBtn;
        private System.Windows.Forms.Button addEventBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}