namespace Group16
{
    partial class CreateOrderOpeningScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SelectSiteForOrderText = new System.Windows.Forms.Label();
            this.CreateOrderHeader = new System.Windows.Forms.Label();
            this.SelectSiteForOrdertextBox = new System.Windows.Forms.ComboBox();
            this.buttonForConfirmingSiteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group16.Properties.Resources.Sodexo_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // SelectSiteForOrderText
            // 
            this.SelectSiteForOrderText.AutoSize = true;
            this.SelectSiteForOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSiteForOrderText.Location = new System.Drawing.Point(245, 219);
            this.SelectSiteForOrderText.Name = "SelectSiteForOrderText";
            this.SelectSiteForOrderText.Size = new System.Drawing.Size(103, 24);
            this.SelectSiteForOrderText.TabIndex = 8;
            this.SelectSiteForOrderText.Text = "Select Site:";
            // 
            // CreateOrderHeader
            // 
            this.CreateOrderHeader.AutoSize = true;
            this.CreateOrderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateOrderHeader.Location = new System.Drawing.Point(239, 134);
            this.CreateOrderHeader.Name = "CreateOrderHeader";
            this.CreateOrderHeader.Size = new System.Drawing.Size(305, 55);
            this.CreateOrderHeader.TabIndex = 9;
            this.CreateOrderHeader.Text = "Create Order";
            // 
            // SelectSiteForOrdertextBox
            // 
            this.SelectSiteForOrdertextBox.FormattingEnabled = true;
            this.SelectSiteForOrdertextBox.Location = new System.Drawing.Point(363, 219);
            this.SelectSiteForOrdertextBox.Name = "SelectSiteForOrdertextBox";
            this.SelectSiteForOrdertextBox.Size = new System.Drawing.Size(121, 21);
            this.SelectSiteForOrdertextBox.TabIndex = 10;
            // 
            // buttonForConfirmingSiteOrder
            // 
            this.buttonForConfirmingSiteOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonForConfirmingSiteOrder.Location = new System.Drawing.Point(297, 270);
            this.buttonForConfirmingSiteOrder.Name = "buttonForConfirmingSiteOrder";
            this.buttonForConfirmingSiteOrder.Size = new System.Drawing.Size(141, 54);
            this.buttonForConfirmingSiteOrder.TabIndex = 11;
            this.buttonForConfirmingSiteOrder.Text = "Confirm Site Choice";
            this.buttonForConfirmingSiteOrder.UseVisualStyleBackColor = true;
            // 
            // CreateOrderOpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonForConfirmingSiteOrder);
            this.Controls.Add(this.SelectSiteForOrdertextBox);
            this.Controls.Add(this.CreateOrderHeader);
            this.Controls.Add(this.SelectSiteForOrderText);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CreateOrderOpeningScreen";
            this.Text = "CreateOrderOpeningScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label SelectSiteForOrderText;
        private System.Windows.Forms.Label CreateOrderHeader;
        private System.Windows.Forms.ComboBox SelectSiteForOrdertextBox;
        private System.Windows.Forms.Button buttonForConfirmingSiteOrder;
    }
}