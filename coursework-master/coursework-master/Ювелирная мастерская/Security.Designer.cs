namespace Ювелирная_мастерская
{
    partial class Security
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
            this.Entry = new System.Windows.Forms.Button();
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PassText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ClearBox = new System.Windows.Forms.Label();
            this.PassEye = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Entry
            // 
            this.Entry.Location = new System.Drawing.Point(117, 339);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(110, 44);
            this.Entry.TabIndex = 0;
            this.Entry.Text = "Вход";
            this.Entry.UseVisualStyleBackColor = true;
            this.Entry.Click += new System.EventHandler(this.Entry_Click);
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(57, 121);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(231, 33);
            this.LoginText.TabIndex = 1;
            // 
            // PassText
            // 
            this.PassText.Location = new System.Drawing.Point(57, 198);
            this.PassText.Name = "PassText";
            this.PassText.PasswordChar = '*';
            this.PassText.Size = new System.Drawing.Size(231, 33);
            this.PassText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // ClearBox
            // 
            this.ClearBox.AutoSize = true;
            this.ClearBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.ClearBox.Location = new System.Drawing.Point(116, 290);
            this.ClearBox.Name = "ClearBox";
            this.ClearBox.Size = new System.Drawing.Size(111, 20);
            this.ClearBox.TabIndex = 5;
            this.ClearBox.Text = "Очистить поля";
            this.ClearBox.Click += new System.EventHandler(this.ClearBox_Click);
            // 
            // PassEye
            // 
            this.PassEye.AutoSize = true;
            this.PassEye.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassEye.ForeColor = System.Drawing.Color.SteelBlue;
            this.PassEye.Location = new System.Drawing.Point(53, 234);
            this.PassEye.Name = "PassEye";
            this.PassEye.Size = new System.Drawing.Size(128, 20);
            this.PassEye.TabIndex = 6;
            this.PassEye.Text = "Показать пароль";
            this.PassEye.Click += new System.EventHandler(this.PassEye_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 30);
            this.label5.TabIndex = 7;
            this.label5.Text = "Представьтесь, пожалуйста!";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(13, 421);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(117, 34);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Security
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(354, 467);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PassEye);
            this.Controls.Add(this.ClearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PassText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.Entry);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entry;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PassText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ClearBox;
        private System.Windows.Forms.Label PassEye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Exit;
    }
}

