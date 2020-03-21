namespace MedCare
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnStatistika = new System.Windows.Forms.Button();
            this.pbMedCare = new System.Windows.Forms.PictureBox();
            this.btnSkladiste = new System.Windows.Forms.Button();
            this.btnPocetna = new System.Windows.Forms.Button();
            this.btnOdjava = new System.Windows.Forms.Button();
            this.btnZaposlenici = new System.Windows.Forms.Button();
            this.btnPacijenti = new System.Windows.Forms.Button();
            this.pnlMainView = new System.Windows.Forms.Panel();
            this.lblImePrezimeZaposlenika = new System.Windows.Forms.Label();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedCare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.pnlLeft.Controls.Add(this.btnStatistika);
            this.pnlLeft.Controls.Add(this.pbMedCare);
            this.pnlLeft.Controls.Add(this.btnSkladiste);
            this.pnlLeft.Controls.Add(this.btnPocetna);
            this.pnlLeft.Controls.Add(this.btnOdjava);
            this.pnlLeft.Controls.Add(this.btnZaposlenici);
            this.pnlLeft.Controls.Add(this.btnPacijenti);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(229, 691);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistika.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnStatistika.FlatAppearance.BorderSize = 0;
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnStatistika.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatistika.ForeColor = System.Drawing.Color.White;
            this.btnStatistika.Image = global::MedCare.Properties.Resources.icons8_combo_chart_48;
            this.btnStatistika.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistika.Location = new System.Drawing.Point(15, 475);
            this.btnStatistika.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(195, 50);
            this.btnStatistika.TabIndex = 10;
            this.btnStatistika.Text = "  Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // pbMedCare
            // 
            this.pbMedCare.BackColor = System.Drawing.Color.Transparent;
            this.pbMedCare.ErrorImage = null;
            this.pbMedCare.Image = global::MedCare.Properties.Resources.MedCare_white;
            this.pbMedCare.InitialImage = global::MedCare.Properties.Resources.MedCare_white;
            this.pbMedCare.Location = new System.Drawing.Point(12, 12);
            this.pbMedCare.Name = "pbMedCare";
            this.pbMedCare.Size = new System.Drawing.Size(205, 85);
            this.pbMedCare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMedCare.TabIndex = 9;
            this.pbMedCare.TabStop = false;
            this.pbMedCare.WaitOnLoad = true;
            // 
            // btnSkladiste
            // 
            this.btnSkladiste.BackColor = System.Drawing.Color.Transparent;
            this.btnSkladiste.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSkladiste.FlatAppearance.BorderSize = 0;
            this.btnSkladiste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkladiste.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSkladiste.ForeColor = System.Drawing.Color.White;
            this.btnSkladiste.Image = ((System.Drawing.Image)(resources.GetObject("btnSkladiste.Image")));
            this.btnSkladiste.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSkladiste.Location = new System.Drawing.Point(20, 400);
            this.btnSkladiste.Margin = new System.Windows.Forms.Padding(2);
            this.btnSkladiste.Name = "btnSkladiste";
            this.btnSkladiste.Size = new System.Drawing.Size(195, 50);
            this.btnSkladiste.TabIndex = 8;
            this.btnSkladiste.Text = "Skladište";
            this.btnSkladiste.UseVisualStyleBackColor = false;
            this.btnSkladiste.Click += new System.EventHandler(this.btnSkladiste_Click);
            // 
            // btnPocetna
            // 
            this.btnPocetna.BackColor = System.Drawing.Color.Transparent;
            this.btnPocetna.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPocetna.FlatAppearance.BorderSize = 0;
            this.btnPocetna.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnPocetna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPocetna.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPocetna.ForeColor = System.Drawing.Color.White;
            this.btnPocetna.Image = global::MedCare.Properties.Resources.icons8_application_window_48;
            this.btnPocetna.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPocetna.Location = new System.Drawing.Point(15, 175);
            this.btnPocetna.Margin = new System.Windows.Forms.Padding(2);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(200, 50);
            this.btnPocetna.TabIndex = 6;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = false;
            this.btnPocetna.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // btnOdjava
            // 
            this.btnOdjava.BackColor = System.Drawing.Color.Transparent;
            this.btnOdjava.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnOdjava.FlatAppearance.BorderSize = 0;
            this.btnOdjava.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnOdjava.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdjava.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnOdjava.ForeColor = System.Drawing.Color.White;
            this.btnOdjava.Image = global::MedCare.Properties.Resources.icons8_exit_48;
            this.btnOdjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOdjava.Location = new System.Drawing.Point(15, 640);
            this.btnOdjava.Margin = new System.Windows.Forms.Padding(2);
            this.btnOdjava.Name = "btnOdjava";
            this.btnOdjava.Size = new System.Drawing.Size(195, 50);
            this.btnOdjava.TabIndex = 5;
            this.btnOdjava.Text = "Odjava";
            this.btnOdjava.UseVisualStyleBackColor = false;
            this.btnOdjava.Click += new System.EventHandler(this.btnOdjava_Click);
            // 
            // btnZaposlenici
            // 
            this.btnZaposlenici.BackColor = System.Drawing.Color.Transparent;
            this.btnZaposlenici.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnZaposlenici.FlatAppearance.BorderSize = 0;
            this.btnZaposlenici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnZaposlenici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZaposlenici.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnZaposlenici.ForeColor = System.Drawing.Color.White;
            this.btnZaposlenici.Image = global::MedCare.Properties.Resources.icons8_doctor_male_48;
            this.btnZaposlenici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnZaposlenici.Location = new System.Drawing.Point(15, 325);
            this.btnZaposlenici.Margin = new System.Windows.Forms.Padding(2);
            this.btnZaposlenici.Name = "btnZaposlenici";
            this.btnZaposlenici.Size = new System.Drawing.Size(200, 50);
            this.btnZaposlenici.TabIndex = 3;
            this.btnZaposlenici.Text = "     Zaposlenici";
            this.btnZaposlenici.UseVisualStyleBackColor = false;
            this.btnZaposlenici.Click += new System.EventHandler(this.btnZaposlenici_Click);
            // 
            // btnPacijenti
            // 
            this.btnPacijenti.BackColor = System.Drawing.Color.Transparent;
            this.btnPacijenti.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPacijenti.FlatAppearance.BorderSize = 0;
            this.btnPacijenti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(237)))), ((int)(((byte)(159)))));
            this.btnPacijenti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPacijenti.ForeColor = System.Drawing.Color.White;
            this.btnPacijenti.Image = global::MedCare.Properties.Resources.icons8_family_48;
            this.btnPacijenti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacijenti.Location = new System.Drawing.Point(15, 250);
            this.btnPacijenti.Margin = new System.Windows.Forms.Padding(2);
            this.btnPacijenti.Name = "btnPacijenti";
            this.btnPacijenti.Size = new System.Drawing.Size(200, 50);
            this.btnPacijenti.TabIndex = 2;
            this.btnPacijenti.Text = " Pacijenti";
            this.btnPacijenti.UseVisualStyleBackColor = false;
            this.btnPacijenti.Click += new System.EventHandler(this.btnPacijenti_Click);
            // 
            // pnlMainView
            // 
            this.pnlMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMainView.Location = new System.Drawing.Point(234, 86);
            this.pnlMainView.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMainView.Name = "pnlMainView";
            this.pnlMainView.Size = new System.Drawing.Size(1100, 685);
            this.pnlMainView.TabIndex = 2;
            // 
            // lblImePrezimeZaposlenika
            // 
            this.lblImePrezimeZaposlenika.AutoSize = true;
            this.lblImePrezimeZaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblImePrezimeZaposlenika.ForeColor = System.Drawing.Color.White;
            this.lblImePrezimeZaposlenika.Location = new System.Drawing.Point(800, 30);
            this.lblImePrezimeZaposlenika.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImePrezimeZaposlenika.Name = "lblImePrezimeZaposlenika";
            this.lblImePrezimeZaposlenika.Size = new System.Drawing.Size(126, 24);
            this.lblImePrezimeZaposlenika.TabIndex = 0;
            this.lblImePrezimeZaposlenika.Text = "Ime Prezime";
            // 
            // pbAvatar
            // 
            this.pbAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbAvatar.Image = global::MedCare.Properties.Resources.icons8_combo_chart_48; // TAJ?
            this.pbAvatar.Location = new System.Drawing.Point(741, 11);
            this.pbAvatar.Margin = new System.Windows.Forms.Padding(2);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(55, 58);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.pnlTop.Controls.Add(this.pbAvatar);
            this.pnlTop.Controls.Add(this.lblImePrezimeZaposlenika);
            this.pnlTop.Location = new System.Drawing.Point(229, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(953, 80);
            this.pnlTop.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 691);
            this.Controls.Add(this.pnlMainView);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedCare";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.pnlLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMedCare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Button btnPacijenti;
        private System.Windows.Forms.Button btnOdjava;
        private System.Windows.Forms.Button btnZaposlenici;
        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.Button btnSkladiste;
        private System.Windows.Forms.Panel pnlMainView;
        private System.Windows.Forms.PictureBox pbMedCare;
        private System.Windows.Forms.Button btnStatistika;
        private System.Windows.Forms.Label lblImePrezimeZaposlenika;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Panel pnlTop;
    }
}

