namespace Group16
{
    partial class ManageItemsOpeningScreen
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
            this.components = new System.ComponentModel.Container();
            this.SearchItemByName = new System.Windows.Forms.ComboBox();
            this.SearchItemBySupplier = new System.Windows.Forms.ComboBox();
            this.SearchItemByStatus = new System.Windows.Forms.ComboBox();
            this.SearchItemBySite = new System.Windows.Forms.ComboBox();
            this.SearchItem = new System.Windows.Forms.Button();
            this.CreateItem = new System.Windows.Forms.Button();
            this.UpdateItems = new System.Windows.Forms.Button();
            this.DeleteItems = new System.Windows.Forms.Button();
            this.SodexoLogo = new System.Windows.Forms.PictureBox();
            this.SearchItemBySKU = new System.Windows.Forms.ComboBox();
            this.sAD_16DataSet = new Group16.SAD_16DataSet();
            this.sAD16DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Group16.SAD_16DataSetTableAdapters.ItemsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchItemByName
            // 
            this.SearchItemByName.FormattingEnabled = true;
            this.SearchItemByName.Location = new System.Drawing.Point(61, 98);
            this.SearchItemByName.Name = "SearchItemByName";
            this.SearchItemByName.Size = new System.Drawing.Size(121, 21);
            this.SearchItemByName.TabIndex = 2;
            this.SearchItemByName.Text = "Item Name";
            this.SearchItemByName.SelectedIndexChanged += new System.EventHandler(this.SearchItemByName_SelectedIndexChanged);
            // 
            // SearchItemBySupplier
            // 
            this.SearchItemBySupplier.FormattingEnabled = true;
            this.SearchItemBySupplier.Location = new System.Drawing.Point(339, 98);
            this.SearchItemBySupplier.Name = "SearchItemBySupplier";
            this.SearchItemBySupplier.Size = new System.Drawing.Size(121, 21);
            this.SearchItemBySupplier.TabIndex = 4;
            this.SearchItemBySupplier.Text = "Supplier";
            // 
            // SearchItemByStatus
            // 
            this.SearchItemByStatus.FormattingEnabled = true;
            this.SearchItemByStatus.Location = new System.Drawing.Point(624, 98);
            this.SearchItemByStatus.Name = "SearchItemByStatus";
            this.SearchItemByStatus.Size = new System.Drawing.Size(121, 21);
            this.SearchItemByStatus.TabIndex = 5;
            this.SearchItemByStatus.Text = "Status";
            // 
            // SearchItemBySite
            // 
            this.SearchItemBySite.FormattingEnabled = true;
            this.SearchItemBySite.Location = new System.Drawing.Point(482, 98);
            this.SearchItemBySite.Name = "SearchItemBySite";
            this.SearchItemBySite.Size = new System.Drawing.Size(121, 21);
            this.SearchItemBySite.TabIndex = 6;
            this.SearchItemBySite.Text = "Site";
            // 
            // SearchItem
            // 
            this.SearchItem.Location = new System.Drawing.Point(114, 387);
            this.SearchItem.Name = "SearchItem";
            this.SearchItem.Size = new System.Drawing.Size(75, 23);
            this.SearchItem.TabIndex = 7;
            this.SearchItem.Text = "Search";
            this.SearchItem.UseVisualStyleBackColor = true;
            // 
            // CreateItem
            // 
            this.CreateItem.Location = new System.Drawing.Point(223, 387);
            this.CreateItem.Name = "CreateItem";
            this.CreateItem.Size = new System.Drawing.Size(109, 23);
            this.CreateItem.TabIndex = 8;
            this.CreateItem.Text = "Create New Item";
            this.CreateItem.UseVisualStyleBackColor = true;
            // 
            // UpdateItems
            // 
            this.UpdateItems.Location = new System.Drawing.Point(363, 387);
            this.UpdateItems.Name = "UpdateItems";
            this.UpdateItems.Size = new System.Drawing.Size(155, 23);
            this.UpdateItems.TabIndex = 9;
            this.UpdateItems.Text = "Update Selected Item";
            this.UpdateItems.UseVisualStyleBackColor = true;
            // 
            // DeleteItems
            // 
            this.DeleteItems.Location = new System.Drawing.Point(551, 387);
            this.DeleteItems.Name = "DeleteItems";
            this.DeleteItems.Size = new System.Drawing.Size(158, 23);
            this.DeleteItems.TabIndex = 10;
            this.DeleteItems.Text = "Delete Selected Items";
            this.DeleteItems.UseVisualStyleBackColor = true;
            // 
            // SodexoLogo
            // 
            this.SodexoLogo.Image = global::Group16.Properties.Resources.Sodexo_logo_svg;
            this.SodexoLogo.Location = new System.Drawing.Point(49, 24);
            this.SodexoLogo.Name = "SodexoLogo";
            this.SodexoLogo.Size = new System.Drawing.Size(100, 50);
            this.SodexoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SodexoLogo.TabIndex = 1;
            this.SodexoLogo.TabStop = false;
            // 
            // SearchItemBySKU
            // 
            this.SearchItemBySKU.FormattingEnabled = true;
            this.SearchItemBySKU.Location = new System.Drawing.Point(201, 98);
            this.SearchItemBySKU.Name = "SearchItemBySKU";
            this.SearchItemBySKU.Size = new System.Drawing.Size(121, 21);
            this.SearchItemBySKU.TabIndex = 3;
            this.SearchItemBySKU.Text = "Item SKU";
            // 
            // sAD_16DataSet
            // 
            this.sAD_16DataSet.DataSetName = "SAD_16DataSet";
            this.sAD_16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sAD16DataSetBindingSource
            // 
            this.sAD16DataSetBindingSource.DataSource = this.sAD_16DataSet;
            this.sAD16DataSetBindingSource.Position = 0;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.sAD16DataSetBindingSource;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // ManageItemsOpeningScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteItems);
            this.Controls.Add(this.UpdateItems);
            this.Controls.Add(this.CreateItem);
            this.Controls.Add(this.SearchItem);
            this.Controls.Add(this.SearchItemBySite);
            this.Controls.Add(this.SearchItemByStatus);
            this.Controls.Add(this.SearchItemBySupplier);
            this.Controls.Add(this.SearchItemBySKU);
            this.Controls.Add(this.SearchItemByName);
            this.Controls.Add(this.SodexoLogo);
            this.Name = "ManageItemsOpeningScreen";
            this.Text = "Mange Items";
            this.Load += new System.EventHandler(this.ManageItemsOpeningScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD16DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox SodexoLogo;
        private System.Windows.Forms.ComboBox SearchItemByName;
        private System.Windows.Forms.ComboBox SearchItemBySupplier;
        private System.Windows.Forms.ComboBox SearchItemByStatus;
        private System.Windows.Forms.ComboBox SearchItemBySite;
        private System.Windows.Forms.Button SearchItem;
        private System.Windows.Forms.Button CreateItem;
        private System.Windows.Forms.Button UpdateItems;
        private System.Windows.Forms.Button DeleteItems;
        private System.Windows.Forms.ComboBox SearchItemBySKU;
        private System.Windows.Forms.BindingSource sAD16DataSetBindingSource;
        private SAD_16DataSet sAD_16DataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SAD_16DataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}