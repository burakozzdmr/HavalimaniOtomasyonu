namespace HavalimaniOtomasyonu
{
    partial class uçuşlarıGöster
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
            this.uçuşlarıListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uçuşlarıListele)).BeginInit();
            this.SuspendLayout();
            // 
            // uçuşlarıListele
            // 
            this.uçuşlarıListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uçuşlarıListele.Location = new System.Drawing.Point(132, 156);
            this.uçuşlarıListele.Name = "uçuşlarıListele";
            this.uçuşlarıListele.RowHeadersWidth = 82;
            this.uçuşlarıListele.RowTemplate.Height = 33;
            this.uçuşlarıListele.Size = new System.Drawing.Size(1004, 975);
            this.uçuşlarıListele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "UÇUŞLAR";
            // 
            // uçuşlarıGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1331, 1206);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uçuşlarıListele);
            this.Name = "uçuşlarıGöster";
            this.Text = "UçuşlarıGöster";
            this.Load += new System.EventHandler(this.UçuşlarıGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uçuşlarıListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uçuşlarıListele;
        private System.Windows.Forms.Label label1;
    }
}