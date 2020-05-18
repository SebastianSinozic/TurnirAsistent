namespace AsistentGUI
{
    partial class PregledTurnira
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
            this.lblTurnir = new System.Windows.Forms.Label();
            this.lblNazivTurnira = new System.Windows.Forms.Label();
            this.lblRunda = new System.Windows.Forms.Label();
            this.cmbRunde = new System.Windows.Forms.ComboBox();
            this.lstParovi = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblPrvaEkipa = new System.Windows.Forms.Label();
            this.lblRezultat = new System.Windows.Forms.Label();
            this.txtRezultatPrveEkipe = new System.Windows.Forms.TextBox();
            this.txtDrugeEkipe = new System.Windows.Forms.TextBox();
            this.lblRezultatDrugeEkipe = new System.Windows.Forms.Label();
            this.lblDrugaEkipa = new System.Windows.Forms.Label();
            this.lblVS = new System.Windows.Forms.Label();
            this.btnSpremiRezultat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTurnir
            // 
            this.lblTurnir.AutoSize = true;
            this.lblTurnir.BackColor = System.Drawing.Color.Orange;
            this.lblTurnir.Font = new System.Drawing.Font("Times New Roman", 34F);
            this.lblTurnir.Location = new System.Drawing.Point(58, 18);
            this.lblTurnir.Name = "lblTurnir";
            this.lblTurnir.Size = new System.Drawing.Size(151, 53);
            this.lblTurnir.TabIndex = 0;
            this.lblTurnir.Text = "Turnir:";
            this.lblTurnir.Click += new System.EventHandler(this.lblTurnir_Click);
            // 
            // lblNazivTurnira
            // 
            this.lblNazivTurnira.AutoSize = true;
            this.lblNazivTurnira.BackColor = System.Drawing.Color.Orange;
            this.lblNazivTurnira.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazivTurnira.Location = new System.Drawing.Point(236, 31);
            this.lblNazivTurnira.Name = "lblNazivTurnira";
            this.lblNazivTurnira.Size = new System.Drawing.Size(118, 36);
            this.lblNazivTurnira.TabIndex = 1;
            this.lblNazivTurnira.Text = "<naziv>";
            this.lblNazivTurnira.Click += new System.EventHandler(this.lblNazivTurnira_Click);
            // 
            // lblRunda
            // 
            this.lblRunda.AutoSize = true;
            this.lblRunda.BackColor = System.Drawing.Color.White;
            this.lblRunda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRunda.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblRunda.Location = new System.Drawing.Point(64, 93);
            this.lblRunda.Name = "lblRunda";
            this.lblRunda.Size = new System.Drawing.Size(94, 33);
            this.lblRunda.TabIndex = 2;
            this.lblRunda.Text = "Runda:";
            this.lblRunda.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbRunde
            // 
            this.cmbRunde.FormattingEnabled = true;
            this.cmbRunde.Location = new System.Drawing.Point(235, 99);
            this.cmbRunde.Name = "cmbRunde";
            this.cmbRunde.Size = new System.Drawing.Size(196, 28);
            this.cmbRunde.TabIndex = 3;
            // 
            // lstParovi
            // 
            this.lstParovi.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lstParovi.FormattingEnabled = true;
            this.lstParovi.ItemHeight = 31;
            this.lstParovi.Location = new System.Drawing.Point(63, 221);
            this.lstParovi.Name = "lstParovi";
            this.lstParovi.Size = new System.Drawing.Size(395, 252);
            this.lstParovi.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Orange;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.checkBox1.Location = new System.Drawing.Point(63, 153);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(291, 30);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Prikaži neodigrane utakmice";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblPrvaEkipa
            // 
            this.lblPrvaEkipa.AutoSize = true;
            this.lblPrvaEkipa.BackColor = System.Drawing.Color.Red;
            this.lblPrvaEkipa.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblPrvaEkipa.Location = new System.Drawing.Point(484, 221);
            this.lblPrvaEkipa.Name = "lblPrvaEkipa";
            this.lblPrvaEkipa.Size = new System.Drawing.Size(154, 31);
            this.lblPrvaEkipa.TabIndex = 7;
            this.lblPrvaEkipa.Text = "<prvaEkipa>";
            // 
            // lblRezultat
            // 
            this.lblRezultat.AutoSize = true;
            this.lblRezultat.BackColor = System.Drawing.Color.Orange;
            this.lblRezultat.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblRezultat.Location = new System.Drawing.Point(485, 274);
            this.lblRezultat.Name = "lblRezultat";
            this.lblRezultat.Size = new System.Drawing.Size(98, 27);
            this.lblRezultat.TabIndex = 8;
            this.lblRezultat.Text = "Rezultat:";
            // 
            // txtRezultatPrveEkipe
            // 
            this.txtRezultatPrveEkipe.Location = new System.Drawing.Point(608, 276);
            this.txtRezultatPrveEkipe.Name = "txtRezultatPrveEkipe";
            this.txtRezultatPrveEkipe.Size = new System.Drawing.Size(177, 29);
            this.txtRezultatPrveEkipe.TabIndex = 9;
            // 
            // txtDrugeEkipe
            // 
            this.txtDrugeEkipe.Location = new System.Drawing.Point(608, 461);
            this.txtDrugeEkipe.Name = "txtDrugeEkipe";
            this.txtDrugeEkipe.Size = new System.Drawing.Size(177, 29);
            this.txtDrugeEkipe.TabIndex = 12;
            // 
            // lblRezultatDrugeEkipe
            // 
            this.lblRezultatDrugeEkipe.AutoSize = true;
            this.lblRezultatDrugeEkipe.BackColor = System.Drawing.Color.Orange;
            this.lblRezultatDrugeEkipe.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.lblRezultatDrugeEkipe.Location = new System.Drawing.Point(485, 459);
            this.lblRezultatDrugeEkipe.Name = "lblRezultatDrugeEkipe";
            this.lblRezultatDrugeEkipe.Size = new System.Drawing.Size(98, 27);
            this.lblRezultatDrugeEkipe.TabIndex = 11;
            this.lblRezultatDrugeEkipe.Text = "Rezultat:";
            // 
            // lblDrugaEkipa
            // 
            this.lblDrugaEkipa.AutoSize = true;
            this.lblDrugaEkipa.BackColor = System.Drawing.Color.Aqua;
            this.lblDrugaEkipa.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblDrugaEkipa.Location = new System.Drawing.Point(484, 407);
            this.lblDrugaEkipa.Name = "lblDrugaEkipa";
            this.lblDrugaEkipa.Size = new System.Drawing.Size(168, 31);
            this.lblDrugaEkipa.TabIndex = 10;
            this.lblDrugaEkipa.Text = "<drugaEkipa>";
            // 
            // lblVS
            // 
            this.lblVS.AutoSize = true;
            this.lblVS.BackColor = System.Drawing.Color.Orange;
            this.lblVS.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVS.Location = new System.Drawing.Point(545, 338);
            this.lblVS.Name = "lblVS";
            this.lblVS.Size = new System.Drawing.Size(66, 31);
            this.lblVS.TabIndex = 13;
            this.lblVS.Text = "-VS-";
            // 
            // btnSpremiRezultat
            // 
            this.btnSpremiRezultat.BackColor = System.Drawing.Color.Brown;
            this.btnSpremiRezultat.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnSpremiRezultat.FlatAppearance.BorderSize = 2;
            this.btnSpremiRezultat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnSpremiRezultat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnSpremiRezultat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpremiRezultat.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.btnSpremiRezultat.ForeColor = System.Drawing.Color.White;
            this.btnSpremiRezultat.Location = new System.Drawing.Point(821, 452);
            this.btnSpremiRezultat.Name = "btnSpremiRezultat";
            this.btnSpremiRezultat.Size = new System.Drawing.Size(310, 88);
            this.btnSpremiRezultat.TabIndex = 14;
            this.btnSpremiRezultat.Text = "Spremi";
            this.btnSpremiRezultat.UseVisualStyleBackColor = false;
            this.btnSpremiRezultat.Click += new System.EventHandler(this.btnSpremiRezultat_Click);
            // 
            // PregledTurnira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1143, 552);
            this.Controls.Add(this.btnSpremiRezultat);
            this.Controls.Add(this.lblVS);
            this.Controls.Add(this.txtDrugeEkipe);
            this.Controls.Add(this.lblRezultatDrugeEkipe);
            this.Controls.Add(this.lblDrugaEkipa);
            this.Controls.Add(this.txtRezultatPrveEkipe);
            this.Controls.Add(this.lblRezultat);
            this.Controls.Add(this.lblPrvaEkipa);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lstParovi);
            this.Controls.Add(this.cmbRunde);
            this.Controls.Add(this.lblRunda);
            this.Controls.Add(this.lblNazivTurnira);
            this.Controls.Add(this.lblTurnir);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PregledTurnira";
            this.Text = "Pregled Turnira";
            this.Load += new System.EventHandler(this.PregledTurnira_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnir;
        private System.Windows.Forms.Label lblNazivTurnira;
        private System.Windows.Forms.Label lblRunda;
        private System.Windows.Forms.ComboBox cmbRunde;
        private System.Windows.Forms.ListBox lstParovi;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblPrvaEkipa;
        private System.Windows.Forms.Label lblRezultat;
        private System.Windows.Forms.TextBox txtRezultatPrveEkipe;
        private System.Windows.Forms.TextBox txtDrugeEkipe;
        private System.Windows.Forms.Label lblRezultatDrugeEkipe;
        private System.Windows.Forms.Label lblDrugaEkipa;
        private System.Windows.Forms.Label lblVS;
        private System.Windows.Forms.Button btnSpremiRezultat;
    }
}

