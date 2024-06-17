namespace HavalimaniOtomasyonu
{
    partial class YolcuSil
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
            this.silinecekYolcu = new System.Windows.Forms.TextBox();
            this.Yolcu_Sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // silinecekYolcu
            // 
            this.silinecekYolcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silinecekYolcu.Location = new System.Drawing.Point(220, 136);
            this.silinecekYolcu.Name = "silinecekYolcu";
            this.silinecekYolcu.Size = new System.Drawing.Size(512, 67);
            this.silinecekYolcu.TabIndex = 0;
            // 
            // Yolcu_Sil
            // 
            this.Yolcu_Sil.BackColor = System.Drawing.Color.Red;
            this.Yolcu_Sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Yolcu_Sil.ForeColor = System.Drawing.Color.Black;
            this.Yolcu_Sil.Location = new System.Drawing.Point(223, 292);
            this.Yolcu_Sil.Name = "Yolcu_Sil";
            this.Yolcu_Sil.Size = new System.Drawing.Size(509, 104);
            this.Yolcu_Sil.TabIndex = 1;
            this.Yolcu_Sil.Text = "YOLCU SİL ";
            this.Yolcu_Sil.UseVisualStyleBackColor = false;
            this.Yolcu_Sil.Click += new System.EventHandler(this.Yolcu_Sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ YOLCUNUN ID SİNİ GİRİNİZ.";
            // 
            // YolcuSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1020, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yolcu_Sil);
            this.Controls.Add(this.silinecekYolcu);
            this.Name = "YolcuSil";
            this.Text = "YolcuSil";
            this.Load += new System.EventHandler(this.YolcuSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox silinecekYolcu;
        private System.Windows.Forms.Button Yolcu_Sil;
        private System.Windows.Forms.Label label1;
    }
}