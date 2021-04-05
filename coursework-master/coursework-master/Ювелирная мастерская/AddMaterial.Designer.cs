namespace Ювелирная_мастерская
{
    partial class AddMaterial
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
            this.ApText = new System.Windows.Forms.TextBox();
            this.PrText = new System.Windows.Forms.TextBox();
            this.QuaText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddMaterialBut = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ApText
            // 
            this.ApText.Location = new System.Drawing.Point(216, 55);
            this.ApText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApText.Name = "ApText";
            this.ApText.Size = new System.Drawing.Size(276, 29);
            this.ApText.TabIndex = 0;
            // 
            // PrText
            // 
            this.PrText.Location = new System.Drawing.Point(216, 97);
            this.PrText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrText.Name = "PrText";
            this.PrText.Size = new System.Drawing.Size(276, 29);
            this.PrText.TabIndex = 1;
            // 
            // QuaText
            // 
            this.QuaText.Location = new System.Drawing.Point(216, 142);
            this.QuaText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuaText.Name = "QuaText";
            this.QuaText.Size = new System.Drawing.Size(276, 29);
            this.QuaText.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Цена за грамм";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество на складе";
            // 
            // AddMaterialBut
            // 
            this.AddMaterialBut.Location = new System.Drawing.Point(193, 194);
            this.AddMaterialBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddMaterialBut.Name = "AddMaterialBut";
            this.AddMaterialBut.Size = new System.Drawing.Size(112, 37);
            this.AddMaterialBut.TabIndex = 6;
            this.AddMaterialBut.Text = "Добавить";
            this.AddMaterialBut.UseVisualStyleBackColor = true;
            this.AddMaterialBut.Click += new System.EventHandler(this.AddMaterialBut_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 30);
            this.label4.TabIndex = 7;
            this.label4.Text = "Введите данные о материале";
            // 
            // AddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 245);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AddMaterialBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuaText);
            this.Controls.Add(this.PrText);
            this.Controls.Add(this.ApText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление материала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ApText;
        private System.Windows.Forms.TextBox PrText;
        private System.Windows.Forms.TextBox QuaText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddMaterialBut;
        private System.Windows.Forms.Label label4;
    }
}