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
            this.btnMostrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsuarioDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(179, 29);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(198, 49);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioDtg,
            this.PuntajeDtg,
            this.FechaDtg});
            this.dataGridView1.Location = new System.Drawing.Point(58, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 217);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.BackgroundImage = global::snake_Last_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(556, 393);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnMostrar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regPuntajtes";
            this.Text = "regPuntajtes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDtg;
    }
}