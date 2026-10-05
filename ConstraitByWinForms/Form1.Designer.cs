namespace ConstraitByWinForms
{
    partial class Form1
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
            this.tbUserInput = new System.Windows.Forms.TextBox();
            this.mtbUserInput = new System.Windows.Forms.MaskedTextBox();
            this.rbTT01 = new System.Windows.Forms.RadioButton();
            this.rbTT02 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbUserInput
            // 
            this.tbUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUserInput.Location = new System.Drawing.Point(63, 183);
            this.tbUserInput.Name = "tbUserInput";
            this.tbUserInput.Size = new System.Drawing.Size(630, 41);
            this.tbUserInput.TabIndex = 0;
            this.tbUserInput.TextChanged += new System.EventHandler(this.tbUserInput_TextChanged);
            // 
            // mtbUserInput
            // 
            this.mtbUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mtbUserInput.Location = new System.Drawing.Point(63, 248);
            this.mtbUserInput.Mask = "00000";
            this.mtbUserInput.Name = "mtbUserInput";
            this.mtbUserInput.Size = new System.Drawing.Size(630, 41);
            this.mtbUserInput.TabIndex = 1;
            this.mtbUserInput.ValidatingType = typeof(int);
            // 
            // rbTT01
            // 
            this.rbTT01.AutoSize = true;
            this.rbTT01.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTT01.Location = new System.Drawing.Point(18, 3);
            this.rbTT01.Name = "rbTT01";
            this.rbTT01.Size = new System.Drawing.Size(111, 35);
            this.rbTT01.TabIndex = 4;
            this.rbTT01.TabStop = true;
            this.rbTT01.Text = "ТЗ_01";
            this.rbTT01.UseVisualStyleBackColor = true;
            // 
            // rbTT02
            // 
            this.rbTT02.AutoSize = true;
            this.rbTT02.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbTT02.Location = new System.Drawing.Point(18, 45);
            this.rbTT02.Name = "rbTT02";
            this.rbTT02.Size = new System.Drawing.Size(111, 35);
            this.rbTT02.TabIndex = 4;
            this.rbTT02.TabStop = true;
            this.rbTT02.Text = "ТЗ_02";
            this.rbTT02.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.rbTT01);
            this.panel1.Controls.Add(this.rbTT02);
            this.panel1.Location = new System.Drawing.Point(63, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // btnDo
            // 
            this.btnDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDo.Location = new System.Drawing.Point(714, 183);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(116, 41);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "Go!";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mtbUserInput);
            this.Controls.Add(this.tbUserInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserInput;
        private System.Windows.Forms.MaskedTextBox mtbUserInput;
        private System.Windows.Forms.RadioButton rbTT01;
        private System.Windows.Forms.RadioButton rbTT02;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDo;
    }
}

