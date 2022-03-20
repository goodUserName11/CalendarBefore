namespace CalendarBefore1_1
{
    partial class CheckboxWithId
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckboxWithId));
            this.circlePicBox = new System.Windows.Forms.PictureBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.deleteImgList = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.circlePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // circlePicBox
            // 
            this.circlePicBox.Image = global::CalendarBefore1_1.Properties.Resources.date_circle_white;
            this.circlePicBox.Location = new System.Drawing.Point(0, 0);
            this.circlePicBox.Name = "circlePicBox";
            this.circlePicBox.Size = new System.Drawing.Size(32, 32);
            this.circlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circlePicBox.TabIndex = 4;
            this.circlePicBox.TabStop = false;
            // 
            // checkBox
            // 
            this.checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.Transparent;
            this.checkBox.BackgroundImage = global::CalendarBefore1_1.Properties.Resources.event_back_1;
            this.checkBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkBox.FlatAppearance.BorderSize = 0;
            this.checkBox.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.checkBox.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBox.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.checkBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox.Location = new System.Drawing.Point(40, 0);
            this.checkBox.MaximumSize = new System.Drawing.Size(445, 0);
            this.checkBox.MinimumSize = new System.Drawing.Size(120, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(120, 35);
            this.checkBox.TabIndex = 3;
            this.checkBox.Text = "checkBox1";
            this.checkBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteBtn.ImageIndex = 0;
            this.deleteBtn.ImageList = this.deleteImgList;
            this.deleteBtn.Location = new System.Drawing.Point(0, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(40, 38);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.deleteBtn_MouseDown);
            this.deleteBtn.MouseEnter += new System.EventHandler(this.deleteBtn_MouseEnter);
            this.deleteBtn.MouseLeave += new System.EventHandler(this.deleteBtn_MouseLeave);
            this.deleteBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.deleteBtn_MouseUp);
            // 
            // deleteImgList
            // 
            this.deleteImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("deleteImgList.ImageStream")));
            this.deleteImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.deleteImgList.Images.SetKeyName(0, "date-circle-minus.png");
            this.deleteImgList.Images.SetKeyName(1, "date-circle-minus-grey.png");
            this.deleteImgList.Images.SetKeyName(2, "date-circle-minus-white.png");
            // 
            // CheckboxWithId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.circlePicBox);
            this.Controls.Add(this.checkBox);
            this.MaximumSize = new System.Drawing.Size(469, 0);
            this.Name = "CheckboxWithId";
            this.Size = new System.Drawing.Size(211, 38);
            ((System.ComponentModel.ISupportInitialize)(this.circlePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.PictureBox circlePicBox;
        internal System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.ImageList deleteImgList;
    }
}
