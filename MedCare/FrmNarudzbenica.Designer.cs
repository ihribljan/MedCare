namespace MedCare
{
    partial class FrmNarudzbenica
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNarudzbenica));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtZaposlenik = new System.Windows.Forms.TextBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cmbPoslovniPartner = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtKontakt = new System.Windows.Forms.TextBox();
            this.dgvNarudzbenica = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnGenerairajNarudžbenicu = new System.Windows.Forms.Button();
            this.narudžbenicaStavkeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.btnZakljuciNarudzbenicu = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbenicaStavkeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaposlenik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Poslovni partner";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum";
            // 
            // txtZaposlenik
            // 
            this.txtZaposlenik.Location = new System.Drawing.Point(127, 73);
            this.txtZaposlenik.Name = "txtZaposlenik";
            this.txtZaposlenik.ReadOnly = true;
            this.txtZaposlenik.Size = new System.Drawing.Size(200, 20);
            this.txtZaposlenik.TabIndex = 4;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(127, 35);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 5;
            // 
            // cmbPoslovniPartner
            // 
            this.cmbPoslovniPartner.FormattingEnabled = true;
            this.cmbPoslovniPartner.Location = new System.Drawing.Point(127, 118);
            this.cmbPoslovniPartner.Name = "cmbPoslovniPartner";
            this.cmbPoslovniPartner.Size = new System.Drawing.Size(200, 21);
            this.cmbPoslovniPartner.TabIndex = 6;
            this.cmbPoslovniPartner.SelectedIndexChanged += new System.EventHandler(this.cmbPoslovniPartner_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kontakt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(155, 156);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(172, 20);
            this.txtAdresa.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(155, 208);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(172, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtKontakt
            // 
            this.txtKontakt.Location = new System.Drawing.Point(155, 182);
            this.txtKontakt.Name = "txtKontakt";
            this.txtKontakt.Size = new System.Drawing.Size(172, 20);
            this.txtKontakt.TabIndex = 11;
            // 
            // dgvNarudzbenica
            // 
            this.dgvNarudzbenica.AllowUserToAddRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNarudzbenica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNarudzbenica.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNarudzbenica.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbenica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNarudzbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Naziv,
            this.Kolicina,
            this.Cijena});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNarudzbenica.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvNarudzbenica.Location = new System.Drawing.Point(12, 253);
            this.dgvNarudzbenica.Name = "dgvNarudzbenica";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNarudzbenica.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvNarudzbenica.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNarudzbenica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbenica.Size = new System.Drawing.Size(776, 185);
            this.dgvNarudzbenica.TabIndex = 12;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "NAZIV";
            this.Naziv.Name = "Naziv";
            this.Naziv.Width = 232;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "KOLIČINA";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.Width = 200;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "CIJENA";
            this.Cijena.Name = "Cijena";
            this.Cijena.Width = 200;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Proizvod";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(576, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Količina";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(576, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cijena";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(640, 79);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(148, 21);
            this.cmbProizvod.TabIndex = 16;
            this.cmbProizvod.SelectedIndexChanged += new System.EventHandler(this.cmbProizvod_SelectedIndexChanged);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDodaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodaj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodaj.FlatAppearance.BorderSize = 0;
            this.btnDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodaj.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodaj.ForeColor = System.Drawing.Color.White;
            this.btnDodaj.Location = new System.Drawing.Point(688, 203);
            this.btnDodaj.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 30);
            this.btnDodaj.TabIndex = 26;
            this.btnDodaj.Text = "Dodaj stavku";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnObrisi.BackColor = System.Drawing.Color.Red;
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.Color.White;
            this.btnObrisi.Location = new System.Drawing.Point(579, 203);
            this.btnObrisi.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(100, 30);
            this.btnObrisi.TabIndex = 27;
            this.btnObrisi.Text = "Obriši stavku";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnGenerairajNarudžbenicu
            // 
            this.btnGenerairajNarudžbenicu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerairajNarudžbenicu.BackColor = System.Drawing.Color.Gray;
            this.btnGenerairajNarudžbenicu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGenerairajNarudžbenicu.FlatAppearance.BorderSize = 0;
            this.btnGenerairajNarudžbenicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerairajNarudžbenicu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerairajNarudžbenicu.ForeColor = System.Drawing.Color.White;
            this.btnGenerairajNarudžbenicu.Location = new System.Drawing.Point(640, 486);
            this.btnGenerairajNarudžbenicu.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerairajNarudžbenicu.Name = "btnGenerairajNarudžbenicu";
            this.btnGenerairajNarudžbenicu.Size = new System.Drawing.Size(150, 30);
            this.btnGenerairajNarudžbenicu.TabIndex = 28;
            this.btnGenerairajNarudžbenicu.Text = "Prikaži narudžbenice";
            this.btnGenerairajNarudžbenicu.UseVisualStyleBackColor = false;
            this.btnGenerairajNarudžbenicu.Click += new System.EventHandler(this.btnGenerairajNarudžbenicu_Click);
            // 
            // _19059_DBDataSet2
            // 
            // 
            // narudžbenicaStavkeBindingSource
            // 
            this.narudžbenicaStavkeBindingSource.DataMember = "NarudžbenicaStavke";
            // 
            // narudžbenicaStavkeTableAdapter
            // 
            // 
            // txtKolicina
            // 
            this.txtKolicina.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtKolicina.Location = new System.Drawing.Point(708, 152);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(80, 20);
            this.txtKolicina.TabIndex = 29;
            this.txtKolicina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKolicina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKolicina_KeyDown);
            // 
            // txtCijena
            // 
            this.txtCijena.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtCijena.Location = new System.Drawing.Point(708, 118);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.ReadOnly = true;
            this.txtCijena.Size = new System.Drawing.Size(80, 20);
            this.txtCijena.TabIndex = 30;
            this.txtCijena.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnZakljuciNarudzbenicu
            // 
            this.btnZakljuciNarudzbenicu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnZakljuciNarudzbenicu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(179)))), ((int)(((byte)(230)))));
            this.btnZakljuciNarudzbenicu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnZakljuciNarudzbenicu.FlatAppearance.BorderSize = 0;
            this.btnZakljuciNarudzbenicu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZakljuciNarudzbenicu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnZakljuciNarudzbenicu.ForeColor = System.Drawing.Color.White;
            this.btnZakljuciNarudzbenicu.Location = new System.Drawing.Point(640, 443);
            this.btnZakljuciNarudzbenicu.Margin = new System.Windows.Forms.Padding(2);
            this.btnZakljuciNarudzbenicu.Name = "btnZakljuciNarudzbenicu";
            this.btnZakljuciNarudzbenicu.Size = new System.Drawing.Size(150, 30);
            this.btnZakljuciNarudzbenicu.TabIndex = 31;
            this.btnZakljuciNarudzbenicu.Text = "Zaključi narudžbenicu";
            this.btnZakljuciNarudzbenicu.UseVisualStyleBackColor = false;
            this.btnZakljuciNarudzbenicu.Click += new System.EventHandler(this.btnZakljuciNarudzbenicu_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(12, 443);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 30);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Nova narudžbenica";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnZakljuciNarudzbenicu);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.btnGenerairajNarudžbenicu);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvNarudzbenica);
            this.Controls.Add(this.txtKontakt);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbPoslovniPartner);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.txtZaposlenik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Narudžbenica";
            this.Load += new System.EventHandler(this.FrmNarudzbenica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbenicaStavkeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtZaposlenik;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox cmbPoslovniPartner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtKontakt;
        private System.Windows.Forms.DataGridView dgvNarudzbenica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnGenerairajNarudžbenicu;
        private System.Windows.Forms.BindingSource narudžbenicaStavkeBindingSource;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button btnZakljuciNarudzbenicu;
        private System.Windows.Forms.Button btnReset;
    }
}