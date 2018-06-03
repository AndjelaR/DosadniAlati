namespace DosadniAlati
{
    partial class DodjelaBrojaSobe
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbBrojSobe = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Revit_HEB_DWG", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unesite broj prve sobe :";
            // 
            // tbBrojSobe
            // 
            this.tbBrojSobe.Location = new System.Drawing.Point(76, 60);
            this.tbBrojSobe.MaximumSize = new System.Drawing.Size(46, 20);
            this.tbBrojSobe.Name = "tbBrojSobe";
            this.tbBrojSobe.Size = new System.Drawing.Size(46, 20);
            this.tbBrojSobe.TabIndex = 2;
            this.tbBrojSobe.TextChanged += new System.EventHandler(this.tbBrojSobe_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Revit_HEB_DWG", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(35, 108);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(237, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Automatska dodjela brojeva sobama";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnUnos
            // 
            this.btnUnos.Font = new System.Drawing.Font("Revit_HEB_DWG", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnos.Location = new System.Drawing.Point(137, 58);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(55, 23);
            this.btnUnos.TabIndex = 4;
            this.btnUnos.Text = "OK";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // DodjelaBrojaSobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 200);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.tbBrojSobe);
            this.Controls.Add(this.label2);
            this.Name = "DodjelaBrojaSobe";
            this.Text = "DodjelaBrojaSobe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodjelaBrojaSobe_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBrojSobe;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnUnos;
    }
}