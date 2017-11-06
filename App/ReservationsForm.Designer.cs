﻿namespace App
{
    partial class ReservationsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chambre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateArrivee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateDepart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Chambre,
            this.DateArrivee,
            this.DateDepart});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(492, 182);
            this.dataGridView1.TabIndex = 0;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Chambre
            // 
            this.Chambre.HeaderText = "Chambre";
            this.Chambre.Name = "Chambre";
            this.Chambre.ReadOnly = true;
            // 
            // DateArrivee
            // 
            this.DateArrivee.HeaderText = "Date d\'arrivée";
            this.DateArrivee.Name = "DateArrivee";
            this.DateArrivee.ReadOnly = true;
            // 
            // DateDepart
            // 
            this.DateDepart.HeaderText = "Date de départ";
            this.DateDepart.Name = "DateDepart";
            this.DateDepart.ReadOnly = true;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 210);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ReservationsForm";
            this.Text = "Gestion des réservations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chambre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateArrivee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateDepart;
    }
}