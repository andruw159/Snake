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
            this.txtregPuntajes = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtregPuntajes
            // 
            this.txtregPuntajes.Location = new System.Drawing.Point(32, 84);
            this.txtregPuntajes.Multiline = true;
            this.txtregPuntajes.Name = "txtregPuntajes";
            this.txtregPuntajes.Size = new System.Drawing.Size(499, 295);
            this.txtregPuntajes.TabIndex = 0;
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
            // regPuntajtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake_Last_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(556, 393);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtregPuntajes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "regPuntajtes";
            this.Text = "regPuntajtes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtregPuntajes;
        private System.Windows.Forms.Button btnMostrar;
    }
}