namespace MedCare
{
    partial class ucSkladiste
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSkladiste = new System.Windows.Forms.DataGridView();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaSkladisteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._19059_DBDataSet2 = new MedCare._19059_DBDataSet();
            this.proizvodiTableAdapter = new MedCare._19059_DBDataSetTableAdapters.ProizvodiTableAdapter();
            this.btnNovaNarudzbenica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Skladište";
            // 
            // dgvSkladiste
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvSkladiste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSkladiste.AutoGenerateColumns = false;
            this.dgvSkladiste.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkladiste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSkladiste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladiste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaSkladisteDataGridViewTextBoxColumn});
            this.dgvSkladiste.DataSource = this.proizvodiBindingSource;
            this.dgvSkladiste.Location = new System.Drawing.Point(8, 55);
            this.dgvSkladiste.Name = "dgvSkladiste";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSkladiste.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.dgvSkladiste.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSkladiste.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladiste.Size = new System.Drawing.Size(922, 255);
            this.dgvSkladiste.TabIndex = 5;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "NAZIV";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 400;
            // 
            // kolicinaSkladisteDataGridViewTextBoxColumn
            // 
            this.kolicinaSkladisteDataGridViewTextBoxColumn.DataPropertyName = "KolicinaSkladiste";
            this.kolicinaSkladisteDataGridViewTextBoxColumn.HeaderText = "KOLIČINA NA SKLADIŠTU";
            this.kolicinaSkladisteDataGridViewTextBoxColumn.Name = "kolicinaSkladisteDataGridViewTextBoxColumn";
            this.kolicinaSkladisteDataGridViewTextBoxColumn.Width = 479;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "Proizvodi";
            this.proizvodiBindingSource.DataSource = this.dBDataSet2BindingSource;
            // 
            // dBDataSet2BindingSource
            // 
            this.dBDataSet2BindingSource.DataSource = this._19059_DBDataSet2;
            this.dBDataSet2BindingSource.Position = 0;
            // 
            // _19059_DBDataSet2
            // 
            this._19059_DBDataSet2.DataSetName = "_19059_DBDataSet2";
            this._19059_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // btnNovaNarudzbenica
            // 
            this.btnNovaNarudzbenica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNovaNarudzbenica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnNovaNarudzbenica.FlatAppearance.BorderSize = 0;
            this.btnNovaNarudzbenica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaNarudzbenica.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaNarudzbenica.ForeColor = System.Drawing.Color.White;
            this.btnNovaNarudzbenica.Location = new System.Drawing.Point(780, 327);
            this.btnNovaNarudzbenica.Margin = new System.Windows.Forms.Padding(2);
            this.btnNovaNarudzbenica.Name = "btnNovaNarudzbenica";
            this.btnNovaNarudzbenica.Size = new System.Drawing.Size(150, 40);
            this.btnNovaNarudzbenica.TabIndex = 6;
            this.btnNovaNarudzbenica.Text = "Nova narudžbenica";
            this.btnNovaNarudzbenica.UseVisualStyleBackColor = false;
            this.btnNovaNarudzbenica.Click += new System.EventHandler(this.btnNovaNarudzbenica_Click);
            // 
            // ucSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnNovaNarudzbenica);
            this.Controls.Add(this.dgvSkladiste);
            this.Controls.Add(this.label1);
            this.Name = "ucSkladiste";
            this.Size = new System.Drawing.Size(944, 589);
            this.Load += new System.EventHandler(this.ucSkladiste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._19059_DBDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSkladiste;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaSkladisteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private System.Windows.Forms.BindingSource dBDataSet2BindingSource;
        private _19059_DBDataSet _19059_DBDataSet2;
        private _19059_DBDataSetTableAdapters.ProizvodiTableAdapter proizvodiTableAdapter;
        private System.Windows.Forms.Button btnNovaNarudzbenica;
    }
}
