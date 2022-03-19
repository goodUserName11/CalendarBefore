namespace CalendarBefore1_1
{
    partial class AddEventDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEventDialog));
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BtnsImgList = new System.Windows.Forms.ImageList(this.components);
            this.cancelBtn = new System.Windows.Forms.Button();
            this.textTxt = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.textLbl = new System.Windows.Forms.Label();
            this.maxTextLbl = new System.Windows.Forms.Label();
            this.maxCounterLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarForeColor = System.Drawing.Color.White;
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker.Location = new System.Drawing.Point(16, 40);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(240, 30);
            this.dateTimePicker.TabIndex = 0;
            // 
            // BtnsImgList
            // 
            this.BtnsImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BtnsImgList.ImageStream")));
            this.BtnsImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.BtnsImgList.Images.SetKeyName(0, "event-back-red.png");
            this.BtnsImgList.Images.SetKeyName(1, "event-back-grey.png");
            this.BtnsImgList.Images.SetKeyName(2, "event-back-darkred.png");
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.ImageIndex = 0;
            this.cancelBtn.ImageList = this.BtnsImgList;
            this.cancelBtn.Location = new System.Drawing.Point(176, 176);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(80, 32);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            this.cancelBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseDown);
            this.cancelBtn.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            this.cancelBtn.MouseLeave += new System.EventHandler(this.addBtn_MouseLeave);
            this.cancelBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseUp);
            // 
            // textTxt
            // 
            this.textTxt.AllowDrop = true;
            this.textTxt.Location = new System.Drawing.Point(16, 120);
            this.textTxt.Name = "textTxt";
            this.textTxt.Size = new System.Drawing.Size(240, 20);
            this.textTxt.TabIndex = 2;
            this.textTxt.TextChanged += new System.EventHandler(this.textTxt_TextChanged);
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dateLbl.Location = new System.Drawing.Point(16, 16);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(53, 25);
            this.dateLbl.TabIndex = 3;
            this.dateLbl.Text = "Дата";
            // 
            // textLbl
            // 
            this.textLbl.AutoSize = true;
            this.textLbl.BackColor = System.Drawing.Color.Transparent;
            this.textLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLbl.ForeColor = System.Drawing.Color.White;
            this.textLbl.Location = new System.Drawing.Point(16, 96);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(56, 25);
            this.textLbl.TabIndex = 3;
            this.textLbl.Text = "Текст";
            // 
            // maxTextLbl
            // 
            this.maxTextLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxTextLbl.AutoSize = true;
            this.maxTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxTextLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxTextLbl.ForeColor = System.Drawing.Color.White;
            this.maxTextLbl.Location = new System.Drawing.Point(216, 96);
            this.maxTextLbl.Name = "maxTextLbl";
            this.maxTextLbl.Size = new System.Drawing.Size(39, 25);
            this.maxTextLbl.TabIndex = 3;
            this.maxTextLbl.Text = "/30";
            this.maxTextLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxCounterLbl
            // 
            this.maxCounterLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCounterLbl.BackColor = System.Drawing.Color.Transparent;
            this.maxCounterLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxCounterLbl.ForeColor = System.Drawing.Color.White;
            this.maxCounterLbl.Location = new System.Drawing.Point(184, 96);
            this.maxCounterLbl.Name = "maxCounterLbl";
            this.maxCounterLbl.Size = new System.Drawing.Size(32, 25);
            this.maxCounterLbl.TabIndex = 3;
            this.maxCounterLbl.Text = "0";
            this.maxCounterLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.BtnsImgList;
            this.button1.Location = new System.Drawing.Point(16, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.addBtn_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.addBtn_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseUp);
            // 
            // AddEventDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalendarBefore1_1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(268, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maxCounterLbl);
            this.Controls.Add(this.maxTextLbl);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.textTxt);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.dateTimePicker);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AddEventDialog";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Добавить событие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox textTxt;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label textLbl;
        private System.Windows.Forms.ImageList BtnsImgList;
        private System.Windows.Forms.Label maxTextLbl;
        private System.Windows.Forms.Label maxCounterLbl;
        private System.Windows.Forms.Button button1;
    }
}