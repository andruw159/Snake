namespace snake_Last_
{
    partial class regPuntajtes
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
            this.dgvRegPuntaje = new System.Windows.Forms.DataGridView();
            this.UsuarioDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPuntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegPuntaje
            // 
            this.dgvRegPuntaje.AllowUserToAddRows = false;
            this.dgvRegPuntaje.AllowUserToDeleteRows = false;
            this.dgvRegPuntaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegPuntaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegPuntaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioDtg,
            this.PuntajeDtg,
            this.FechaDtg});
            this.dgvRegPuntaje.Location = new System.Drawing.Point(34, 75);
            this.dgvRegPuntaje.Name = "dgvRegPuntaje";
            this.dgvRegPuntaje.ReadOnly = true;
            this.dgvRegPuntaje.RowHeadersVisible = false;
            this.dgvRegPuntaje.RowHeadersWidth = 51;
            this.dgvRegPuntaje.RowTemplate.Height = 24;
            this.dgvRegPuntaje.Size = new System.Drawing.Size(436, 217);
            this.dgvRegPuntaje.TabIndex = 4;
            this.dgvRegPuntaje.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegPuntaje_CellContentClick);
            // 
            // UsuarioDtg
            // 
            this.UsuarioDtg.HeaderText = "Usuario";
            this.UsuarioDtg.MinimumWidth = 6;
            this.UsuarioDtg.Name = "UsuarioDtg";
            this.UsuarioDtg.ReadOnly = true;
            // 
            // PuntajeDtg
            // 
            this.PuntajeDtg.HeaderText = "Puntaje";
            this.PuntajeDtg.MinimumWidth = 6;
            this.PuntajeDtg.Name = "PuntajeDtg";
            this.PuntajeDtg.ReadOnly = true;
            // 
            // FechaDtg
            // 
            this.FechaDtg.HeaderText = "Fecha";
            this.FechaDtg.MinimumWidth = 6;
            this.FechaDtg.Name = "FechaDtg";
            this.FechaDtg.ReadOnly = true;
            // 
            // regPuntajtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 393);
            this.Controls.Add(this.dgvRegPuntaje);
            this.Name = "regPuntajtes";
            this.Text = "regPuntajtes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegPuntaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegPuntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDtg;
    }
}