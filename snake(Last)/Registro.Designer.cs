﻿namespace snake_Last_
{
    partial class Registro
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
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UsuarioDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PuntajeDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDtg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(151, 113);
            this.txtRegistro.Multiline = true;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(183, 27);
            this.txtRegistro.TabIndex = 0;
            this.txtRegistro.TextChanged += new System.EventHandler(this.txtRegistro_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese su User";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(197, 165);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(95, 29);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(21, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(436, 217);
            this.dataGridView1.TabIndex = 3;
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
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake_Last_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(469, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRegistro);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn PuntajeDtg;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDtg;
    }
}