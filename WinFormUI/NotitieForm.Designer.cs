namespace WinFormUI
{
    partial class NotitieForm
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
            this.TitelLabel = new System.Windows.Forms.Label();
            this.TitelText = new System.Windows.Forms.TextBox();
            this.addPersonHeader = new System.Windows.Forms.Label();
            this.listPeopleHeader = new System.Windows.Forms.Label();
            this.LijstAlleNotities = new System.Windows.Forms.ListBox();
            this.NotitieToevoegen = new System.Windows.Forms.Button();
            this.LijstHerladen = new System.Windows.Forms.Button();
            this.Bewerken = new System.Windows.Forms.Button();
            this.Verwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitelLabel
            // 
            this.TitelLabel.AutoSize = true;
            this.TitelLabel.Location = new System.Drawing.Point(195, 138);
            this.TitelLabel.Name = "TitelLabel";
            this.TitelLabel.Size = new System.Drawing.Size(85, 40);
            this.TitelLabel.TabIndex = 0;
            this.TitelLabel.Text = "Titel";
            // 
            // TitelText
            // 
            this.TitelText.Location = new System.Drawing.Point(124, 181);
            this.TitelText.Name = "TitelText";
            this.TitelText.Size = new System.Drawing.Size(234, 48);
            this.TitelText.TabIndex = 2;
            // 
            // addPersonHeader
            // 
            this.addPersonHeader.AutoSize = true;
            this.addPersonHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPersonHeader.Location = new System.Drawing.Point(29, 27);
            this.addPersonHeader.Name = "addPersonHeader";
            this.addPersonHeader.Size = new System.Drawing.Size(451, 61);
            this.addPersonHeader.TabIndex = 4;
            this.addPersonHeader.Text = "Notitie toevoegen";
            // 
            // listPeopleHeader
            // 
            this.listPeopleHeader.AutoSize = true;
            this.listPeopleHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPeopleHeader.Location = new System.Drawing.Point(519, 27);
            this.listPeopleHeader.Name = "listPeopleHeader";
            this.listPeopleHeader.Size = new System.Drawing.Size(277, 61);
            this.listPeopleHeader.TabIndex = 5;
            this.listPeopleHeader.Text = "Notitie lijst";
            // 
            // LijstAlleNotities
            // 
            this.LijstAlleNotities.FormattingEnabled = true;
            this.LijstAlleNotities.ItemHeight = 40;
            this.LijstAlleNotities.Location = new System.Drawing.Point(498, 106);
            this.LijstAlleNotities.Name = "LijstAlleNotities";
            this.LijstAlleNotities.Size = new System.Drawing.Size(332, 364);
            this.LijstAlleNotities.TabIndex = 6;
            // 
            // NotitieToevoegen
            // 
            this.NotitieToevoegen.Location = new System.Drawing.Point(68, 278);
            this.NotitieToevoegen.Name = "NotitieToevoegen";
            this.NotitieToevoegen.Size = new System.Drawing.Size(374, 69);
            this.NotitieToevoegen.TabIndex = 7;
            this.NotitieToevoegen.Text = "Notitie toevoegen";
            this.NotitieToevoegen.UseVisualStyleBackColor = true;
            this.NotitieToevoegen.Click += new System.EventHandler(this.NotitieToevoegen_Click);
            // 
            // LijstHerladen
            // 
            this.LijstHerladen.Location = new System.Drawing.Point(68, 380);
            this.LijstHerladen.Name = "LijstHerladen";
            this.LijstHerladen.Size = new System.Drawing.Size(374, 69);
            this.LijstHerladen.TabIndex = 8;
            this.LijstHerladen.Text = "Lijst herladen";
            this.LijstHerladen.UseVisualStyleBackColor = true;
            this.LijstHerladen.Click += new System.EventHandler(this.LijstHerladen_Click);
            // 
            // Bewerken
            // 
            this.Bewerken.Location = new System.Drawing.Point(545, 484);
            this.Bewerken.Name = "Bewerken";
            this.Bewerken.Size = new System.Drawing.Size(236, 55);
            this.Bewerken.TabIndex = 9;
            this.Bewerken.Text = "Bewerken";
            this.Bewerken.UseVisualStyleBackColor = true;
            this.Bewerken.Click += new System.EventHandler(this.Bewerken_Click);
            // 
            // Verwijderen
            // 
            this.Verwijderen.Location = new System.Drawing.Point(545, 564);
            this.Verwijderen.Name = "Verwijderen";
            this.Verwijderen.Size = new System.Drawing.Size(236, 55);
            this.Verwijderen.TabIndex = 10;
            this.Verwijderen.Text = "Verwijderen";
            this.Verwijderen.UseVisualStyleBackColor = true;
            this.Verwijderen.Click += new System.EventHandler(this.Verwijderen_Click);
            // 
            // NotitieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 631);
            this.Controls.Add(this.Verwijderen);
            this.Controls.Add(this.Bewerken);
            this.Controls.Add(this.LijstHerladen);
            this.Controls.Add(this.NotitieToevoegen);
            this.Controls.Add(this.LijstAlleNotities);
            this.Controls.Add(this.listPeopleHeader);
            this.Controls.Add(this.addPersonHeader);
            this.Controls.Add(this.TitelText);
            this.Controls.Add(this.TitelLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "NotitieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite Demo Form by Tim Corey";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitelLabel;
        private System.Windows.Forms.TextBox TitelText;
        private System.Windows.Forms.Label addPersonHeader;
        private System.Windows.Forms.Label listPeopleHeader;
        private System.Windows.Forms.ListBox LijstAlleNotities;
        private System.Windows.Forms.Button NotitieToevoegen;
        private System.Windows.Forms.Button LijstHerladen;
        private System.Windows.Forms.Button Bewerken;
        private System.Windows.Forms.Button Verwijderen;
    }
}

