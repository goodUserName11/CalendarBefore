namespace CalendarBefore1_1
{
    partial class CountDownDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDownDeleteForm));
            this.countDownInfoTable = new System.Windows.Forms.TableLayoutPanel();
            this.closeBtn = new System.Windows.Forms.Button();
            this.BtnsImgList = new System.Windows.Forms.ImageList(this.components);
            this.countDownInfoControl1 = new CalendarBefore1_1.CountDownInfoControl();
            this.countDownInfoTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // countDownInfoTable
            // 
            this.countDownInfoTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countDownInfoTable.AutoScroll = true;
            this.countDownInfoTable.BackColor = System.Drawing.Color.Transparent;
            this.countDownInfoTable.ColumnCount = 1;
            this.countDownInfoTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countDownInfoTable.Controls.Add(this.countDownInfoControl1, 0, 0);
            this.countDownInfoTable.Location = new System.Drawing.Point(8, 8);
            this.countDownInfoTable.Name = "countDownInfoTable";
            this.countDownInfoTable.RowCount = 1;
            this.countDownInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.countDownInfoTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 311F));
            this.countDownInfoTable.Size = new System.Drawing.Size(416, 312);
            this.countDownInfoTable.TabIndex = 2;
            this.countDownInfoTable.Scroll += new System.Windows.Forms.ScrollEventHandler(this.eventsTable_Scroll);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.ImageIndex = 0;
            this.closeBtn.ImageList = this.BtnsImgList;
            this.closeBtn.Location = new System.Drawing.Point(176, 336);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(88, 32);
            this.closeBtn.TabIndex = 7;
            this.closeBtn.Text = "Закрыть";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseDown);
            this.closeBtn.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.addBtn_MouseLeave);
            this.closeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseUp);
            // 
            // BtnsImgList
            // 
            this.BtnsImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("BtnsImgList.ImageStream")));
            this.BtnsImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.BtnsImgList.Images.SetKeyName(0, "event-back-red.png");
            this.BtnsImgList.Images.SetKeyName(1, "event-back-grey.png");
            this.BtnsImgList.Images.SetKeyName(2, "event-back-darkred.png");
            // 
            // countDownInfoControl1
            // 
            this.countDownInfoControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.countDownInfoControl1.BackColor = System.Drawing.Color.Transparent;
            this.countDownInfoControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countDownInfoControl1.DateLblText = "Дата отсчета";
            this.countDownInfoControl1.DeleteLLblText = "";
            this.countDownInfoControl1.Location = new System.Drawing.Point(3, 3);
            this.countDownInfoControl1.Name = "countDownInfoControl1";
            this.countDownInfoControl1.Size = new System.Drawing.Size(386, 42);
            this.countDownInfoControl1.TabIndex = 1;
            this.countDownInfoControl1.TextLblFont = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDownInfoControl1.TextLblText = "Текст отчсчета";
            // 
            // CountDownDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalendarBefore1_1.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 382);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.countDownInfoTable);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CountDownDeleteForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Удалить дату отсчета";
            this.Load += new System.EventHandler(this.CountDownDeleteForm_Load);
            this.countDownInfoTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CountDownInfoControl countDownInfoControl1;
        private System.Windows.Forms.TableLayoutPanel countDownInfoTable;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ImageList BtnsImgList;
    }
}