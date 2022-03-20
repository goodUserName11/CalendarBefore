namespace CalendarBefore1_1
{
    partial class CountDownInfoControl
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
            this.dateLbl = new System.Windows.Forms.Label();
            this.textLbl = new System.Windows.Forms.Label();
            this.deleteLLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // dateLbl
            // 
            this.dateLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(200, 0);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(120, 45);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "ЩЩ.ЩЩ.ЩЩЩЩ";
            this.dateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textLbl
            // 
            this.textLbl.BackColor = System.Drawing.Color.Transparent;
            this.textLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.textLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLbl.ForeColor = System.Drawing.Color.White;
            this.textLbl.Location = new System.Drawing.Point(0, 0);
            this.textLbl.Name = "textLbl";
            this.textLbl.Size = new System.Drawing.Size(200, 42);
            this.textLbl.TabIndex = 0;
            this.textLbl.Text = "ЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩЩ";
            this.textLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deleteLLbl
            // 
            this.deleteLLbl.ActiveLinkColor = System.Drawing.Color.Blue;
            this.deleteLLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteLLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deleteLLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteLLbl.LinkColor = System.Drawing.Color.Red;
            this.deleteLLbl.Location = new System.Drawing.Point(320, 0);
            this.deleteLLbl.Name = "deleteLLbl";
            this.deleteLLbl.Size = new System.Drawing.Size(75, 42);
            this.deleteLLbl.TabIndex = 1;
            this.deleteLLbl.TabStop = true;
            this.deleteLLbl.Text = "Удалить";
            this.deleteLLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountDownInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.deleteLLbl);
            this.Controls.Add(this.textLbl);
            this.Controls.Add(this.dateLbl);
            this.Name = "CountDownInfoControl";
            this.Size = new System.Drawing.Size(389, 42);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label dateLbl;
        internal System.Windows.Forms.Label textLbl;
        internal System.Windows.Forms.LinkLabel deleteLLbl;
    }
}
