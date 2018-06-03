namespace DosadniAlati
{
    partial class Komande
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
            this.lblSoba = new System.Windows.Forms.LinkLabel();
            this.lblNamjestaj = new System.Windows.Forms.LinkLabel();
            this.lblParametri = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSoba
            // 
            this.lblSoba.AutoSize = true;
            this.lblSoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoba.Location = new System.Drawing.Point(46, 73);
            this.lblSoba.Name = "lblSoba";
            this.lblSoba.Size = new System.Drawing.Size(184, 18);
            this.lblSoba.TabIndex = 0;
            this.lblSoba.TabStop = true;
            this.lblSoba.Text = "1. Dodjela brojeva sobama";
            this.lblSoba.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSoba_LinkClicked);
            // 
            // lblNamjestaj
            // 
            this.lblNamjestaj.AutoSize = true;
            this.lblNamjestaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamjestaj.Location = new System.Drawing.Point(46, 113);
            this.lblNamjestaj.Name = "lblNamjestaj";
            this.lblNamjestaj.Size = new System.Drawing.Size(270, 18);
            this.lblNamjestaj.TabIndex = 1;
            this.lblNamjestaj.TabStop = true;
            this.lblNamjestaj.Text = "2. Prikaz namještaja na aktivnom spratu";
            this.lblNamjestaj.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNamjestaj_LinkClicked);
            // 
            // lblParametri
            // 
            this.lblParametri.AutoSize = true;
            this.lblParametri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParametri.Location = new System.Drawing.Point(46, 151);
            this.lblParametri.Name = "lblParametri";
            this.lblParametri.Size = new System.Drawing.Size(301, 18);
            this.lblParametri.TabIndex = 2;
            this.lblParametri.TabStop = true;
            this.lblParametri.Text = "3. Prikaz parametara selektovanog elementa";
            this.lblParametri.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblParametri_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Izaberite jednu od ponudjenih opcija :";
            // 
            // Komande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 235);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblParametri);
            this.Controls.Add(this.lblNamjestaj);
            this.Controls.Add(this.lblSoba);
            this.Name = "Komande";
            this.Text = "Komande";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblSoba;
        private System.Windows.Forms.LinkLabel lblNamjestaj;
        private System.Windows.Forms.LinkLabel lblParametri;
        private System.Windows.Forms.Label label1;
    }
}