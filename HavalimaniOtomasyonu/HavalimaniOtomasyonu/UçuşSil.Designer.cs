namespace HavalimaniOtomasyonu
{
    partial class UçuşSil
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
            this.silinecekUcus = new System.Windows.Forms.TextBox();
            this.ucusSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // silinecekUcus
            // 
            this.silinecekUcus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.silinecekUcus.Location = new System.Drawing.Point(185, 302);
            this.silinecekUcus.Name = "silinecekUcus";
            this.silinecekUcus.Size = new System.Drawing.Size(645, 83);
            this.silinecekUcus.TabIndex = 0;
            // 
            // ucusSil
            // 
            this.ucusSil.BackColor = System.Drawing.Color.Red;
            this.ucusSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucusSil.Location = new System.Drawing.Point(229, 482);
            this.ucusSil.Name = "ucusSil";
            this.ucusSil.Size = new System.Drawing.Size(552, 124);
            this.ucusSil.TabIndex = 1;
            this.ucusSil.Text = "UÇUŞ SİL";
            this.ucusSil.UseVisualStyleBackColor = false;
            this.ucusSil.Click += new System.EventHandler(this.ucusSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1017, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "SİLMEK İSTEDİĞİNİZ UÇUŞUN UÇUŞ ID SİNİ GİRİNİZ.";
            // 
            // UçuşSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1079, 1004);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucusSil);
            this.Controls.Add(this.silinecekUcus);
            this.Name = "UçuşSil";
            this.Text = "UçuşSil";
            this.Load += new System.EventHandler(this.UçuşSil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox silinecekUcus;
        private System.Windows.Forms.Button ucusSil;
        private System.Windows.Forms.Label label1;
    }
}