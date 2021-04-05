namespace Ювелирная_мастерская
{
    partial class Upd_Client
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
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Client = new System.Windows.Forms.TextBox();
            this.Surname_Client = new System.Windows.Forms.TextBox();
            this.Save_Client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(65, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "Измените данные о клиенте";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Контактный телефон";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Адрес";
            // 
            // Name_Client
            // 
            this.Name_Client.Location = new System.Drawing.Point(193, 122);
            this.Name_Client.Name = "Name_Client";
            this.Name_Client.Size = new System.Drawing.Size(225, 29);
            this.Name_Client.TabIndex = 14;
            // 
            // Surname_Client
            // 
            this.Surname_Client.Location = new System.Drawing.Point(193, 67);
            this.Surname_Client.Name = "Surname_Client";
            this.Surname_Client.Size = new System.Drawing.Size(225, 29);
            this.Surname_Client.TabIndex = 13;
            // 
            // Save_Client
            // 
            this.Save_Client.Location = new System.Drawing.Point(158, 165);
            this.Save_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_Client.Name = "Save_Client";
            this.Save_Client.Size = new System.Drawing.Size(112, 37);
            this.Save_Client.TabIndex = 12;
            this.Save_Client.Text = "Сохранить";
            this.Save_Client.UseVisualStyleBackColor = true;
            this.Save_Client.Click += new System.EventHandler(this.Save_Client_Click);
            // 
            // Upd_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 216);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name_Client);
            this.Controls.Add(this.Surname_Client);
            this.Controls.Add(this.Save_Client);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Upd_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о клиенте";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Client;
        private System.Windows.Forms.TextBox Surname_Client;
        private System.Windows.Forms.Button Save_Client;
    }
}