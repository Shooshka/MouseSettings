namespace MouseSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPravsha = new System.Windows.Forms.Button();
            this.btlLevsha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPravsha
            // 
            this.btnPravsha.Location = new System.Drawing.Point(20, 20);
            this.btnPravsha.Name = "btnPravsha";
            this.btnPravsha.Size = new System.Drawing.Size(87, 20);
            this.btnPravsha.TabIndex = 0;
            this.btnPravsha.Text = "Для правшей";
            this.btnPravsha.UseVisualStyleBackColor = true;
            this.btnPravsha.Click += new System.EventHandler(this.btnPravsha_Click);
            // 
            // btlLevsha
            // 
            this.btlLevsha.Location = new System.Drawing.Point(20, 40);
            this.btlLevsha.Name = "btlLevsha";
            this.btlLevsha.Size = new System.Drawing.Size(87, 20);
            this.btlLevsha.TabIndex = 1;
            this.btlLevsha.Text = "Для левшей";
            this.btlLevsha.UseVisualStyleBackColor = true;
            this.btlLevsha.Click += new System.EventHandler(this.btlLevsha_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 81);
            this.Controls.Add(this.btlLevsha);
            this.Controls.Add(this.btnPravsha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Настройка мыши";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPravsha;
        private System.Windows.Forms.Button btlLevsha;
    }
}

