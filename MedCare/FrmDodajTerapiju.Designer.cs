namespace MedCare
{
    partial class FrmDodajTerapiju
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDodajTerapiju));
            this.cmbLijek = new System.Windows.Forms.ComboBox();
            this.txtDijagnoza = new System.Windows.Forms.TextBox();
            this.btnDodajTerapiju = new System.Windows.Forms.Button();
            this.txtPreporuka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLijek
            // 
            this.cmbLijek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLijek.FormattingEnabled = true;
            this.cmbLijek.Location = new System.Drawing.Point(115, 68);
            this.cmbLijek.Name = "cmbLijek";
            this.cmbLijek.Size = new System.Drawing.Size(121, 21);
            this.cmbLijek.TabIndex = 27;
            // 
            // txtDijagnoza
            // 
            this.txtDijagnoza.Location = new System.Drawing.Point(115, 25);
            this.txtDijagnoza.Name = "txtDijagnoza";
            this.txtDijagnoza.ReadOnly = true;
            this.txtDijagnoza.Size = new System.Drawing.Size(121, 20);
            this.txtDijagnoza.TabIndex = 26;
            // 
            // btnDodajTerapiju
            // 
            this.btnDodajTerapiju.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajTerapiju.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btnDodajTerapiju.FlatAppearance.BorderSize = 0;
            this.btnDodajTerapiju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDodajTerapiju.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDodajTerapiju.ForeColor = System.Drawing.Color.White;
            this.btnDodajTerapiju.Location = new System.Drawing.Point(115, 272);
            this.btnDodajTerapiju.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajTerapiju.Name = "btnDodajTerapiju";
            this.btnDodajTerapiju.Size = new System.Drawing.Size(116, 30);
            this.btnDodajTerapiju.TabIndex = 25;
            this.btnDodajTerapiju.Text = "Dodaj";
            this.btnDodajTerapiju.UseVisualStyleBackColor = false;
            this.btnDodajTerapiju.Click += new System.EventHandler(this.btnDodajTerapiju_Click);
            // 
            // txtPreporuka
            // 
            this.txtPreporuka.Location = new System.Drawing.Point(115, 123);
            this.txtPreporuka.Multiline = true;
            this.txtPreporuka.Name = "txtPreporuka";
            this.txtPreporuka.Size = new System.Drawing.Size(162, 125);
            this.txtPreporuka.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dijagnoza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Preporuka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Lijek";
            // 
            // FrmDodajTerapiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 318);
            this.Controls.Add(this.cmbLijek);
            this.Controls.Add(this.txtDijagnoza);
            this.Controls.Add(this.btnDodajTerapiju);
            this.Controls.Add(this.txtPreporuka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDodajTerapiju";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj terapiju";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLijek;
        private System.Windows.Forms.TextBox txtDijagnoza;
        private System.Windows.Forms.Button btnDodajTerapiju;
        private System.Windows.Forms.TextBox txtPreporuka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}