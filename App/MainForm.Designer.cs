namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_clients = new System.Windows.Forms.Button();
            this.btn_chambres = new System.Windows.Forms.Button();
            this.btn_reservations = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clients
            // 
            this.btn_clients.Location = new System.Drawing.Point(12, 24);
            this.btn_clients.Name = "btn_clients";
            this.btn_clients.Size = new System.Drawing.Size(146, 76);
            this.btn_clients.TabIndex = 0;
            this.btn_clients.Text = "Clients";
            this.btn_clients.UseVisualStyleBackColor = true;
            this.btn_clients.Click += new System.EventHandler(this.btn_clients_Click);
            // 
            // btn_chambres
            // 
            this.btn_chambres.Location = new System.Drawing.Point(182, 24);
            this.btn_chambres.Name = "btn_chambres";
            this.btn_chambres.Size = new System.Drawing.Size(153, 76);
            this.btn_chambres.TabIndex = 1;
            this.btn_chambres.Text = "Chambres";
            this.btn_chambres.UseVisualStyleBackColor = true;
            this.btn_chambres.Click += new System.EventHandler(this.btn_chambres_Click);
            // 
            // btn_reservations
            // 
            this.btn_reservations.Location = new System.Drawing.Point(365, 24);
            this.btn_reservations.Name = "btn_reservations";
            this.btn_reservations.Size = new System.Drawing.Size(158, 76);
            this.btn_reservations.TabIndex = 2;
            this.btn_reservations.Text = "Réservations";
            this.btn_reservations.UseVisualStyleBackColor = true;
            this.btn_reservations.Click += new System.EventHandler(this.btn_reservations_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 137);
            this.Controls.Add(this.btn_reservations);
            this.Controls.Add(this.btn_chambres);
            this.Controls.Add(this.btn_clients);
            this.Name = "MainForm";
            this.Text = "Gestion de l\'hôtel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clients;
        private System.Windows.Forms.Button btn_chambres;
        private System.Windows.Forms.Button btn_reservations;
    }
}

