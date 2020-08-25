namespace Conversion
{
    partial class MainForm
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
            this.btnReconnect = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cbDestCurrency = new System.Windows.Forms.ComboBox();
            this.cbSourceCurrency = new System.Windows.Forms.ComboBox();
            this.tbDestCurrency = new System.Windows.Forms.TextBox();
            this.tbSourceCurrency = new System.Windows.Forms.TextBox();
            this.lblConnected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReconnect
            // 
            this.btnReconnect.Location = new System.Drawing.Point(15, 25);
            this.btnReconnect.Name = "btnReconnect";
            this.btnReconnect.Size = new System.Drawing.Size(137, 23);
            this.btnReconnect.TabIndex = 0;
            this.btnReconnect.Text = "Переподключиться";
            this.btnReconnect.UseVisualStyleBackColor = true;
            this.btnReconnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Location = new System.Drawing.Point(205, 139);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(105, 23);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "Перевести";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // cbDestCurrency
            // 
            this.cbDestCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestCurrency.FormattingEnabled = true;
            this.cbDestCurrency.Location = new System.Drawing.Point(276, 100);
            this.cbDestCurrency.Name = "cbDestCurrency";
            this.cbDestCurrency.Size = new System.Drawing.Size(177, 21);
            this.cbDestCurrency.TabIndex = 2;
            // 
            // cbSourceCurrency
            // 
            this.cbSourceCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSourceCurrency.FormattingEnabled = true;
            this.cbSourceCurrency.Location = new System.Drawing.Point(64, 100);
            this.cbSourceCurrency.Name = "cbSourceCurrency";
            this.cbSourceCurrency.Size = new System.Drawing.Size(177, 21);
            this.cbSourceCurrency.TabIndex = 3;
            // 
            // tbDestCurrency
            // 
            this.tbDestCurrency.Location = new System.Drawing.Point(276, 74);
            this.tbDestCurrency.Name = "tbDestCurrency";
            this.tbDestCurrency.ReadOnly = true;
            this.tbDestCurrency.Size = new System.Drawing.Size(177, 20);
            this.tbDestCurrency.TabIndex = 4;
            this.tbDestCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDestCurrency_KeyPress);
            // 
            // tbSourceCurrency
            // 
            this.tbSourceCurrency.Location = new System.Drawing.Point(63, 74);
            this.tbSourceCurrency.Name = "tbSourceCurrency";
            this.tbSourceCurrency.Size = new System.Drawing.Size(178, 20);
            this.tbSourceCurrency.TabIndex = 5;
            this.tbSourceCurrency.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDestCurrency_KeyPress);
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(12, 9);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(140, 13);
            this.lblConnected.TabIndex = 6;
            this.lblConnected.Text = "Нет подключения к НБРБ.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 173);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.tbSourceCurrency);
            this.Controls.Add(this.tbDestCurrency);
            this.Controls.Add(this.cbSourceCurrency);
            this.Controls.Add(this.cbDestCurrency);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnReconnect);
            this.Name = "MainForm";
            this.Text = "Currency сonverter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReconnect;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cbDestCurrency;
        private System.Windows.Forms.ComboBox cbSourceCurrency;
        private System.Windows.Forms.TextBox tbDestCurrency;
        private System.Windows.Forms.TextBox tbSourceCurrency;
        private System.Windows.Forms.Label lblConnected;
    }
}

