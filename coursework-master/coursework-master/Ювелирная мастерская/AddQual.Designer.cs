namespace Ювелирная_мастерская
{
    partial class AddQual
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
            this.AText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PText = new System.Windows.Forms.TextBox();
            this.AddButQual = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AText
            // 
            this.AText.Location = new System.Drawing.Point(153, 80);
            this.AText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AText.Name = "AText";
            this.AText.Size = new System.Drawing.Size(367, 29);
            this.AText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Полномочия";
            // 
            // PText
            // 
            this.PText.Location = new System.Drawing.Point(153, 132);
            this.PText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PText.Multiline = true;
            this.PText.Name = "PText";
            this.PText.Size = new System.Drawing.Size(367, 151);
            this.PText.TabIndex = 3;
            // 
            // AddButQual
            // 
            this.AddButQual.Location = new System.Drawing.Point(201, 291);
            this.AddButQual.Name = "AddButQual";
            this.AddButQual.Size = new System.Drawing.Size(119, 44);
            this.AddButQual.TabIndex = 4;
            this.AddButQual.Text = "Добавить";
            this.AddButQual.UseVisualStyleBackColor = true;
            this.AddButQual.Click += new System.EventHandler(this.AddButQual_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(87, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(367, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите данные о квалификации";
            // 
            // AddQual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 347);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddButQual);
            this.Controls.Add(this.PText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddQual";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление квалификации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PText;
        private System.Windows.Forms.Button AddButQual;
        private System.Windows.Forms.Label label3;
    }
}