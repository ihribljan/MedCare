namespace MedCare
{
    partial class ucPacijenti
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

        #region Component Designer generated code

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPacijenti = new System.Windows.Forms.TabControl();
            this.tpPacijenti = new System.Windows.Forms.TabPage();
            this.btnObrisiPacijenta = new System.Windows.Forms.Button();
            this.btnNoviPacijent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPretrazi = new System.Windows.Forms.TextBox();
            this.lblPretrazivanje = new System.Windows.Forms.Label();
            this.dgvListaPacijenata = new System.Windows.Forms.DataGridView();
            this.Oib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpDijagnoze = new System.Windows.Forms.TabPage();
            this.btnDodajDijagnozu = new System.Windows.Forms.Button();
            this.dgvDijagnoze = new System.Windows.Forms.DataGridView();
            this.dijagnozeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19059_DBDataSet = new MedCare._19059_DBDataSet();
            this.tpTerapije = new System.Windows.Forms.TabPage();
            this.btnDodajTerapiju = new System.Windows.Forms.Button();
            this.dgvTerapije = new System.Windows.Forms.DataGridView();
            this.terapijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpRacuni = new System.Windows.Forms.TabPage();
            this.btnGenerirajRacun = new System.Windows.Forms.Button();
            this.btnObrisiRacun = new System.Windows.Forms.Button();
            this.btnNoviRacun = new System.Windows.Forms.Button();
            this.dgvRacuni = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dijagnozeTableAdapter = new MedCare._19059_DBDataSetTableAdapters.DijagnozeTableAdapter();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacijentiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BolestiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Napomena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DijagnozeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProizvodiId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preporukaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPacijenti.SuspendLayout();
            this.tpPacijenti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacijenata)).BeginInit();
            this.tpDijagnoze.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet)).BeginInit();
            this.tpTerapije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerapije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapijeBindingSource)).BeginInit();
            this.tpRacuni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPacijenti
            // 
            this.tcPacijenti.Controls.Add(this.tpPacijenti);
            this.tcPacijenti.Controls.Add(this.tpDijagnoze);
            this.tcPacijenti.Controls.Add(this.tpTerapije);
            this.tcPacijenti.Controls.Add(this.tpRacuni);
            this.tcPacijenti.ItemSize = new System.Drawing.Size(100, 25);
            this.tcPacijenti.Location = new System.Drawing.Point(-2, 3);
            this.tcPacijenti.Margin = new System.Windows.Forms.Padding(2);
            this.tcPacijenti.Name = "tcPacijenti";
            this.tcPacijenti.SelectedIndex = 0;
            this.tcPacijenti.Size = new System.Drawing.Size(938, 583);
            this.tcPacijenti.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcPacijenti.TabIndex = 0;
            this.tcPacijenti.SelectedIndexChanged += new System.EventHandler(this.tcPacijenti_SelectedIndexChanged);
            // 
            // tpPacijenti
            // 
            this.tpPacijenti.Controls.Add(this.btnObrisiPacijenta);
            this.tpPacijenti.Controls.Add(this.btnNoviPacijent);
            this.tpPacijenti.Controls.Add(this.panel2);
            this.tpPacijenti.Controls.Add(this.panel1);
            this.tpPacijenti.Controls.Add(this.txtPretrazi);
            this.tpPacijenti.Controls.Add(this.lblPretrazivanje);
            this.tpPacijenti.Controls.Add(this.dgvListaPacijenata);
            this.tpPacijenti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tpPacijenti.Location = new System.Drawing.Point(4, 29);
            this.tpPacijenti.Margin = new System.Windows.Forms.Padding(2);
            this.tpPacijenti.Name = "tpPacijenti";
            this.tpPacijenti.Padding = new System.Windows.Forms.Padding(2);
            this.tpPacijenti.Size = new System.Drawing.Size(930, 550);
            this.tpPacijenti.TabIndex = 0;
            this.tpPacijenti.Text = "Pacijenti";
            this.tpPacijenti.UseVisualStyleBackColor = true;
            // 
            // btnObrisiPacijenta
            // 
            this.btnObrisiPacijenta.BackColor = System.Drawing.Color.Red;
            this.btnObrisiPacijenta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiPacijenta.FlatAppearance.BorderSize = 0;
            this.btnObrisiPacijenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiPacijenta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiPacijenta.ForeColor = System.Drawing.Color.White;
            this.btnObrisiPacijenta.Location = new System.Drawing.Point(130, 325);
            this.btnObrisiPacijenta.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiPacijenta.Name = "btnObrisiPacijenta";
            this.btnObrisiPacijenta.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiPacijenta.TabIndex = 6;
            this.btnObrisiPacijenta.Text = "Obriši pacijenta";
            this.btnObrisiPacijenta.UseVisualStyleBackColor = false;
            this.btnObrisiPacijenta.Click += new System.EventHandler(this.btnObrisiPacijenta_Click);
            // 
            // btnNoviPacijent
            // 
            this.btnNoviPacijent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviPacijent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviPacijent.FlatAppearance.BorderSize = 0;
            this.btnNoviPacijent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviPacijent.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviPacijent.ForeColor = System.Drawing.Color.White;
            this.btnNoviPacijent.Location = new System.Drawing.Point(15, 325);
            this.btnNoviPacijent.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviPacijent.Name = "btnNoviPacijent";
            this.btnNoviPacijent.Size = new System.Drawing.Size(100, 35);
            this.btnNoviPacijent.TabIndex = 5;
            this.btnNoviPacijent.Text = "Dodaj pacijenta";
            this.btnNoviPacijent.UseVisualStyleBackColor = false;
            this.btnNoviPacijent.Click += new System.EventHandler(this.btnNoviPacijent_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(755, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 1);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(755, 350);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 1);
            this.panel1.TabIndex = 3;
            // 
            // txtPretrazi
            // 
            this.txtPretrazi.BackColor = System.Drawing.SystemColors.Window;
            this.txtPretrazi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPretrazi.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPretrazi.Location = new System.Drawing.Point(755, 330);
            this.txtPretrazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtPretrazi.Name = "txtPretrazi";
            this.txtPretrazi.Size = new System.Drawing.Size(166, 13);
            this.txtPretrazi.TabIndex = 2;
            this.txtPretrazi.TextChanged += new System.EventHandler(this.txtPretrazi_TextChanged);
            // 
            // lblPretrazivanje
            // 
            this.lblPretrazivanje.AutoSize = true;
            this.lblPretrazivanje.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPretrazivanje.Location = new System.Drawing.Point(694, 330);
            this.lblPretrazivanje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPretrazivanje.Name = "lblPretrazivanje";
            this.lblPretrazivanje.Size = new System.Drawing.Size(57, 17);
            this.lblPretrazivanje.TabIndex = 1;
            this.lblPretrazivanje.Text = "Pretraži:";
            // 
            // dgvListaPacijenata
            // 
            this.dgvListaPacijenata.AllowUserToResizeColumns = false;
            this.dgvListaPacijenata.AllowUserToResizeRows = false;
            this.dgvListaPacijenata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaPacijenata.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListaPacijenata.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaPacijenata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListaPacijenata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPacijenata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Oib,
            this.Ime,
            this.Prezime,
            this.DatumRodenja,
            this.Adresa,
            this.Kontakt,
            this.Email,
            this.Spol});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaPacijenata.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListaPacijenata.Location = new System.Drawing.Point(5, 6);
            this.dgvListaPacijenata.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaPacijenata.Name = "dgvListaPacijenata";
            this.dgvListaPacijenata.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvListaPacijenata.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaPacijenata.RowTemplate.Height = 24;
            this.dgvListaPacijenata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPacijenata.Size = new System.Drawing.Size(922, 303);
            this.dgvListaPacijenata.TabIndex = 0;
            this.dgvListaPacijenata.SelectionChanged += new System.EventHandler(this.dgvListaPacijenata_SelectionChanged);
            // 
            // Oib
            // 
            this.Oib.DataPropertyName = "Oib";
            this.Oib.FillWeight = 86.08327F;
            this.Oib.HeaderText = "OIB";
            this.Oib.Name = "Oib";
            this.Oib.ReadOnly = true;
            // 
            // Ime
            // 
            this.Ime.DataPropertyName = "Ime";
            this.Ime.FillWeight = 108.8338F;
            this.Ime.HeaderText = "IME";
            this.Ime.Name = "Ime";
            this.Ime.ReadOnly = true;
            // 
            // Prezime
            // 
            this.Prezime.DataPropertyName = "Prezime";
            this.Prezime.FillWeight = 108.8338F;
            this.Prezime.HeaderText = "PREZIME";
            this.Prezime.Name = "Prezime";
            this.Prezime.ReadOnly = true;
            // 
            // DatumRodenja
            // 
            this.DatumRodenja.DataPropertyName = "DatumRođenja";
            this.DatumRodenja.FillWeight = 108.8338F;
            this.DatumRodenja.HeaderText = "DATUM ROĐENJA";
            this.DatumRodenja.Name = "DatumRodenja";
            this.DatumRodenja.ReadOnly = true;
            // 
            // Adresa
            // 
            this.Adresa.DataPropertyName = "Adresa";
            this.Adresa.FillWeight = 108.8338F;
            this.Adresa.HeaderText = "ADRESA";
            this.Adresa.Name = "Adresa";
            this.Adresa.ReadOnly = true;
            // 
            // Kontakt
            // 
            this.Kontakt.DataPropertyName = "Kontakt";
            this.Kontakt.FillWeight = 108.8338F;
            this.Kontakt.HeaderText = "KONTAKT";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 108.8338F;
            this.Email.HeaderText = "EMAIL";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Spol
            // 
            this.Spol.DataPropertyName = "Spol";
            this.Spol.FillWeight = 60.9137F;
            this.Spol.HeaderText = "SPOL";
            this.Spol.Name = "Spol";
            this.Spol.ReadOnly = true;
            // 
            // tpDijagnoze
            // 
            this.tpDijagnoze.Controls.Add(this.btnDodajDijagnozu);
            this.tpDijagnoze.Controls.Add(this.dgvDijagnoze);
            this.tpDijagnoze.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tpDijagnoze.Location = new System.Drawing.Point(4, 29);
            this.tpDijagnoze.Margin = new System.Windows.Forms.Padding(2);
            this.tpDijagnoze.Name = "tpDijagnoze";
            this.tpDijagnoze.Padding = new System.Windows.Forms.Padding(2);
            this.tpDijagnoze.Size = new System.Drawing.Size(930, 550);
            this.tpDijagnoze.TabIndex = 2;
            this.tpDijagnoze.Text = "Dijagnoze";
            this.tpDijagnoze.UseVisualStyleBackColor = true;
            // 
            // btnDodajDijagnozu
            // 
            this.btnDodajDijagnozu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajDijagnozu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajDijagnozu.FlatAppearance.BorderSize = 0;
            this.btnDodajDijagnozu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDijagnozu.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDijagnozu.ForeColor = System.Drawing.Color.White;
            this.btnDodajDijagnozu.Location = new System.Drawing.Point(15, 325);
            this.btnDodajDijagnozu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajDijagnozu.Name = "btnDodajDijagnozu";
            this.btnDodajDijagnozu.Size = new System.Drawing.Size(100, 35);
            this.btnDodajDijagnozu.TabIndex = 6;
            this.btnDodajDijagnozu.Text = "Dodaj dijagnozu";
            this.btnDodajDijagnozu.UseVisualStyleBackColor = false;
            this.btnDodajDijagnozu.Click += new System.EventHandler(this.btnDodajDijagnozu_Click);
            // 
            // dgvDijagnoze
            // 
            this.dgvDijagnoze.AutoGenerateColumns = false;
            this.dgvDijagnoze.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDijagnoze.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDijagnoze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijagnoze.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.ZaposleniciId,
            this.PacijentiId,
            this.BolestiId,
            this.Napomena});
            this.dgvDijagnoze.DataSource = this.dijagnozeBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDijagnoze.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDijagnoze.Location = new System.Drawing.Point(5, 5);
            this.dgvDijagnoze.Name = "dgvDijagnoze";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvDijagnoze.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDijagnoze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDijagnoze.Size = new System.Drawing.Size(922, 303);
            this.dgvDijagnoze.TabIndex = 0;
            this.dgvDijagnoze.SelectionChanged += new System.EventHandler(this.dgvDijagnoze_SelectionChanged);
            // 
            // dijagnozeBindingSource
            // 
            this.dijagnozeBindingSource.DataMember = "Dijagnoze";
            this.dijagnozeBindingSource.DataSource = this._19059_DBDataSet;
            // 
            // _19059_DBDataSet
            // 
            this._19059_DBDataSet.DataSetName = "_19059_DBDataSet";
            this._19059_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpTerapije
            // 
            this.tpTerapije.Controls.Add(this.btnDodajTerapiju);
            this.tpTerapije.Controls.Add(this.dgvTerapije);
            this.tpTerapije.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tpTerapije.Location = new System.Drawing.Point(4, 29);
            this.tpTerapije.Margin = new System.Windows.Forms.Padding(2);
            this.tpTerapije.Name = "tpTerapije";
            this.tpTerapije.Padding = new System.Windows.Forms.Padding(2);
            this.tpTerapije.Size = new System.Drawing.Size(930, 550);
            this.tpTerapije.TabIndex = 3;
            this.tpTerapije.Text = "Terapije";
            this.tpTerapije.UseVisualStyleBackColor = true;
            // 
            // btnDodajTerapiju
            // 
            this.btnDodajTerapiju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajTerapiju.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajTerapiju.FlatAppearance.BorderSize = 0;
            this.btnDodajTerapiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajTerapiju.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTerapiju.ForeColor = System.Drawing.Color.White;
            this.btnDodajTerapiju.Location = new System.Drawing.Point(15, 325);
            this.btnDodajTerapiju.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajTerapiju.Name = "btnDodajTerapiju";
            this.btnDodajTerapiju.Size = new System.Drawing.Size(100, 35);
            this.btnDodajTerapiju.TabIndex = 7;
            this.btnDodajTerapiju.Text = "Dodaj terapiju";
            this.btnDodajTerapiju.UseVisualStyleBackColor = false;
            this.btnDodajTerapiju.Click += new System.EventHandler(this.btnDodajTerapiju_Click);
            // 
            // dgvTerapije
            // 
            this.dgvTerapije.AutoGenerateColumns = false;
            this.dgvTerapije.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerapije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTerapije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTerapije.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DijagnozeId,
            this.ProizvodiId,
            this.preporukaDataGridViewTextBoxColumn});
            this.dgvTerapije.DataSource = this.terapijeBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerapije.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTerapije.Location = new System.Drawing.Point(5, 5);
            this.dgvTerapije.Name = "dgvTerapije";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvTerapije.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTerapije.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerapije.Size = new System.Drawing.Size(922, 303);
            this.dgvTerapije.TabIndex = 0;
            // 
            // terapijeBindingSource
            // 
            this.terapijeBindingSource.DataMember = "Terapije";
            // 
            // _19059_DBDataSet1
            // 
            // 
            // tpRacuni
            // 
            this.tpRacuni.Controls.Add(this.btnGenerirajRacun);
            this.tpRacuni.Controls.Add(this.btnObrisiRacun);
            this.tpRacuni.Controls.Add(this.btnNoviRacun);
            this.tpRacuni.Controls.Add(this.dgvRacuni);
            this.tpRacuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpRacuni.Location = new System.Drawing.Point(4, 29);
            this.tpRacuni.Margin = new System.Windows.Forms.Padding(2);
            this.tpRacuni.Name = "tpRacuni";
            this.tpRacuni.Padding = new System.Windows.Forms.Padding(2);
            this.tpRacuni.Size = new System.Drawing.Size(930, 550);
            this.tpRacuni.TabIndex = 1;
            this.tpRacuni.Text = "Računi";
            this.tpRacuni.UseVisualStyleBackColor = true;
            // 
            // btnGenerirajRacun
            // 
            this.btnGenerirajRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGenerirajRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGenerirajRacun.FlatAppearance.BorderSize = 0;
            this.btnGenerirajRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerirajRacun.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGenerirajRacun.ForeColor = System.Drawing.Color.White;
            this.btnGenerirajRacun.Location = new System.Drawing.Point(820, 325);
            this.btnGenerirajRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerirajRacun.Name = "btnGenerirajRacun";
            this.btnGenerirajRacun.Size = new System.Drawing.Size(100, 35);
            this.btnGenerirajRacun.TabIndex = 8;
            this.btnGenerirajRacun.Text = "Generiraj račun";
            this.btnGenerirajRacun.UseVisualStyleBackColor = false;
            this.btnGenerirajRacun.Click += new System.EventHandler(this.btnGenerirajRacun_Click);
            // 
            // btnObrisiRacun
            // 
            this.btnObrisiRacun.BackColor = System.Drawing.Color.Red;
            this.btnObrisiRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnObrisiRacun.FlatAppearance.BorderSize = 0;
            this.btnObrisiRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisiRacun.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisiRacun.ForeColor = System.Drawing.Color.White;
            this.btnObrisiRacun.Location = new System.Drawing.Point(130, 325);
            this.btnObrisiRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnObrisiRacun.Name = "btnObrisiRacun";
            this.btnObrisiRacun.Size = new System.Drawing.Size(100, 35);
            this.btnObrisiRacun.TabIndex = 7;
            this.btnObrisiRacun.Text = "Obriši račun";
            this.btnObrisiRacun.UseVisualStyleBackColor = false;
            this.btnObrisiRacun.Click += new System.EventHandler(this.btnObrisiRacun_Click);
            // 
            // btnNoviRacun
            // 
            this.btnNoviRacun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviRacun.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNoviRacun.FlatAppearance.BorderSize = 0;
            this.btnNoviRacun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoviRacun.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNoviRacun.ForeColor = System.Drawing.Color.White;
            this.btnNoviRacun.Location = new System.Drawing.Point(15, 325);
            this.btnNoviRacun.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoviRacun.Name = "btnNoviRacun";
            this.btnNoviRacun.Size = new System.Drawing.Size(100, 35);
            this.btnNoviRacun.TabIndex = 6;
            this.btnNoviRacun.Text = "Dodaj račun";
            this.btnNoviRacun.UseVisualStyleBackColor = false;
            this.btnNoviRacun.Click += new System.EventHandler(this.btnNoviRacun_Click);
            // 
            // dgvRacuni
            // 
            this.dgvRacuni.AllowUserToResizeColumns = false;
            this.dgvRacuni.AllowUserToResizeRows = false;
            this.dgvRacuni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRacuni.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRacuni.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRacuni.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRacuni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRacuni.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRacuni.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRacuni.Location = new System.Drawing.Point(5, 6);
            this.dgvRacuni.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRacuni.Name = "dgvRacuni";
            this.dgvRacuni.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvRacuni.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRacuni.RowTemplate.Height = 24;
            this.dgvRacuni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRacuni.Size = new System.Drawing.Size(922, 303);
            this.dgvRacuni.TabIndex = 1;
            this.dgvRacuni.SelectionChanged += new System.EventHandler(this.dgvRacuni_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Datum";
            this.dataGridViewTextBoxColumn1.FillWeight = 86.08327F;
            this.dataGridViewTextBoxColumn1.HeaderText = "DATUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ZaposleniciId";
            this.dataGridViewTextBoxColumn2.FillWeight = 108.8338F;
            this.dataGridViewTextBoxColumn2.HeaderText = "IZDAO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Iznos";
            this.dataGridViewTextBoxColumn4.FillWeight = 108.8338F;
            this.dataGridViewTextBoxColumn4.HeaderText = "IZNOS";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dijagnozeTableAdapter
            // 
            this.dijagnozeTableAdapter.ClearBeforeFill = true;
            // 
            // terapijeTableAdapter
            // 
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "DATUM";
            this.Datum.Name = "Datum";
            this.Datum.Width = 125;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "ZaposleniciImePrezime";
            this.ZaposleniciId.HeaderText = "ZAPOSLENIK";
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.Width = 150;
            // 
            // PacijentiId
            // 
            this.PacijentiId.DataPropertyName = "PacijentiImePrezime";
            this.PacijentiId.HeaderText = "PACIJENT";
            this.PacijentiId.Name = "PacijentiId";
            this.PacijentiId.Width = 175;
            // 
            // BolestiId
            // 
            this.BolestiId.DataPropertyName = "BolestiNaziv";
            this.BolestiId.HeaderText = "BOLEST";
            this.BolestiId.Name = "BolestiId";
            this.BolestiId.Width = 150;
            // 
            // Napomena
            // 
            this.Napomena.DataPropertyName = "Napomena";
            this.Napomena.HeaderText = "NAPOMENA";
            this.Napomena.Name = "Napomena";
            this.Napomena.Width = 279;
            // 
            // DijagnozeId
            // 
            this.DijagnozeId.DataPropertyName = "DijagnozaNaziv";
            this.DijagnozeId.HeaderText = "DIJAGNOZA";
            this.DijagnozeId.Name = "DijagnozeId";
            this.DijagnozeId.Width = 293;
            // 
            // ProizvodiId
            // 
            this.ProizvodiId.DataPropertyName = "ProizvodNaziv";
            this.ProizvodiId.HeaderText = "LIJEK";
            this.ProizvodiId.Name = "ProizvodiId";
            this.ProizvodiId.Width = 293;
            // 
            // preporukaDataGridViewTextBoxColumn
            // 
            this.preporukaDataGridViewTextBoxColumn.DataPropertyName = "Preporuka";
            this.preporukaDataGridViewTextBoxColumn.HeaderText = "PREPORUKA";
            this.preporukaDataGridViewTextBoxColumn.Name = "preporukaDataGridViewTextBoxColumn";
            this.preporukaDataGridViewTextBoxColumn.Width = 293;
            // 
            // ucPacijenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcPacijenti);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPacijenti";
            this.Size = new System.Drawing.Size(944, 589);
            this.Load += new System.EventHandler(this.ucPacijenti_Load);
            this.tcPacijenti.ResumeLayout(false);
            this.tpPacijenti.ResumeLayout(false);
            this.tpPacijenti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPacijenata)).EndInit();
            this.tpDijagnoze.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnoze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dijagnozeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet)).EndInit();
            this.tpTerapije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerapije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terapijeBindingSource)).EndInit();
            this.tpRacuni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRacuni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPacijenti;
        private System.Windows.Forms.TabPage tpPacijenti;
        private System.Windows.Forms.TabPage tpRacuni;
        private System.Windows.Forms.DataGridView dgvListaPacijenata;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPretrazi;
        private System.Windows.Forms.Label lblPretrazivanje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oib;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adresa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
        private System.Windows.Forms.Button btnNoviPacijent;
        private System.Windows.Forms.Button btnObrisiPacijenta;
        private System.Windows.Forms.DataGridView dgvRacuni;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnObrisiRacun;
        private System.Windows.Forms.Button btnNoviRacun;
        private System.Windows.Forms.Button btnGenerirajRacun;
        private System.Windows.Forms.TabPage tpDijagnoze;
        private System.Windows.Forms.DataGridView dgvDijagnoze;
        private System.Windows.Forms.TabPage tpTerapije;
        private System.Windows.Forms.DataGridView dgvTerapije;
        private System.Windows.Forms.BindingSource dijagnozeBindingSource;
        private _19059_DBDataSet _19059_DBDataSet;
        private _19059_DBDataSetTableAdapters.DijagnozeTableAdapter dijagnozeTableAdapter;
        private System.Windows.Forms.BindingSource terapijeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn proizvodiIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dijagnozeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDodajDijagnozu;
        private System.Windows.Forms.Button btnDodajTerapiju;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacijentiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BolestiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Napomena;
        private System.Windows.Forms.DataGridViewTextBoxColumn DijagnozeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodiId;
        private System.Windows.Forms.DataGridViewTextBoxColumn preporukaDataGridViewTextBoxColumn;
    }
}
