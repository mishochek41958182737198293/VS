namespace EatIsHouse
{
    partial class FormBonusProgram
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
            this.labelBonusChoose = new System.Windows.Forms.Label();
            this.buttonBonusCal = new System.Windows.Forms.Button();
            this.buttonBonusCancel = new System.Windows.Forms.Button();
            this.radioButtonBonus1 = new System.Windows.Forms.RadioButton();
            this.radioButtonBonus2 = new System.Windows.Forms.RadioButton();
            this.radioButtonBonus3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBonusExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBonusChoose
            // 
            this.labelBonusChoose.AutoSize = true;
            this.labelBonusChoose.Font = new System.Drawing.Font("Sitka Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBonusChoose.Location = new System.Drawing.Point(0, 45);
            this.labelBonusChoose.Name = "labelBonusChoose";
            this.labelBonusChoose.Size = new System.Drawing.Size(358, 56);
            this.labelBonusChoose.TabIndex = 1;
            this.labelBonusChoose.Text = "Пожалуйста, \r\nвыберите вашу бонусную программу";
            // 
            // buttonBonusCal
            // 
            this.buttonBonusCal.Location = new System.Drawing.Point(60, 213);
            this.buttonBonusCal.Name = "buttonBonusCal";
            this.buttonBonusCal.Size = new System.Drawing.Size(89, 23);
            this.buttonBonusCal.TabIndex = 2;
            this.buttonBonusCal.Text = "Рассчитать";
            this.buttonBonusCal.UseVisualStyleBackColor = true;
            this.buttonBonusCal.Click += new System.EventHandler(this.buttonBonusCal_Click);
            // 
            // buttonBonusCancel
            // 
            this.buttonBonusCancel.Location = new System.Drawing.Point(155, 213);
            this.buttonBonusCancel.Name = "buttonBonusCancel";
            this.buttonBonusCancel.Size = new System.Drawing.Size(89, 23);
            this.buttonBonusCancel.TabIndex = 3;
            this.buttonBonusCancel.Text = "Отменить";
            this.buttonBonusCancel.UseVisualStyleBackColor = true;
            this.buttonBonusCancel.Click += new System.EventHandler(this.buttonBonusCancel_Click);
            // 
            // radioButtonBonus1
            // 
            this.radioButtonBonus1.AutoSize = true;
            this.radioButtonBonus1.Checked = true;
            this.radioButtonBonus1.Location = new System.Drawing.Point(27, 118);
            this.radioButtonBonus1.Name = "radioButtonBonus1";
            this.radioButtonBonus1.Size = new System.Drawing.Size(156, 17);
            this.radioButtonBonus1.TabIndex = 4;
            this.radioButtonBonus1.TabStop = true;
            this.radioButtonBonus1.Text = "Без бонусной программы";
            this.radioButtonBonus1.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonus2
            // 
            this.radioButtonBonus2.AutoSize = true;
            this.radioButtonBonus2.Location = new System.Drawing.Point(27, 141);
            this.radioButtonBonus2.Name = "radioButtonBonus2";
            this.radioButtonBonus2.Size = new System.Drawing.Size(213, 17);
            this.radioButtonBonus2.TabIndex = 5;
            this.radioButtonBonus2.TabStop = true;
            this.radioButtonBonus2.Text = "Базовая (скидка на любой заказ 4%)";
            this.radioButtonBonus2.UseVisualStyleBackColor = true;
            // 
            // radioButtonBonus3
            // 
            this.radioButtonBonus3.AutoSize = true;
            this.radioButtonBonus3.Location = new System.Drawing.Point(27, 164);
            this.radioButtonBonus3.Name = "radioButtonBonus3";
            this.radioButtonBonus3.Size = new System.Drawing.Size(246, 17);
            this.radioButtonBonus3.TabIndex = 6;
            this.radioButtonBonus3.TabStop = true;
            this.radioButtonBonus3.Text = "Премиальная (скидка на любой заказ 15%)";
            this.radioButtonBonus3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // buttonBonusExit
            // 
            this.buttonBonusExit.Location = new System.Drawing.Point(250, 213);
            this.buttonBonusExit.Name = "buttonBonusExit";
            this.buttonBonusExit.Size = new System.Drawing.Size(89, 23);
            this.buttonBonusExit.TabIndex = 8;
            this.buttonBonusExit.Text = "Выход";
            this.buttonBonusExit.UseVisualStyleBackColor = true;
            this.buttonBonusExit.Click += new System.EventHandler(this.buttonBonusExit_Click);
            // 
            // FormBonusProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 261);
            this.Controls.Add(this.buttonBonusExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonBonus3);
            this.Controls.Add(this.radioButtonBonus2);
            this.Controls.Add(this.radioButtonBonus1);
            this.Controls.Add(this.buttonBonusCancel);
            this.Controls.Add(this.buttonBonusCal);
            this.Controls.Add(this.labelBonusChoose);
            this.MaximumSize = new System.Drawing.Size(375, 300);
            this.MinimumSize = new System.Drawing.Size(375, 300);
            this.Name = "FormBonusProgram";
            this.Text = "EatIsHouse - Бонусная программа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBonusChoose;
        private System.Windows.Forms.Button buttonBonusCancel;
        private System.Windows.Forms.RadioButton radioButtonBonus1;
        private System.Windows.Forms.RadioButton radioButtonBonus2;
        private System.Windows.Forms.RadioButton radioButtonBonus3;
        public System.Windows.Forms.Button buttonBonusCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBonusExit;
    }
}