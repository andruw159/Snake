namespace snake_Last_
{
    partial class Menu
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
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnPuntajes = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(75, 68);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(129, 70);
            this.btnJugar.TabIndex = 0;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnPuntajes
            // 
            this.btnPuntajes.Location = new System.Drawing.Point(75, 220);
            this.btnPuntajes.Name = "btnPuntajes";
            this.btnPuntajes.Size = new System.Drawing.Size(129, 70);
            this.btnPuntajes.TabIndex = 1;
            this.btnPuntajes.Text = "Puntajes";
            this.btnPuntajes.UseVisualStyleBackColor = true;
            this.btnPuntajes.Click += new System.EventHandler(this.btnPuntajes_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(295, 143);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(129, 70);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 356);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnPuntajes);
            this.Controls.Add(this.btnJugar);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnJugar;
        private System.Windows.Forms.Button btnPuntajes;
        private System.Windows.Forms.Button btnCerrar;
    }
}