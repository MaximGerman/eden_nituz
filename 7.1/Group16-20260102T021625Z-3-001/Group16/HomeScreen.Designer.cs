namespace Group16
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.Manage_Item = new System.Windows.Forms.Button();
            this.SetMinimumStock = new System.Windows.Forms.Button();
            this.UpdateStock = new System.Windows.Forms.Button();
            this.CreateOrder = new System.Windows.Forms.Button();
            this.SodexoLogo = new System.Windows.Forms.PictureBox();
            this.sAD_16DataSet = new Group16.SAD_16DataSet();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Group16.SAD_16DataSetTableAdapters.ItemsTableAdapter();
            this.tableAdapterManager = new Group16.SAD_16DataSetTableAdapters.TableAdapterManager();
            this.itemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.itemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).BeginInit();
            this.itemsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // Manage_Item
            // 
            this.Manage_Item.Location = new System.Drawing.Point(99, 311);
            this.Manage_Item.Name = "Manage_Item";
            this.Manage_Item.Size = new System.Drawing.Size(124, 53);
            this.Manage_Item.TabIndex = 0;
            this.Manage_Item.Text = "Manage Items";
            this.Manage_Item.UseVisualStyleBackColor = true;
            this.Manage_Item.Click += new System.EventHandler(this.Manage_Item_Click);
            // 
            // SetMinimumStock
            // 
            this.SetMinimumStock.Location = new System.Drawing.Point(266, 311);
            this.SetMinimumStock.Name = "SetMinimumStock";
            this.SetMinimumStock.Size = new System.Drawing.Size(127, 53);
            this.SetMinimumStock.TabIndex = 1;
            this.SetMinimumStock.Text = "Set Minimum Stock";
            this.SetMinimumStock.UseVisualStyleBackColor = true;
            this.SetMinimumStock.Click += new System.EventHandler(this.SetMinimumStock_Click);
            // 
            // UpdateStock
            // 
            this.UpdateStock.Location = new System.Drawing.Point(429, 311);
            this.UpdateStock.Name = "UpdateStock";
            this.UpdateStock.Size = new System.Drawing.Size(112, 53);
            this.UpdateStock.TabIndex = 2;
            this.UpdateStock.Text = "Update Stock";
            this.UpdateStock.UseVisualStyleBackColor = true;
            this.UpdateStock.Click += new System.EventHandler(this.UpdateStock_Click);
            // 
            // CreateOrder
            // 
            this.CreateOrder.Location = new System.Drawing.Point(593, 311);
            this.CreateOrder.Name = "CreateOrder";
            this.CreateOrder.Size = new System.Drawing.Size(107, 53);
            this.CreateOrder.TabIndex = 3;
            this.CreateOrder.Text = "Create Order";
            this.CreateOrder.UseVisualStyleBackColor = true;
            this.CreateOrder.Click += new System.EventHandler(this.CreateOrder_Click);
            // 
            // SodexoLogo
            // 
            this.SodexoLogo.Image = global::Group16.Properties.Resources.Sodexo_logo_svg;
            this.SodexoLogo.Location = new System.Drawing.Point(233, 76);
            this.SodexoLogo.Name = "SodexoLogo";
            this.SodexoLogo.Size = new System.Drawing.Size(336, 185);
            this.SodexoLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SodexoLogo.TabIndex = 4;
            this.SodexoLogo.TabStop = false;
            // 
            // sAD_16DataSet
            // 
            this.sAD_16DataSet.DataSetName = "SAD_16DataSet";
            this.sAD_16DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.sAD_16DataSet;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DaysInWeekTableAdapter = null;
            this.tableAdapterManager.ItemsInOrdersTableAdapter = null;
            this.tableAdapterManager.ItemsTableAdapter = this.itemsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.OrderStatusesTableAdapter = null;
            this.tableAdapterManager.RegionsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SiteItemStocksTableAdapter = null;
            this.tableAdapterManager.SitesTableAdapter = null;
            this.tableAdapterManager.SupplierActivitiesTableAdapter = null;
            this.tableAdapterManager.SupplierRegionShippingsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.SupplierStatusesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Group16.SAD_16DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersSitesTableAdapter = null;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // itemsBindingNavigator
            // 
            this.itemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.itemsBindingNavigator.BindingSource = this.itemsBindingSource;
            this.itemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.itemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.itemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.itemsBindingNavigatorSaveItem});
            this.itemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.itemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.itemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.itemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.itemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.itemsBindingNavigator.Name = "itemsBindingNavigator";
            this.itemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.itemsBindingNavigator.Size = new System.Drawing.Size(991, 25);
            this.itemsBindingNavigator.TabIndex = 5;
            this.itemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // itemsBindingNavigatorSaveItem
            // 
            this.itemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.itemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("itemsBindingNavigatorSaveItem.Image")));
            this.itemsBindingNavigatorSaveItem.Name = "itemsBindingNavigatorSaveItem";
            this.itemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.itemsBindingNavigatorSaveItem.Text = "Save Data";
            this.itemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.itemsBindingNavigatorSaveItem_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.itemsBindingNavigator);
            this.Controls.Add(this.SodexoLogo);
            this.Controls.Add(this.CreateOrder);
            this.Controls.Add(this.UpdateStock);
            this.Controls.Add(this.SetMinimumStock);
            this.Controls.Add(this.Manage_Item);
            this.Name = "HomeScreen";
            this.Text = "Sodexo - Home Screen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SodexoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sAD_16DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingNavigator)).EndInit();
            this.itemsBindingNavigator.ResumeLayout(false);
            this.itemsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Manage_Item;
        private System.Windows.Forms.Button SetMinimumStock;
        private System.Windows.Forms.Button UpdateStock;
        private System.Windows.Forms.Button CreateOrder;
        private System.Windows.Forms.PictureBox SodexoLogo;
        private SAD_16DataSet sAD_16DataSet;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private SAD_16DataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private SAD_16DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator itemsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton itemsBindingNavigatorSaveItem;
    }
}

