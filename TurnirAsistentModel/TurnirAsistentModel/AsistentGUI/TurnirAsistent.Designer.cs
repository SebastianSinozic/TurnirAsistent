namespace AsistentGUI
{
    partial class TurnirAsistent
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
            this.lblTurnamentAsistent = new System.Windows.Forms.Label();
            this.btnUcitajTurnir = new System.Windows.Forms.Button();
            this.btnKreirajTurnir2 = new System.Windows.Forms.Button();
            this.cmbUcitaj = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTurnamentAsistent
            // 
            this.lblTurnamentAsistent.AutoSize = true;
            this.lblTurnamentAsistent.Font = new System.Drawing.Font("Times New Roman", 60F);
            this.lblTurnamentAsistent.ForeColor = System.Drawing.Color.Black;
            this.lblTurnamentAsistent.Location = new System.Drawing.Point(82, 57);
            this.lblTurnamentAsistent.Name = "lblTurnamentAsistent";
            this.lblTurnamentAsistent.Size = new System.Drawing.Size(519, 90);
            this.lblTurnamentAsistent.TabIndex = 0;
            this.lblTurnamentAsistent.Text = "Turnir Asistent";
            this.lblTurnamentAsistent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTurnamentAsistent.Click += new System.EventHandler(this.lblTurnamentAsistent_Click);
            // 
            // btnUcitajTurnir
            // 
            this.btnUcitajTurnir.BackColor = System.Drawing.Color.Brown;
            this.btnUcitajTurnir.ForeColor = System.Drawing.Color.White;
            this.btnUcitajTurnir.Location = new System.Drawing.Point(223, 253);
            this.btnUcitajTurnir.Name = "btnUcitajTurnir";
            this.btnUcitajTurnir.Size = new System.Drawing.Size(251, 51);
            this.btnUcitajTurnir.TabIndex = 2;
            this.btnUcitajTurnir.Text = "Učitaj turnir";
            this.btnUcitajTurnir.UseVisualStyleBackColor = false;
            this.btnUcitajTurnir.Click += new System.EventHandler(this.btnUcitajTurnir_Click);
            // 
            // btnKreirajTurnir2
            // 
            this.btnKreirajTurnir2.BackColor = System.Drawing.Color.Brown;
            this.btnKreirajTurnir2.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.btnKreirajTurnir2.ForeColor = System.Drawing.SystemColors.Window;
            this.btnKreirajTurnir2.Location = new System.Drawing.Point(115, 310);
            this.btnKreirajTurnir2.Name = "btnKreirajTurnir2";
            this.btnKreirajTurnir2.Size = new System.Drawing.Size(452, 129);
            this.btnKreirajTurnir2.TabIndex = 3;
            this.btnKreirajTurnir2.Text = "Kreiraj novi turnir";
            this.btnKreirajTurnir2.UseVisualStyleBackColor = false;
            this.btnKreirajTurnir2.Click += new System.EventHandler(this.btnKreirajTurnir2_Click);
            // 
            // cmbUcitaj
            // 
            this.cmbUcitaj.FormattingEnabled = true;
            this.cmbUcitaj.Location = new System.Drawing.Point(133, 219);
            this.cmbUcitaj.Name = "cmbUcitaj";
            this.cmbUcitaj.Size = new System.Drawing.Size(421, 28);
            this.cmbUcitaj.TabIndex = 4;
            // 
            // TurnirAsistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(668, 542);
            this.Controls.Add(this.cmbUcitaj);
            this.Controls.Add(this.btnKreirajTurnir2);
            this.Controls.Add(this.btnUcitajTurnir);
            this.Controls.Add(this.lblTurnamentAsistent);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TurnirAsistent";
            this.Text = "Turnir Asistent";
            this.Load += new System.EventHandler(this.TurnirAsistent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTurnamentAsistent;
        private System.Windows.Forms.Button btnUcitajTurnir;
        private System.Windows.Forms.Button btnKreirajTurnir2;
        private System.Windows.Forms.ComboBox cmbUcitaj;
    }
}