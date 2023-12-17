
namespace WinFormUI
{
    partial class NotitieBewerkenForm
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
            this.Opslaan = new System.Windows.Forms.Button();
            this.Annuleren = new System.Windows.Forms.Button();
            this.InhoudVan = new System.Windows.Forms.Label();
            this.InhoudNotitie = new System.Windows.Forms.TextBox();
            this.TitelNotitie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HuidigeNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Opslaan
            // 
            this.Opslaan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Opslaan.Location = new System.Drawing.Point(726, 679);
            this.Opslaan.Name = "Opslaan";
            this.Opslaan.Size = new System.Drawing.Size(236, 55);
            this.Opslaan.TabIndex = 10;
            this.Opslaan.Text = "Opslaan";
            this.Opslaan.UseVisualStyleBackColor = true;
            this.Opslaan.Click += new System.EventHandler(this.Opslaan_Click);
            // 
            // Annuleren
            // 
            this.Annuleren.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Annuleren.Location = new System.Drawing.Point(982, 679);
            this.Annuleren.Name = "Annuleren";
            this.Annuleren.Size = new System.Drawing.Size(236, 55);
            this.Annuleren.TabIndex = 11;
            this.Annuleren.Text = "Annuleren";
            this.Annuleren.UseVisualStyleBackColor = true;
            this.Annuleren.Click += new System.EventHandler(this.Annuleren_Click);
            // 
            // InhoudVan
            // 
            this.InhoudVan.AutoSize = true;
            this.InhoudVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InhoudVan.Location = new System.Drawing.Point(31, 23);
            this.InhoudVan.Name = "InhoudVan";
            this.InhoudVan.Size = new System.Drawing.Size(327, 61);
            this.InhoudVan.TabIndex = 12;
            this.InhoudVan.Text = "Inhoud van: ";
            // 
            // InhoudNotitie
            // 
            this.InhoudNotitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.InhoudNotitie.Location = new System.Drawing.Point(25, 126);
            this.InhoudNotitie.Multiline = true;
            this.InhoudNotitie.Name = "InhoudNotitie";
            this.InhoudNotitie.Size = new System.Drawing.Size(1193, 533);
            this.InhoudNotitie.TabIndex = 13;
            // 
            // TitelNotitie
            // 
            this.TitelNotitie.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitelNotitie.Location = new System.Drawing.Point(795, 72);
            this.TitelNotitie.Name = "TitelNotitie";
            this.TitelNotitie.Size = new System.Drawing.Size(421, 48);
            this.TitelNotitie.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(795, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 61);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nieuwe Titel:";
            // 
            // HuidigeNaam
            // 
            this.HuidigeNaam.AutoSize = true;
            this.HuidigeNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HuidigeNaam.Location = new System.Drawing.Point(353, 23);
            this.HuidigeNaam.Name = "HuidigeNaam";
            this.HuidigeNaam.Size = new System.Drawing.Size(0, 61);
            this.HuidigeNaam.TabIndex = 16;
            // 
            // NotitieBewerkenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 746);
            this.Controls.Add(this.HuidigeNaam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitelNotitie);
            this.Controls.Add(this.InhoudNotitie);
            this.Controls.Add(this.InhoudVan);
            this.Controls.Add(this.Annuleren);
            this.Controls.Add(this.Opslaan);
            this.Name = "NotitieBewerkenForm";
            this.Text = "NotitieBewerkenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Opslaan;
        private System.Windows.Forms.Button Annuleren;
        private System.Windows.Forms.Label InhoudVan;
        private System.Windows.Forms.TextBox InhoudNotitie;
        private System.Windows.Forms.TextBox TitelNotitie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HuidigeNaam;
    }
}