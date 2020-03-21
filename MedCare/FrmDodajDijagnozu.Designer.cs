namespace MedCare
{
    partial class FrmDodajDijagnozu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajDijagnozu));
            this.btnDodajDijagnozu = new System.Windows.Forms.Button();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBolest = new System.Windows.Forms.ComboBox();
            this.txtLijecnik = new System.Windows.Forms.TextBox();
            this.txtImePacijenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnDodajDijagnozu
            // 
            this.btnDodajDijagnozu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajDijagnozu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajDijagnozu.FlatAppearance.BorderSize = 0;
            this.btnDodajDijagnozu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajDijagnozu.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajDijagnozu.ForeColor = System.Drawing.Color.White;
            this.btnDodajDijagnozu.Location = new System.Drawing.Point(245, 283);
            this.btnDodajDijagnozu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajDijagnozu.Name = "btnDodajDijagnozu";
            this.btnDodajDijagnozu.Size = new System.Drawing.Size(116, 30);
            this.btnDodajDijagnozu.TabIndex = 18;
            this.btnDodajDijagnozu.Text = "Dodaj";
            this.btnDodajDijagnozu.UseVisualStyleBackColor = false;
            this.btnDodajDijagnozu.Click += new System.EventHandler(this.btnDodajDijagnozu_Click);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(410, 122);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(162, 118);
            this.txtNapomena.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Bolest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Napomena";
            // 
            // cmbBolest
            // 
            this.cmbBolest.FormattingEnabled = true;
            this.cmbBolest.Location = new System.Drawing.Point(410, 72);
            this.cmbBolest.Name = "cmbBolest";
            this.cmbBolest.Size = new System.Drawing.Size(121, 21);
            this.cmbBolest.TabIndex = 14;
            // 
            // txtLijecnik
            // 
            this.txtLijecnik.Location = new System.Drawing.Point(110, 122);
            this.txtLijecnik.Name = "txtLijecnik";
            this.txtLijecnik.ReadOnly = true;
            this.txtLijecnik.Size = new System.Drawing.Size(121, 20);
            this.txtLijecnik.TabIndex = 13;
            // 
            // txtImePacijenta
            // 
            this.txtImePacijenta.Location = new System.Drawing.Point(110, 72);
            this.txtImePacijenta.Name = "txtImePacijenta";
            this.txtImePacijenta.ReadOnly = true;
            this.txtImePacijenta.Size = new System.Drawing.Size(121, 20);
            this.txtImePacijenta.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Liječnik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pacijent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(110, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // FrmDodajDijagnozu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 359);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDodajDijagnozu);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBolest);
            this.Controls.Add(this.txtLijecnik);
            this.Controls.Add(this.txtImePacijenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodajDijagnozu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj dijagnozu";
            this.Load += new System.EventHandler(this.FrmDodajDijagnozu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajDijagnozu;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBolest;
        private System.Windows.Forms.TextBox txtLijecnik;
        private System.Windows.Forms.TextBox txtImePacijenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}