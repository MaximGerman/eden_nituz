namespace Group16
{
    partial class SetMinimumStockOpeningScreen
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
            this.ConfirmSiteChoiceForSetMinimumStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectSiteComboBoxForMinimumStock = new System.Windows.Forms.ComboBox();
            this.SelectSiteTextForMinimumStock = new System.Windows.Forms.Label();
            this.SetMinimumStockHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConfirmSiteChoiceForSetMinimumStock
            // 
            this.ConfirmSiteChoiceForSetMinimumStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmSiteChoiceForSetMinimumStock.Location = new System.Drawing.Point(312, 261);
            this.ConfirmSiteChoiceForSetMinimumStock.Name = "ConfirmSiteChoiceForSetMinimumStock";
            this.ConfirmSiteChoiceForSetMinimumStock.Size = new System.Drawing.Size(139, 45);
            this.ConfirmSiteChoiceForSetMinimumStock.TabIndex = 1;
            this.ConfirmSiteChoiceForSetMinimumStock.Text = "Confirm Site Choice";
            this.ConfirmSiteChoiceForSetMinimumStock.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            // 
            // SelectSiteComboBoxForMinimumStock
            // 
            this.SelectSiteComboBoxForMinimumStock.FormattingEnabled = true;
            this.SelectSiteComboBoxForMinimumStock.Location = new System.Drawing.Point(321, 212);
            this.SelectSiteComboBoxForMinimumStock.Name = "SelectSiteComboBoxForMinimumStock";
            this.SelectSiteComboBoxForMinimumStock.Size = new System.Drawing.Size(121, 21);
            this.SelectSiteComboBoxForMinimumStock.TabIndex = 3;
            this.SelectSiteComboBoxForMinimumStock.SelectedIndexChanged += new System.EventHandler(this.SelectSiteComboBoxForMinimumStock_SelectedIndexChanged);
            // 
            // SelectSiteTextForMinimumStock
            // 
            this.SelectSiteTextForMinimumStock.AutoSize = true;
            this.SelectSiteTextForMinimumStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSiteTextForMinimumStock.Location = new System.Drawing.Point(212, 207);
            this.SelectSiteTextForMinimumStock.Name = "SelectSiteTextForMinimumStock";
            this.SelectSiteTextForMinimumStock.Size = new System.Drawing.Size(103, 24);
            this.SelectSiteTextForMinimumStock.TabIndex = 4;
            this.SelectSiteTextForMinimumStock.Text = "Select Site:";
            // 
            // SetMinimumStockHeader
            // 
            this.SetMinimumStockHeader.AutoSize = true;
            this.SetMinimumStockHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetMinimumStockHeader.Location = new System.Drawing.Point(160, 118);
            this.SetMinimumStockHeader.Name = "SetMinimumStockHeader";
            this.SetMinimumStockHeader.Size = new System.Drawing.Size(453, 55);
            this.SetMinimumStockHeader.TabIndex = 5;
            this.SetMinimumStockHeader.Text = "Set Minimum Stock";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Group16.Properties.Resources.Sodexo_logo_svg;
            this.pictureBox1.Location = new System.Drawing.Point(23, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SetMinimumStockOpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SetMinimumStockHeader);
            this.Controls.Add(this.SelectSiteTextForMinimumStock);
            this.Controls.Add(this.SelectSiteComboBoxForMinimumStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConfirmSiteChoiceForSetMinimumStock);
            this.Name = "SetMinimumStockOpeningScreen";
            this.Text = "Set Minimum Stock Opening Screen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConfirmSiteChoiceForSetMinimumStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectSiteComboBoxForMinimumStock;
        private System.Windows.Forms.Label SelectSiteTextForMinimumStock;
        private System.Windows.Forms.Label SetMinimumStockHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}