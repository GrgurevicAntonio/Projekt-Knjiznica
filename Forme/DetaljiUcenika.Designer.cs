
namespace Knjiznica.Forme
{
    partial class DetaljiUcenika
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
            this.lbOIB = new System.Windows.Forms.Label();
            this.tbOIB = new System.Windows.Forms.TextBox();
            this.lbIme = new System.Windows.Forms.Label();
            this.lbAdresa = new System.Windows.Forms.Label();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.lbPrezime = new System.Windows.Forms.Label();
            this.lbRazred = new System.Windows.Forms.Label();
            this.cbRazred = new System.Windows.Forms.ComboBox();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.tbAdresa = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbOIB
            // 
            this.lbOIB.AutoSize = true;
            this.lbOIB.Location = new System.Drawing.Point(26, 49);
            this.lbOIB.Name = "lbOIB";
            this.lbOIB.Size = new System.Drawing.Size(31, 17);
            this.lbOIB.TabIndex = 0;
            this.lbOIB.Text = "OIB";
            // 
            // tbOIB
            // 
            this.tbOIB.Location = new System.Drawing.Point(99, 49);
            this.tbOIB.Name = "tbOIB";
            this.tbOIB.Size = new System.Drawing.Size(197, 22);
            this.tbOIB.TabIndex = 1;
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Location = new System.Drawing.Point(26, 86);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(30, 17);
            this.lbIme.TabIndex = 2;
            this.lbIme.Text = "Ime";
            // 
            // lbAdresa
            // 
            this.lbAdresa.AutoSize = true;
            this.lbAdresa.Location = new System.Drawing.Point(26, 205);
            this.lbAdresa.Name = "lbAdresa";
            this.lbAdresa.Size = new System.Drawing.Size(53, 17);
            this.lbAdresa.TabIndex = 3;
            this.lbAdresa.Text = "Adresa";
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(27, 164);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(56, 17);
            this.lbTelefon.TabIndex = 4;
            this.lbTelefon.Text = "Telefon";
            this.lbTelefon.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbPrezime
            // 
            this.lbPrezime.AutoSize = true;
            this.lbPrezime.Location = new System.Drawing.Point(27, 120);
            this.lbPrezime.Name = "lbPrezime";
            this.lbPrezime.Size = new System.Drawing.Size(59, 17);
            this.lbPrezime.TabIndex = 5;
            this.lbPrezime.Text = "Prezime";
            this.lbPrezime.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbRazred
            // 
            this.lbRazred.AutoSize = true;
            this.lbRazred.Location = new System.Drawing.Point(27, 245);
            this.lbRazred.Name = "lbRazred";
            this.lbRazred.Size = new System.Drawing.Size(54, 17);
            this.lbRazred.TabIndex = 6;
            this.lbRazred.Text = "Razred";
            // 
            // cbRazred
            // 
            this.cbRazred.FormattingEnabled = true;
            this.cbRazred.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbRazred.Location = new System.Drawing.Point(99, 245);
            this.cbRazred.Name = "cbRazred";
            this.cbRazred.Size = new System.Drawing.Size(68, 24);
            this.cbRazred.TabIndex = 7;
            this.cbRazred.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(99, 86);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(197, 22);
            this.tbIme.TabIndex = 8;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(99, 120);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(197, 22);
            this.tbPrezime.TabIndex = 9;
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(99, 164);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(197, 22);
            this.tbTelefon.TabIndex = 10;
            // 
            // tbAdresa
            // 
            this.tbAdresa.Location = new System.Drawing.Point(99, 205);
            this.tbAdresa.Name = "tbAdresa";
            this.tbAdresa.Size = new System.Drawing.Size(197, 22);
            this.tbAdresa.TabIndex = 11;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(99, 317);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(140, 70);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // DetaljiUcenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 424);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbAdresa);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.cbRazred);
            this.Controls.Add(this.lbRazred);
            this.Controls.Add(this.lbPrezime);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.lbAdresa);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.tbOIB);
            this.Controls.Add(this.lbOIB);
            this.Name = "DetaljiUcenika";
            this.Text = "DetaljiUcenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbOIB;
        private System.Windows.Forms.TextBox tbOIB;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.Label lbAdresa;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.Label lbPrezime;
        private System.Windows.Forms.Label lbRazred;
        private System.Windows.Forms.ComboBox cbRazred;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.TextBox tbAdresa;
        private System.Windows.Forms.Button btnOK;
    }
}