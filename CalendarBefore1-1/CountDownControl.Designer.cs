namespace CalendarBefore1_1
{
    partial class CountDownControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CountDownControl));
            this.cirlcesImgList = new System.Windows.Forms.ImageList(this.components);
            this.textImgList = new System.Windows.Forms.ImageList(this.components);
            this.countDownTextBtn = new System.Windows.Forms.Button();
            this.rightCircleBtn = new System.Windows.Forms.Button();
            this.leftCircleBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cirlcesImgList
            // 
            this.cirlcesImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cirlcesImgList.ImageStream")));
            this.cirlcesImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.cirlcesImgList.Images.SetKeyName(0, "date-circle-white.png");
            this.cirlcesImgList.Images.SetKeyName(1, "date-circle-grey.png");
            this.cirlcesImgList.Images.SetKeyName(2, "date-circle.png");
            // 
            // textImgList
            // 
            this.textImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("textImgList.ImageStream")));
            this.textImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.textImgList.Images.SetKeyName(0, "event-back-1.png");
            // 
            // countDownTextBtn
            // 
            this.countDownTextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.countDownTextBtn.AutoSize = true;
            this.countDownTextBtn.BackgroundImage = global::CalendarBefore1_1.Properties.Resources.event_back_1;
            this.countDownTextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.countDownTextBtn.FlatAppearance.BorderSize = 0;
            this.countDownTextBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.countDownTextBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.countDownTextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countDownTextBtn.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countDownTextBtn.Location = new System.Drawing.Point(40, 0);
            this.countDownTextBtn.Name = "countDownTextBtn";
            this.countDownTextBtn.Size = new System.Drawing.Size(135, 39);
            this.countDownTextBtn.TabIndex = 2;
            this.countDownTextBtn.Text = "countDown1";
            this.countDownTextBtn.UseVisualStyleBackColor = true;
            // 
            // rightCircleBtn
            // 
            this.rightCircleBtn.BackColor = System.Drawing.Color.Transparent;
            this.rightCircleBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightCircleBtn.FlatAppearance.BorderSize = 0;
            this.rightCircleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.rightCircleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.rightCircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rightCircleBtn.ImageIndex = 0;
            this.rightCircleBtn.ImageList = this.cirlcesImgList;
            this.rightCircleBtn.Location = new System.Drawing.Point(177, 0);
            this.rightCircleBtn.Name = "rightCircleBtn";
            this.rightCircleBtn.Size = new System.Drawing.Size(40, 42);
            this.rightCircleBtn.TabIndex = 1;
            this.rightCircleBtn.UseVisualStyleBackColor = false;
            // 
            // leftCircleBtn
            // 
            this.leftCircleBtn.BackColor = System.Drawing.Color.Transparent;
            this.leftCircleBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftCircleBtn.FlatAppearance.BorderSize = 0;
            this.leftCircleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.leftCircleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.leftCircleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leftCircleBtn.ImageIndex = 0;
            this.leftCircleBtn.ImageList = this.cirlcesImgList;
            this.leftCircleBtn.Location = new System.Drawing.Point(0, 0);
            this.leftCircleBtn.Name = "leftCircleBtn";
            this.leftCircleBtn.Size = new System.Drawing.Size(40, 42);
            this.leftCircleBtn.TabIndex = 1;
            this.leftCircleBtn.UseVisualStyleBackColor = false;
            // 
            // CountDownControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.countDownTextBtn);
            this.Controls.Add(this.rightCircleBtn);
            this.Controls.Add(this.leftCircleBtn);
            this.Name = "CountDownControl";
            this.Size = new System.Drawing.Size(217, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList cirlcesImgList;
        private System.Windows.Forms.Button leftCircleBtn;
        private System.Windows.Forms.Button rightCircleBtn;
        private System.Windows.Forms.ImageList textImgList;
        internal System.Windows.Forms.Button countDownTextBtn;
    }
}
