namespace App
{
    partial class ChambresForm
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
            this.dg_chambres = new System.Windows.Forms.DataGridView();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_chambres)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_chambres
            // 
            this.dg_chambres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_chambres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Etage});
            this.dg_chambres.Location = new System.Drawing.Point(12, 12);
            this.dg_chambres.Name = "dg_chambres";
            this.dg_chambres.Size = new System.Drawing.Size(249, 150);
            this.dg_chambres.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.HeaderText = "Code";
            this.Code.Name = "Code";
            this.Code.ReadOnly = true;
            // 
            // Etage
            // 
            this.Etage.HeaderText = "Etage";
            this.Etage.Name = "Etage";
            this.Etage.ReadOnly = true;
            // 
            // ChambresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 172);
            this.Controls.Add(this.dg_chambres);
            this.Name = "ChambresForm";
            this.Text = "Gestions des chambres";
            ((System.ComponentModel.ISupportInitialize)(this.dg_chambres)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_chambres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etage;
    }
}