namespace Group16
{
    partial class Sodexo_Login
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
            this.Enter_username_text = new System.Windows.Forms.Label();
            this.Enter_password_text = new System.Windows.Forms.Label();
            this.Enter_username_textBox = new System.Windows.Forms.TextBox();
            this.Enter_password_textBox = new System.Windows.Forms.TextBox();
            this.ContinueToSystemBotton = new System.Windows.Forms.Button();
            this.SodexoLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter_username_text
            // 
            this.Enter_username_text.AutoSize = true;
            this.Enter_username_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_username_text.Location = new System.Drawing.Point(227, 251);
            this.Enter_username_text.Name = "Enter_username_text";
            this.Enter_username_text.Size = new System.Drawing.Size(150, 24);
            this.Enter_username_text.TabIndex = 6;
            this.Enter_username_text.Text = "Enter username:";
            // 
            // Enter_password_text
            // 
            this.Enter_password_text.AutoSize = true;
            this.Enter_password_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_password_text.Location = new System.Drawing.Point(227, 290);
            this.Enter_password_text.Name = "Enter_password_text";
            this.Enter_password_text.Size = new System.Drawing.Size(146, 24);
            this.Enter_password_text.TabIndex = 7;
            this.Enter_password_text.Text = "Enter password:";
            // 
            // Enter_username_textBox
            // 
            this.Enter_username_textBox.Location = new System.Drawing.Point(394, 255);
            this.Enter_username_textBox.Name = "Enter_username_textBox";
            this.Enter_username_textBox.Size = new System.Drawing.Size(100, 20);
            this.Enter_username_textBox.TabIndex = 8;
            // 
            // Enter_password_textBox
            // 
            this.Enter_password_textBox.Location = new System.Drawing.Point(394, 295);
            this.Enter_password_textBox.Name = "Enter_password_textBox";
            this.Enter_password_textBox.Size = new System.Drawing.Size(100, 20);
            this.Enter_password_textBox.TabIndex = 9;
            // 
            // ContinueToSystemBotton
            // 
            this.ContinueToSystemBotton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContinueToSystemBotton.Location = new System.Drawing.Point(319, 352);
            this.ContinueToSystemBotton.Name = "ContinueToSystemBotton";
            this.ContinueToSystemBotton.Size = new System.Drawing.Size(102, 30);
            this.ContinueToSystemBotton.TabIndex = 10;
            this.ContinueToSystemBotton.Text = "Continue";
            this.ContinueToSystemBotton.UseVisualStyleBackColor = true;
            this.ContinueToSystemBotton.Click += new System.EventHandler(this.ContinueToSystemBotton_Click);
            // 
            // SodexoLogo
            // 
            this.SodexoLogo.Image = global::Group16.Properties.Resources.Sodexo_logo_svg;
            this.SodexoLogo.Location = new System.Drawing.Point(231, 38);
            this.SodexoLogo.Name = "SodexoLogo";
            this.SodexoLogo.Size = new System.Drawing.Size(336, 185);
            this.SodexoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SodexoLogo.TabIndex = 5;
            this.SodexoLogo.TabStop = false;
            // 
            // Sodexo_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContinueToSystemBotton);
            this.Controls.Add(this.Enter_password_textBox);
            this.Controls.Add(this.Enter_username_textBox);
            this.Controls.Add(this.Enter_password_text);
            this.Controls.Add(this.Enter_username_text);
            this.Controls.Add(this.SodexoLogo);
            this.Name = "Sodexo_Login";
            this.Text = "Sodexo - Login";
            this.Load += new System.EventHandler(this.Sodexo_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SodexoLogo;
        private System.Windows.Forms.Label Enter_username_text;
        private System.Windows.Forms.Label Enter_password_text;
        private System.Windows.Forms.TextBox Enter_username_textBox;
        private System.Windows.Forms.TextBox Enter_password_textBox;
        private System.Windows.Forms.Button ContinueToSystemBotton;
    }
}