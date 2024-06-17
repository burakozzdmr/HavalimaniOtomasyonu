namespace HavalimaniOtomasyonu
{
    partial class havalimanlariniGöster
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
            this.havalimanlarınıListele = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlarınıListele)).BeginInit();
            this.SuspendLayout();
            // 
            // havalimanlarınıListele
            // 
            this.havalimanlarınıListele.AllowUserToOrderColumns = true;
            this.havalimanlarınıListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.havalimanlarınıListele.Location = new System.Drawing.Point(42, 189);
            this.havalimanlarınıListele.Name = "havalimanlarınıListele";
            this.havalimanlarınıListele.RowHeadersWidth = 82;
            this.havalimanlarınıListele.RowTemplate.Height = 33;
            this.havalimanlarınıListele.Size = new System.Drawing.Size(943, 895);
            this.havalimanlarınıListele.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 61);
            this.label1.TabIndex = 1;
            this.label1.Text = "HAVALİMANLARI";
            // 
            // havalimanlariniGöster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1105, 1110);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.havalimanlarınıListele);
            this.Name = "havalimanlariniGöster";
            this.Text = "HavalimanlarınıGöster";
            this.Load += new System.EventHandler(this.HavalimanlarınıGöster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.havalimanlarınıListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView havalimanlarınıListele;
        private System.Windows.Forms.Label label1;
    }
}