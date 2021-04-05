namespace Ювелирная_мастерская
{
    partial class UpdMaterial
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
            this.label4 = new System.Windows.Forms.Label();
            this.UpdMaterialBut = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.QuaText = new System.Windows.Forms.TextBox();
            this.PrText = new System.Windows.Forms.TextBox();
            this.ApText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(64, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Введите данные о материале";
            // 
            // UpdMaterialBut
            // 
            this.UpdMaterialBut.Location = new System.Drawing.Point(178, 182);
            this.UpdMaterialBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UpdMaterialBut.Name = "UpdMaterialBut";
            this.UpdMaterialBut.Size = new System.Drawing.Size(112, 37);
            this.UpdMaterialBut.TabIndex = 14;
            this.UpdMaterialBut.Text = "Сохранить";
            this.UpdMaterialBut.UseVisualStyleBackColor = true;
            this.UpdMaterialBut.Click += new System.EventHandler(this.UpdMaterialBut_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Количнство на складе";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Цена за грамм";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Название";
            // 
            // QuaText
            // 
            this.QuaText.Location = new System.Drawing.Point(202, 143);
            this.QuaText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QuaText.Name = "QuaText";
            this.QuaText.Size = new System.Drawing.Size(276, 29);
            this.QuaText.TabIndex = 10;
            // 
            // PrText
            // 
            this.PrText.Location = new System.Drawing.Point(202, 101);
            this.PrText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PrText.Name = "PrText";
            this.PrText.Size = new System.Drawing.Size(276, 29);
            this.PrText.TabIndex = 9;
            // 
            // ApText
            // 
            this.ApText.Location = new System.Drawing.Point(202, 59);
            this.ApText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ApText.Name = "ApText";
            this.ApText.Size = new System.Drawing.Size(276, 29);
            this.ApText.TabIndex = 8;
            // 
            // UpdMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 236);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UpdMaterialBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QuaText);
            this.Controls.Add(this.PrText);
            this.Controls.Add(this.ApText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UpdMaterial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение данных о материале";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdMaterialBut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox QuaText;
        private System.Windows.Forms.TextBox PrText;
        private System.Windows.Forms.TextBox ApText;
    }
}