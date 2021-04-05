namespace Ювелирная_мастерская
{
    partial class add_brunch
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
            this.Save_Client = new System.Windows.Forms.Button();
            this.address_brunch = new System.Windows.Forms.TextBox();
            this.conphone_brunch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save_Client
            // 
            this.Save_Client.Location = new System.Drawing.Point(154, 217);
            this.Save_Client.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save_Client.Name = "Save_Client";
            this.Save_Client.Size = new System.Drawing.Size(112, 37);
            this.Save_Client.TabIndex = 0;
            this.Save_Client.Text = "Добавить";
            this.Save_Client.UseVisualStyleBackColor = true;
            this.Save_Client.Click += new System.EventHandler(this.Save_Client_Click);
            // 
            // address_brunch
            // 
            this.address_brunch.Location = new System.Drawing.Point(184, 113);
            this.address_brunch.Name = "address_brunch";
            this.address_brunch.Size = new System.Drawing.Size(225, 29);
            this.address_brunch.TabIndex = 1;
            // 
            // conphone_brunch
            // 
            this.conphone_brunch.Location = new System.Drawing.Point(184, 168);
            this.conphone_brunch.Name = "conphone_brunch";
            this.conphone_brunch.Size = new System.Drawing.Size(225, 29);
            this.conphone_brunch.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Контактный телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(32, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(378, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите в поля данные о филиале";
            // 
            // add_brunch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 278);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.conphone_brunch);
            this.Controls.Add(this.address_brunch);
            this.Controls.Add(this.Save_Client);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "add_brunch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление филиала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Client;
        private System.Windows.Forms.TextBox address_brunch;
        private System.Windows.Forms.TextBox conphone_brunch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
    }
}