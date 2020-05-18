namespace AsistentGUI
{
    partial class DodavanjeNagrada
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
            this.lblIzradiNagradu = new System.Windows.Forms.Label();
            this.lblMjesto = new System.Windows.Forms.Label();
            this.txtMjesto = new System.Windows.Forms.TextBox();
            this.txtNazivMjesta = new System.Windows.Forms.TextBox();
            this.lblNazivMjesta = new System.Windows.Forms.Label();
            this.txtKolicinaNagrade = new System.Windows.Forms.TextBox();
            this.lblKolicinaNagrade = new System.Windows.Forms.Label();
            this.txtPostotakNagrade = new System.Windows.Forms.TextBox();
            this.lblPostotakNagrade = new System.Windows.Forms.Label();
            this.lblIli = new System.Windows.Forms.Label();
            this.btnIzradiNagradu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIzradiNagradu
            // 
            this.lblIzradiNagradu.AutoSize = true;
            this.lblIzradiNagradu.Font = new System.Drawing.Font("Times New Roman", 34F);
            this.lblIzradiNagradu.Location = new System.Drawing.Point(96, 26);
            this.lblIzradiNagradu.Name = "lblIzradiNagradu";
            this.lblIzradiNagradu.Size = new System.Drawing.Size(288, 53);
            this.lblIzradiNagradu.TabIndex = 0;
            this.lblIzradiNagradu.Text = "Izradi nagradu";
            // 
            // lblMjesto
            // 
            this.lblMjesto.AutoSize = true;
            this.lblMjesto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMjesto.Location = new System.Drawing.Point(108, 134);
            this.lblMjesto.Name = "lblMjesto";
            this.lblMjesto.Size = new System.Drawing.Size(89, 31);
            this.lblMjesto.TabIndex = 1;
            this.lblMjesto.Text = "Mjesto";
            // 
            // txtMjesto
            // 
            this.txtMjesto.Location = new System.Drawing.Point(345, 130);
            this.txtMjesto.Name = "txtMjesto";
            this.txtMjesto.Size = new System.Drawing.Size(190, 29);
            this.txtMjesto.TabIndex = 2;
            // 
            // txtNazivMjesta
            // 
            this.txtNazivMjesta.Location = new System.Drawing.Point(345, 189);
            this.txtNazivMjesta.Name = "txtNazivMjesta";
            this.txtNazivMjesta.Size = new System.Drawing.Size(190, 29);
            this.txtNazivMjesta.TabIndex = 4;
            // 
            // lblNazivMjesta
            // 
            this.lblNazivMjesta.AutoSize = true;
            this.lblNazivMjesta.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblNazivMjesta.Location = new System.Drawing.Point(108, 189);
            this.lblNazivMjesta.Name = "lblNazivMjesta";
            this.lblNazivMjesta.Size = new System.Drawing.Size(152, 31);
            this.lblNazivMjesta.TabIndex = 3;
            this.lblNazivMjesta.Text = "Naziv mjesta";
            // 
            // txtKolicinaNagrade
            // 
            this.txtKolicinaNagrade.Location = new System.Drawing.Point(345, 248);
            this.txtKolicinaNagrade.Name = "txtKolicinaNagrade";
            this.txtKolicinaNagrade.Size = new System.Drawing.Size(190, 29);
            this.txtKolicinaNagrade.TabIndex = 6;
            // 
            // lblKolicinaNagrade
            // 
            this.lblKolicinaNagrade.AutoSize = true;
            this.lblKolicinaNagrade.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblKolicinaNagrade.Location = new System.Drawing.Point(108, 248);
            this.lblKolicinaNagrade.Name = "lblKolicinaNagrade";
            this.lblKolicinaNagrade.Size = new System.Drawing.Size(199, 31);
            this.lblKolicinaNagrade.TabIndex = 5;
            this.lblKolicinaNagrade.Text = "Količina nagrade";
            // 
            // txtPostotakNagrade
            // 
            this.txtPostotakNagrade.Location = new System.Drawing.Point(345, 400);
            this.txtPostotakNagrade.Name = "txtPostotakNagrade";
            this.txtPostotakNagrade.Size = new System.Drawing.Size(190, 29);
            this.txtPostotakNagrade.TabIndex = 8;
            this.txtPostotakNagrade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPostotakNagrade
            // 
            this.lblPostotakNagrade.AutoSize = true;
            this.lblPostotakNagrade.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblPostotakNagrade.Location = new System.Drawing.Point(108, 400);
            this.lblPostotakNagrade.Name = "lblPostotakNagrade";
            this.lblPostotakNagrade.Size = new System.Drawing.Size(200, 31);
            this.lblPostotakNagrade.TabIndex = 7;
            this.lblPostotakNagrade.Text = "Postotak nagrade";
            this.lblPostotakNagrade.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIli
            // 
            this.lblIli.AutoSize = true;
            this.lblIli.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIli.Location = new System.Drawing.Point(226, 334);
            this.lblIli.Name = "lblIli";
            this.lblIli.Size = new System.Drawing.Size(50, 25);
            this.lblIli.TabIndex = 9;
            this.lblIli.Text = "-ILI-";
            // 
            // btnIzradiNagradu
            // 
            this.btnIzradiNagradu.BackColor = System.Drawing.Color.Brown;
            this.btnIzradiNagradu.Font = new System.Drawing.Font("Times New Roman", 22F);
            this.btnIzradiNagradu.ForeColor = System.Drawing.Color.White;
            this.btnIzradiNagradu.Location = new System.Drawing.Point(651, 415);
            this.btnIzradiNagradu.Name = "btnIzradiNagradu";
            this.btnIzradiNagradu.Size = new System.Drawing.Size(373, 116);
            this.btnIzradiNagradu.TabIndex = 10;
            this.btnIzradiNagradu.Text = "Izradi nagradu";
            this.btnIzradiNagradu.UseVisualStyleBackColor = false;
            // 
            // DodavanjeNagrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(1036, 543);
            this.Controls.Add(this.btnIzradiNagradu);
            this.Controls.Add(this.lblIli);
            this.Controls.Add(this.txtPostotakNagrade);
            this.Controls.Add(this.lblPostotakNagrade);
            this.Controls.Add(this.txtKolicinaNagrade);
            this.Controls.Add(this.lblKolicinaNagrade);
            this.Controls.Add(this.txtNazivMjesta);
            this.Controls.Add(this.lblNazivMjesta);
            this.Controls.Add(this.txtMjesto);
            this.Controls.Add(this.lblMjesto);
            this.Controls.Add(this.lblIzradiNagradu);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DodavanjeNagrada";
            this.Text = "Dodavanje Nagrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIzradiNagradu;
        private System.Windows.Forms.Label lblMjesto;
        private System.Windows.Forms.TextBox txtMjesto;
        private System.Windows.Forms.TextBox txtNazivMjesta;
        private System.Windows.Forms.Label lblNazivMjesta;
        private System.Windows.Forms.TextBox txtKolicinaNagrade;
        private System.Windows.Forms.Label lblKolicinaNagrade;
        private System.Windows.Forms.TextBox txtPostotakNagrade;
        private System.Windows.Forms.Label lblPostotakNagrade;
        private System.Windows.Forms.Label lblIli;
        private System.Windows.Forms.Button btnIzradiNagradu;
    }
}