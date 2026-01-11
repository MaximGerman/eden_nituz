using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class ITEM
    {
        // ===== Fields =====
        private int internalSku;
        private string name;
        private string description;
        private string unitOfMeasure;
        private int? supplierSku;
        private decimal pricePerUnit;
        private SUPPLIER supplier;   // Link to Supplier Object
        private bool isActive;
        private List<ITEM_IN_SITE_STOCK> itemsInStock; // stokcs in different sites
        private List<ITEM_IN_ORDER> itemsInOrder;

        // ===== Constructor =====
        public ITEM(int internalSku,
                    string name,
                    string description,
                    string unitOfMeasure,
                    int supplierSku,
                    decimal pricePerUnit,
                    SUPPLIER supplier,
                    bool isActive,
                    bool is_new)
        {
            this.internalSku = internalSku;
            this.name = name;
            this.description = description;
            this.unitOfMeasure = unitOfMeasure;
            this.supplierSku = supplierSku;
            this.pricePerUnit = pricePerUnit;
            this.isActive = isActive;
            this.itemsInStock = new List<ITEM_IN_SITE_STOCK>();
            this.itemsInOrder= new List<ITEM_IN_ORDER>();

            // Link Supplier -> Item in memory
            this.set_supplier(supplier);

            if (is_new)
            {
                this.create_item_to_DB();
                Program.ITEMS.Add(this);
            }
        }

        // ===== Getters =====
        public int get_internalSku() { return this.internalSku; }
        public string get_name() { return this.name; }
        public string get_description() { return this.description; }
        public string get_unitOfMeasure() { return this.unitOfMeasure; }
        public int get_supplierSku() { return this.supplierSku; }
        public decimal get_pricePerUnit() { return this.pricePerUnit; }
        public SUPPLIER get_supplier() { return this.supplier; }
        public bool get_isActive() { return this.isActive; }

        // ===== Setters =====
        public void set_name(string name) { this.name = name; }
        public void set_description(string description) { this.description = description; }
        public void set_unitOfMeasure(string unit) { this.unitOfMeasure = unit; }
        public void set_supplierSku(int supplierSku) { this.supplierSku = supplierSku; }
        public void set_pricePerUnit(decimal price) { this.pricePerUnit = price; }
        public void set_isActive(bool active) { this.isActive = active; }

        public void set_supplier(SUPPLIER s)
        {
            this.supplier = s;
            if (this.supplier != null)
            {
                this.supplier.add_Item(this);
            }
        }

        // ===== CREATE =====
        public void create_item_to_DB()
        {
            if (this.supplier == null)
                throw new InvalidOperationException("Item must have a supplier (supplierName is NOT NULL in DB).");

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Items_Insert @internalSku, @name, @description, @uom, @supplierSku, @price, @supplierName, @IsActive";

            c.Parameters.AddWithValue("@internalSku", this.internalSku);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@description", (object)this.description ?? DBNull.Value);
            c.Parameters.AddWithValue("@uom", (object)this.unitOfMeasure ?? DBNull.Value);
            c.Parameters.AddWithValue("@supplierSku", (object)this.supplierSku ?? DBNull.Value);
            c.Parameters.AddWithValue("@price", this.pricePerUnit);
            c.Parameters.AddWithValue("@supplierName", this.supplier.get_supplierName());
            c.Parameters.AddWithValue("@IsActive", this.isActive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        // ===== UPDATE =====
        public void Update_item()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Items_Update @internalSku, @name, @description, @uom, @supplierSku, @price, @IsActive";

            c.Parameters.AddWithValue("@internalSku", this.internalSku);
            c.Parameters.AddWithValue("@name", this.name);
            c.Parameters.AddWithValue("@description", (object)this.description ?? DBNull.Value);
            c.Parameters.AddWithValue("@uom", (object)this.unitOfMeasure ?? DBNull.Value);
            c.Parameters.AddWithValue("@supplierSku", (object)this.supplierSku ?? DBNull.Value);
            c.Parameters.AddWithValue("@price", this.pricePerUnit);
            c.Parameters.AddWithValue("@IsActive", this.isActive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        public void Deactivate_item()
        {
            this.isActive = false;
            this.Update_item();
        }

        public void Activate_item()
        {
            this.isActive = true;
            this.Update_item();
        }

        public override string ToString()
        {
            return this.name;
        }
        public void addItemInStock(ITEM_IN_SITE_STOCK i)
        {
            if (i != null && !this.itemsInStock.Contains(i))
            {
                this.itemsInStock.Add(i);
            }
        }
        public void addItemInOrder(ITEM_IN_ORDER i)
        {
            if (i != null && !this.itemsInOrder.Contains(i))
            {
                this.itemsInOrder.Add(i);
            }
        }

    }
}