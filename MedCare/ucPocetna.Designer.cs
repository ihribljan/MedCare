namespace MedCare
{
    partial class ucPocetna
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.card_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_dodaj_narudzbu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.monthCalendar1.Location = new System.Drawing.Point(690, 58);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(7);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // card_panel
            // 
            this.card_panel.AutoScroll = true;
            this.card_panel.Location = new System.Drawing.Point(10, 58);
            this.card_panel.Margin = new System.Windows.Forms.Padding(2);
            this.card_panel.Name = "card_panel";
            this.card_panel.Size = new System.Drawing.Size(639, 514);
            this.card_panel.TabIndex = 1;
            // 
            // btn_dodaj_narudzbu
            // 
            this.btn_dodaj_narudzbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(213)))), ((int)(((byte)(115)))));
            this.btn_dodaj_narudzbu.FlatAppearance.BorderSize = 0;
            this.btn_dodaj_narudzbu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(255)))), ((int)(((byte)(130)))));
            this.btn_dodaj_narudzbu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(230)))), ((int)(((byte)(115)))));
            this.btn_dodaj_narudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dodaj_narudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dodaj_narudzbu.ForeColor = System.Drawing.Color.White;
            this.btn_dodaj_narudzbu.Location = new System.Drawing.Point(691, 528);
            this.btn_dodaj_narudzbu.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dodaj_narudzbu.Name = "btn_dodaj_narudzbu";
            this.btn_dodaj_narudzbu.Size = new System.Drawing.Size(198, 44);
            this.btn_dodaj_narudzbu.TabIndex = 2;
            this.btn_dodaj_narudzbu.Text = "Nova narudžba";
            this.btn_dodaj_narudzbu.UseVisualStyleBackColor = false;
            this.btn_dodaj_narudzbu.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Raspored narudžbi";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(684, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum:";
            // 
            // ucPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_dodaj_narudzbu);
            this.Controls.Add(this.card_panel);
            this.Controls.Add(this.monthCalendar1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ucPocetna";
            this.Size = new System.Drawing.Size(944, 589);
            this.Load += new System.EventHandler(this.ucPocetna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.FlowLayoutPanel card_panel;
        private System.Windows.Forms.Button btn_dodaj_narudzbu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
