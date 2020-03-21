namespace MedCare
{
    partial class FrmDodajRacun
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajRacun));
            this.lblDatumKreiranjaRacuna = new System.Windows.Forms.Label();
            this.lblTrenutniDatumRacuna = new System.Windows.Forms.Label();
            this.lblIzdaoRacun = new System.Windows.Forms.Label();
            this.lblRacunPacijenta = new System.Windows.Forms.Label();
            this.lblIzdaoLijecnik = new System.Windows.Forms.Label();
            this.lblIzdajePacijentu = new System.Windows.Forms.Label();
            this.lblUkupniIznosRacuna = new System.Windows.Forms.Label();
            this.lblTrenutniIznos = new System.Windows.Forms.Label();
            this.lblValuta = new System.Windows.Forms.Label();
            this.btnSpremiRacun = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.Dodaj = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Količina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProizvodi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDatumKreiranjaRacuna
            // 
            this.lblDatumKreiranjaRacuna.AutoSize = true;
            this.lblDatumKreiranjaRacuna.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDatumKreiranjaRacuna.Location = new System.Drawing.Point(9, 25);
            this.lblDatumKreiranjaRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatumKreiranjaRacuna.Name = "lblDatumKreiranjaRacuna";
            this.lblDatumKreiranjaRacuna.Size = new System.Drawing.Size(53, 18);
            this.lblDatumKreiranjaRacuna.TabIndex = 1;
            this.lblDatumKreiranjaRacuna.Text = "Datum:";
            // 
            // lblTrenutniDatumRacuna
            // 
            this.lblTrenutniDatumRacuna.AutoSize = true;
            this.lblTrenutniDatumRacuna.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniDatumRacuna.Location = new System.Drawing.Point(64, 26);
            this.lblTrenutniDatumRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrenutniDatumRacuna.Name = "lblTrenutniDatumRacuna";
            this.lblTrenutniDatumRacuna.Size = new System.Drawing.Size(94, 17);
            this.lblTrenutniDatumRacuna.TabIndex = 2;
            this.lblTrenutniDatumRacuna.Text = "TrenutniDatum";
            // 
            // lblIzdaoRacun
            // 
            this.lblIzdaoRacun.AutoSize = true;
            this.lblIzdaoRacun.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdaoRacun.Location = new System.Drawing.Point(9, 54);
            this.lblIzdaoRacun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzdaoRacun.Name = "lblIzdaoRacun";
            this.lblIzdaoRacun.Size = new System.Drawing.Size(85, 18);
            this.lblIzdaoRacun.TabIndex = 3;
            this.lblIzdaoRacun.Text = "Račun izdao:";
            // 
            // lblRacunPacijenta
            // 
            this.lblRacunPacijenta.AutoSize = true;
            this.lblRacunPacijenta.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRacunPacijenta.Location = new System.Drawing.Point(9, 84);
            this.lblRacunPacijenta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRacunPacijenta.Name = "lblRacunPacijenta";
            this.lblRacunPacijenta.Size = new System.Drawing.Size(62, 18);
            this.lblRacunPacijenta.TabIndex = 4;
            this.lblRacunPacijenta.Text = "Pacijent:";
            // 
            // lblIzdaoLijecnik
            // 
            this.lblIzdaoLijecnik.AutoSize = true;
            this.lblIzdaoLijecnik.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdaoLijecnik.Location = new System.Drawing.Point(95, 55);
            this.lblIzdaoLijecnik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzdaoLijecnik.Name = "lblIzdaoLijecnik";
            this.lblIzdaoLijecnik.Size = new System.Drawing.Size(80, 17);
            this.lblIzdaoLijecnik.TabIndex = 5;
            this.lblIzdaoLijecnik.Text = "IzdaoLijecnik";
            // 
            // lblIzdajePacijentu
            // 
            this.lblIzdajePacijentu.AutoSize = true;
            this.lblIzdajePacijentu.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIzdajePacijentu.Location = new System.Drawing.Point(73, 84);
            this.lblIzdajePacijentu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIzdajePacijentu.Name = "lblIzdajePacijentu";
            this.lblIzdajePacijentu.Size = new System.Drawing.Size(86, 17);
            this.lblIzdajePacijentu.TabIndex = 6;
            this.lblIzdajePacijentu.Text = "PrimaPacijent";
            // 
            // lblUkupniIznosRacuna
            // 
            this.lblUkupniIznosRacuna.AutoSize = true;
            this.lblUkupniIznosRacuna.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblUkupniIznosRacuna.Location = new System.Drawing.Point(573, 106);
            this.lblUkupniIznosRacuna.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUkupniIznosRacuna.Name = "lblUkupniIznosRacuna";
            this.lblUkupniIznosRacuna.Size = new System.Drawing.Size(136, 18);
            this.lblUkupniIznosRacuna.TabIndex = 9;
            this.lblUkupniIznosRacuna.Text = "Ukupni iznos računa:";
            // 
            // lblTrenutniIznos
            // 
            this.lblTrenutniIznos.AutoSize = true;
            this.lblTrenutniIznos.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTrenutniIznos.Location = new System.Drawing.Point(734, 108);
            this.lblTrenutniIznos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrenutniIznos.Name = "lblTrenutniIznos";
            this.lblTrenutniIznos.Size = new System.Drawing.Size(33, 17);
            this.lblTrenutniIznos.TabIndex = 10;
            this.lblTrenutniIznos.Text = "0.00";
            this.lblTrenutniIznos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValuta
            // 
            this.lblValuta.AutoSize = true;
            this.lblValuta.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValuta.Location = new System.Drawing.Point(785, 108);
            this.lblValuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValuta.Name = "lblValuta";
            this.lblValuta.Size = new System.Drawing.Size(24, 17);
            this.lblValuta.TabIndex = 11;
            this.lblValuta.Text = "KN";
            // 
            // btnSpremiRacun
            // 
            this.btnSpremiRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnSpremiRacun.FlatAppearance.BorderSize = 0;
            this.btnSpremiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRacun.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSpremiRacun.ForeColor = System.Drawing.Color.White;
            this.btnSpremiRacun.Location = new System.Drawing.Point(372, 421);
            this.btnSpremiRacun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpremiRacun.Name = "btnSpremiRacun";
            this.btnSpremiRacun.Size = new System.Drawing.Size(98, 36);
            this.btnSpremiRacun.TabIndex = 21;
            this.btnSpremiRacun.Text = "Spremi";
            this.btnSpremiRacun.UseVisualStyleBackColor = false;
            this.btnSpremiRacun.Click += new System.EventHandler(this.btnSpremiRacun_Click);
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToResizeColumns = false;
            this.dgvProizvodi.AllowUserToResizeRows = false;
            this.dgvProizvodi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProizvodi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dodaj,
            this.Naziv,
            this.Cijena,
            this.Količina});
            this.dgvProizvodi.Location = new System.Drawing.Point(10, 165);
            this.dgvProizvodi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProizvodi.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(844, 227);
            this.dgvProizvodi.TabIndex = 8;
            // 
            // Dodaj
            // 
            this.Dodaj.HeaderText = "DODAJ";
            this.Dodaj.MinimumWidth = 6;
            this.Dodaj.Name = "Dodaj";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "NAZIV";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "CIJENA";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Količina
            // 
            this.Količina.HeaderText = "KOLIČINA";
            this.Količina.MinimumWidth = 6;
            this.Količina.Name = "Količina";
            // 
            // lblProizvodi
            // 
            this.lblProizvodi.AutoSize = true;
            this.lblProizvodi.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProizvodi.Location = new System.Drawing.Point(9, 134);
            this.lblProizvodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProizvodi.Name = "lblProizvodi";
            this.lblProizvodi.Size = new System.Drawing.Size(97, 18);
            this.lblProizvodi.TabIndex = 23;
            this.lblProizvodi.Text = "Stavke računa:";
            // 
            // FrmDodajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 485);
            this.Controls.Add(this.lblProizvodi);
            this.Controls.Add(this.btnSpremiRacun);
            this.Controls.Add(this.lblValuta);
            this.Controls.Add(this.lblTrenutniIznos);
            this.Controls.Add(this.lblUkupniIznosRacuna);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.lblIzdajePacijentu);
            this.Controls.Add(this.lblIzdaoLijecnik);
            this.Controls.Add(this.lblRacunPacijenta);
            this.Controls.Add(this.lblIzdaoRacun);
            this.Controls.Add(this.lblTrenutniDatumRacuna);
            this.Controls.Add(this.lblDatumKreiranjaRacuna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmDodajRacun";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi račun";
            this.Load += new System.EventHandler(this.FrmDodajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDatumKreiranjaRacuna;
        private System.Windows.Forms.Label lblTrenutniDatumRacuna;
        private System.Windows.Forms.Label lblIzdaoRacun;
        private System.Windows.Forms.Label lblRacunPacijenta;
        private System.Windows.Forms.Label lblIzdaoLijecnik;
        private System.Windows.Forms.Label lblIzdajePacijentu;
        private System.Windows.Forms.Label lblUkupniIznosRacuna;
        private System.Windows.Forms.Label lblTrenutniIznos;
        private System.Windows.Forms.Label lblValuta;
        private System.Windows.Forms.Button btnSpremiRacun;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Label lblProizvodi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Količina;
    }
}