namespace Ювелирная_мастерская
{
    partial class AddProduct
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
            this.Appelation = new System.Windows.Forms.TextBox();
            this.TypeCombo = new System.Windows.Forms.ComboBox();
            this.TimeProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddProductBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Appelation
            // 
            this.Appelation.Location = new System.Drawing.Point(262, 47);
            this.Appelation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Appelation.Name = "Appelation";
            this.Appelation.Size = new System.Drawing.Size(294, 29);
            this.Appelation.TabIndex = 0;
            // 
            // TypeCombo
            // 
            this.TypeCombo.FormattingEnabled = true;
            this.TypeCombo.Location = new System.Drawing.Point(262, 86);
            this.TypeCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TypeCombo.Name = "TypeCombo";
            this.TypeCombo.Size = new System.Drawing.Size(294, 29);
            this.TypeCombo.TabIndex = 1;
            // 
            // TimeProd
            // 
            this.TimeProd.Location = new System.Drawing.Point(262, 124);
            this.TimeProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TimeProd.Name = "TimeProd";
            this.TimeProd.Size = new System.Drawing.Size(294, 29);
            this.TimeProd.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Время изготовления (в днях)";
            // 
            // AddProductBut
            // 
            this.AddProductBut.Location = new System.Drawing.Point(223, 172);
            this.AddProductBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddProductBut.Name = "AddProductBut";
            this.AddProductBut.Size = new System.Drawing.Size(112, 37);
            this.AddProductBut.TabIndex = 6;
            this.AddProductBut.Text = "Добавить";
            this.AddProductBut.UseVisualStyleBackColor = true;
            this.AddProductBut.Click += new System.EventHandler(this.AddProductBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(126, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(309, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите данные об изделии";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 235);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddProductBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeProd);
            this.Controls.Add(this.TypeCombo);
            this.Controls.Add(this.Appelation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Добавление изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Appelation;
        private System.Windows.Forms.ComboBox TypeCombo;
        private System.Windows.Forms.TextBox TimeProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddProductBut;
        private System.Windows.Forms.Label label4;
    }
}