namespace HavalimaniOtomasyonu
{
    partial class HavalimanıSil
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
            this.silinecekHavalimani = new System.Windows.Forms.TextBox();
            this.havalimaniSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // silinecekHavalimani
            // 
            this.silinecekHavalimani.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silinecekHavalimani.Location = new System.Drawing.Point(163, 226);
            this.silinecekHavalimani.Name = "silinecekHavalimani";
            this.silinecekHavalimani.Size = new System.Drawing.Size(642, 67);
            this.silinecekHavalimani.TabIndex = 0;
            // 
            // havalimaniSil
            // 
            this.havalimaniSil.BackColor = System.Drawing.Color.Red;
            this.havalimaniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.havalimaniSil.Location = new System.Drawing.Point(163, 398);
            this.havalimaniSil.Name = "havalimaniSil";
            this.havalimaniSil.Size = new System.Drawing.Size(642, 106);
            this.havalimaniSil.TabIndex = 1;
            this.havalimaniSil.Text = "HAVALİMANI SİL";
            this.havalimaniSil.UseVisualStyleBackColor = false;
            this.havalimaniSil.Click += new System.EventHandler(this.havalimaniSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(932, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ HAVALİMANININ KODUNU GİRİNİZ.";
            // 
            // HavalimanıSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1042, 656);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.havalimaniSil);
            this.Controls.Add(this.silinecekHavalimani);
            this.Name = "HavalimanıSil";
            this.Text = "HavalimanıSil";
            this.Load += new System.EventHandler(this.HavalimanıSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox silinecekHavalimani;
        private System.Windows.Forms.Button havalimaniSil;
        private System.Windows.Forms.Label label1;
    }
}