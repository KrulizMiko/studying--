namespace MDK06._03
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
            this.firsttask = new System.Windows.Forms.Button();
            this.secondtask = new System.Windows.Forms.Button();
            this.thrihdtask = new System.Windows.Forms.Button();
            this.fourthtask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firsttask
            // 
            this.firsttask.Location = new System.Drawing.Point(30, 32);
            this.firsttask.Name = "firsttask";
            this.firsttask.Size = new System.Drawing.Size(83, 41);
            this.firsttask.TabIndex = 0;
            this.firsttask.Text = "Page 103";
            this.firsttask.UseVisualStyleBackColor = true;
            this.firsttask.Click += new System.EventHandler(this.firsttask_Click);
            // 
            // secondtask
            // 
            this.secondtask.Location = new System.Drawing.Point(30, 91);
            this.secondtask.Name = "secondtask";
            this.secondtask.Size = new System.Drawing.Size(83, 41);
            this.secondtask.TabIndex = 1;
            this.secondtask.Text = "Page 104";
            this.secondtask.UseVisualStyleBackColor = true;
            this.secondtask.Click += new System.EventHandler(this.secondtask_Click);
            // 
            // thrihdtask
            // 
            this.thrihdtask.Location = new System.Drawing.Point(30, 156);
            this.thrihdtask.Name = "thrihdtask";
            this.thrihdtask.Size = new System.Drawing.Size(83, 41);
            this.thrihdtask.TabIndex = 2;
            this.thrihdtask.Text = "Page 105";
            this.thrihdtask.UseVisualStyleBackColor = true;
            this.thrihdtask.Click += new System.EventHandler(this.thrihdtask_Click);
            // 
            // fourthtask
            // 
            this.fourthtask.Location = new System.Drawing.Point(198, 32);
            this.fourthtask.Name = "fourthtask";
            this.fourthtask.Size = new System.Drawing.Size(83, 41);
            this.fourthtask.TabIndex = 3;
            this.fourthtask.Text = "Page 109";
            this.fourthtask.UseVisualStyleBackColor = true;
            this.fourthtask.Click += new System.EventHandler(this.fourthtask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 251);
            this.Controls.Add(this.fourthtask);
            this.Controls.Add(this.thrihdtask);
            this.Controls.Add(this.secondtask);
            this.Controls.Add(this.firsttask);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firsttask;
        private System.Windows.Forms.Button secondtask;
        private System.Windows.Forms.Button thrihdtask;
        private System.Windows.Forms.Button fourthtask;
    }
}

