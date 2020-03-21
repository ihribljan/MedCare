namespace MedCare
{
    partial class FrmPopisNarudzbenica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPopisNarudzbenica));
            this.dgvSveNarudzbenice = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoslovniPartneriId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZaposleniciId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.narudžbeniceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._19059_DBDataSet2 = new MedCare._19059_DBDataSet();
            this.btnGeneriraj = new System.Windows.Forms.Button();
            this.narudžbeniceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbeniceTableAdapter = new MedCare._19059_DBDataSetTableAdapters.NarudžbeniceTableAdapter();
            this.fKNarudžbenNarud797309D9BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.narudžbenicaStavkeTableAdapter = new MedCare._19059_DBDataSetTableAdapters.NarudžbenicaStavkeTableAdapter();
            this.narudžbeniceTableAdapter1 = new MedCare._19059_DBDataSetTableAdapters.NarudžbeniceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbenice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNarudžbenNarud797309D9BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSveNarudzbenice
            // 
            this.dgvSveNarudzbenice.AutoGenerateColumns = false;
            this.dgvSveNarudzbenice.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSveNarudzbenice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSveNarudzbenice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSveNarudzbenice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.Datum,
            this.PoslovniPartneriId,
            this.ZaposleniciId,
            this.Iznos});
            this.dgvSveNarudzbenice.DataSource = this.narudžbeniceBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSveNarudzbenice.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSveNarudzbenice.Location = new System.Drawing.Point(12, 12);
            this.dgvSveNarudzbenice.Name = "dgvSveNarudzbenice";
            this.dgvSveNarudzbenice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSveNarudzbenice.Size = new System.Drawing.Size(776, 326);
            this.dgvSveNarudzbenice.TabIndex = 0;
            this.dgvSveNarudzbenice.SelectionChanged += new System.EventHandler(this.dgvSveNarudzbenice_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "DATUM";
            this.Datum.Name = "Datum";
            this.Datum.Width = 150;
            // 
            // PoslovniPartneriId
            // 
            this.PoslovniPartneriId.DataPropertyName = "PoslovniPartner";
            this.PoslovniPartneriId.HeaderText = "POSLOVNI PARTNER";
            this.PoslovniPartneriId.Name = "PoslovniPartneriId";
            this.PoslovniPartneriId.Width = 215;
            // 
            // ZaposleniciId
            // 
            this.ZaposleniciId.DataPropertyName = "Zaposlenik";
            this.ZaposleniciId.HeaderText = "ZAPOSLENIK";
            this.ZaposleniciId.Name = "ZaposleniciId";
            this.ZaposleniciId.Width = 150;
            // 
            // Iznos
            // 
            this.Iznos.DataPropertyName = "Iznos";
            this.Iznos.HeaderText = "IZNOS";
            this.Iznos.Name = "Iznos";
            // 
            // narudžbeniceBindingSource1
            // 
            this.narudžbeniceBindingSource1.DataMember = "Narudžbenice";
            this.narudžbeniceBindingSource1.DataSource = this._19059_DBDataSet2;
            // 
            // _19059_DBDataSet2
            // 
            this._19059_DBDataSet2.DataSetName = "_19059_DBDataSet";
            this._19059_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnGeneriraj
            // 
            this.btnGeneriraj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGeneriraj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnGeneriraj.FlatAppearance.BorderSize = 0;
            this.btnGeneriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeneriraj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnGeneriraj.ForeColor = System.Drawing.Color.White;
            this.btnGeneriraj.Location = new System.Drawing.Point(659, 352);
            this.btnGeneriraj.Margin = new System.Windows.Forms.Padding(2);
            this.btnGeneriraj.Name = "btnGeneriraj";
            this.btnGeneriraj.Size = new System.Drawing.Size(129, 30);
            this.btnGeneriraj.TabIndex = 29;
            this.btnGeneriraj.Text = "&Ispiši";
            this.btnGeneriraj.UseVisualStyleBackColor = false;
            this.btnGeneriraj.Click += new System.EventHandler(this.btnGeneriraj_Click);
            // 
            // _19059_DBDataSet
            // 
            this._19059_DBDataSet2.DataSetName = "_19059_DBDataSet";
            this._19059_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // narudžbeniceBindingSource
            // 
            this.narudžbeniceBindingSource.DataMember = "Narudžbenice";
            this.narudžbeniceBindingSource.DataSource = this._19059_DBDataSet2;
            // 
            // narudžbeniceTableAdapter
            // 
            this.narudžbeniceTableAdapter.ClearBeforeFill = true;
            // 
            // fKNarudžbenNarud797309D9BindingSource
            // 
            this.fKNarudžbenNarud797309D9BindingSource.DataMember = "FK__Narudžben__Narud__797309D9";
            this.fKNarudžbenNarud797309D9BindingSource.DataSource = this.narudžbeniceBindingSource;
            // 
            // narudžbenicaStavkeTableAdapter
            // 
            this.narudžbenicaStavkeTableAdapter.ClearBeforeFill = true;
            // 
            // narudžbeniceTableAdapter1
            // 
            this.narudžbeniceTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmPopisNarudzbenica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.btnGeneriraj);
            this.Controls.Add(this.dgvSveNarudzbenice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPopisNarudzbenica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popis narudžbenica";
            this.Load += new System.EventHandler(this.FrmSveNarudzbenice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSveNarudzbenice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.narudžbeniceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKNarudžbenNarud797309D9BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSveNarudzbenice;
        private System.Windows.Forms.Button btnGeneriraj;
        private _19059_DBDataSet _19059_DBDataSet2;
        private System.Windows.Forms.BindingSource narudžbeniceBindingSource;
        private _19059_DBDataSetTableAdapters.NarudžbeniceTableAdapter narudžbeniceTableAdapter;
        private System.Windows.Forms.BindingSource fKNarudžbenNarud797309D9BindingSource;
        private _19059_DBDataSetTableAdapters.NarudžbenicaStavkeTableAdapter narudžbenicaStavkeTableAdapter;
        private _19059_DBDataSet _19059_DBDataSet3;
        private System.Windows.Forms.BindingSource narudžbeniceBindingSource1;
        private _19059_DBDataSetTableAdapters.NarudžbeniceTableAdapter narudžbeniceTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoslovniPartneriId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZaposleniciId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iznos;
    }
}