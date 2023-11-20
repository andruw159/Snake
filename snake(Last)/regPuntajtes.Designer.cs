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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtregPuntajes
            // 
            this.txtregPuntajes.Location = new System.Drawing.Point(31, 81);
            this.txtregPuntajes.Multiline = true;
            this.txtregPuntajes.Name = "txtregPuntajes";
            this.txtregPuntajes.Size = new System.Drawing.Size(485, 282);
            this.txtregPuntajes.TabIndex = 2;
            this.txtregPuntajes.TextChanged += new System.EventHandler(this.txtregPuntaje_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(411, 29);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(104, 30);
            this.btnMenu.TabIndex = 4;
            this.btnMenu.Text = "Regresar";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // regPuntajtes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::snake_Last_.Properties.Resources.backgroud;
            this.ClientSize = new System.Drawing.Size(556, 393);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
    }
}