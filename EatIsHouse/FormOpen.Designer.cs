namespace EatIsHouse
{
    partial class FormOpen
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelOpen = new System.Windows.Forms.Label();
            this.buttonOpenCal = new System.Windows.Forms.Button();
            this.buttonOpenExit = new System.Windows.Forms.Button();
            this.pictureBoxOpen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOpen
            // 
            this.labelOpen.AutoSize = true;
            this.labelOpen.Font = new System.Drawing.Font("Sitka Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpen.Location = new System.Drawing.Point(60, 145);
            this.labelOpen.Name = "labelOpen";
            this.labelOpen.Size = new System.Drawing.Size(399, 90);
            this.labelOpen.TabIndex = 0;
            this.labelOpen.Text = "Добро пожаловать\r\nв приложение по расчёту стоимости \r\nпокупки в кафе EatIsHouse";
            this.labelOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonOpenCal
            // 
            this.buttonOpenCal.Location = new System.Drawing.Point(115, 260);
            this.buttonOpenCal.Name = "buttonOpenCal";
            this.buttonOpenCal.Size = new System.Drawing.Size(139, 23);
            this.buttonOpenCal.TabIndex = 2;
            this.buttonOpenCal.Text = "Рассчитать";
            this.buttonOpenCal.UseVisualStyleBackColor = true;
            this.buttonOpenCal.Click += new System.EventHandler(this.buttonOpenCal_Click);
            // 
            // buttonOpenExit
            // 
            this.buttonOpenExit.Location = new System.Drawing.Point(260, 260);
            this.buttonOpenExit.Name = "buttonOpenExit";
            this.buttonOpenExit.Size = new System.Drawing.Size(139, 23);
            this.buttonOpenExit.TabIndex = 3;
            this.buttonOpenExit.Text = "Выход";
            this.buttonOpenExit.UseVisualStyleBackColor = true;
            this.buttonOpenExit.Click += new System.EventHandler(this.buttonOpenExit_Click);
            // 
            // pictureBoxOpen
            // 
            this.pictureBoxOpen.Image = global::EatIsHouse.Properties.Resources.eatishouse2;
            this.pictureBoxOpen.Location = new System.Drawing.Point(80, 10);
            this.pictureBoxOpen.Name = "pictureBoxOpen";
            this.pictureBoxOpen.Size = new System.Drawing.Size(360, 120);
            this.pictureBoxOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOpen.TabIndex = 1;
            this.pictureBoxOpen.TabStop = false;
            // 
            // FormOpen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.buttonOpenExit);
            this.Controls.Add(this.buttonOpenCal);
            this.Controls.Add(this.pictureBoxOpen);
            this.Controls.Add(this.labelOpen);
            this.MaximumSize = new System.Drawing.Size(550, 350);
            this.MinimumSize = new System.Drawing.Size(550, 350);
            this.Name = "FormOpen";
            this.Text = "EatIsHouse";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOpen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOpen;
        private System.Windows.Forms.PictureBox pictureBoxOpen;
        private System.Windows.Forms.Button buttonOpenCal;
        private System.Windows.Forms.Button buttonOpenExit;
    }
}

