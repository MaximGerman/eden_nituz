using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group16
{
    public class SUPPLIER
    {
        // --- 1. שדות פנימיים ---
        private string supplierName;
        private SUPPLIER_STATUS status;
        private SUPPLIER_ACTIVITY fieldOfActivity;
        private string email;
        private string phoneNumber;
        private decimal minimumOrderAmount;
        private bool isActive;

        // רשימות קשר
        private List<ITEM> items;
        private List<ORDER> orders;
        private List<SHIPPING> shippings;

        // --- 2. Constructor ---
        public SUPPLIER(string name, SUPPLIER_STATUS status, SUPPLIER_ACTIVITY field, string email, string phone, decimal minAmount, bool isActive, bool is_new)
        {
            this.supplierName = name;
            this.status = status;
            this.fieldOfActivity = field;
            this.email = email;
            this.phoneNumber = phone;
            this.minimumOrderAmount = minAmount;
            this.isActive = isActive;

            this.items = new List<ITEM>();
            this.orders = new List<ORDER>();
            this.shippings = new List<SHIPPING>();

            if (is_new)
            {
                this.create_supplier_to_DB();
                Program.SUPPLIERS.Add(this);
            }
        }

        // --- 3. Database Methods (בלי fillParameters) ---

        public void create_supplier_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Suppliers_Insert @supplierName, @status, @fieldOfActivity, @email, @phoneNumber, @minAmount, @isActive";

            c.Parameters.AddWithValue("@supplierName", this.supplierName);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@fieldOfActivity", this.fieldOfActivity.ToString().Replace("_", " "));
            c.Parameters.AddWithValue("@email", (object)this.email ?? DBNull.Value);
            c.Parameters.AddWithValue("@phoneNumber", (object)this.phoneNumber ?? DBNull.Value);
            c.Parameters.AddWithValue("@minAmount", this.minimumOrderAmount);
            c.Parameters.AddWithValue("@isActive", this.isActive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_supplier()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Suppliers_Update @supplierName, @status, @fieldOfActivity, @email, @phoneNumber, @minAmount, @isActive";

            c.Parameters.AddWithValue("@supplierName", this.supplierName);
            c.Parameters.AddWithValue("@status", this.status.ToString());
            c.Parameters.AddWithValue("@fieldOfActivity", this.fieldOfActivity.ToString().Replace("_", " "));
            c.Parameters.AddWithValue("@email", (object)this.email ?? DBNull.Value);
            c.Parameters.AddWithValue("@phoneNumber", (object)this.phoneNumber ?? DBNull.Value);
            c.Parameters.AddWithValue("@minAmount", this.minimumOrderAmount);
            c.Parameters.AddWithValue("@isActive", this.isActive);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // --- 4. Getters (לצורך שימוש בטפסים ובשאר המחלקות) ---
        public string get_supplierName() { return this.supplierName; }
        public SUPPLIER_STATUS get_status() { return this.status; }
        public SUPPLIER_ACTIVITY get_fieldOfActivity() { return this.fieldOfActivity; }
        public string get_email() { return this.email; }
        public string get_phoneNumber() { return this.phoneNumber; }
        public decimal get_minimumOrderAmount() { return this.minimumOrderAmount; }
        public bool get_isActive() { return this.isActive; }

        // Getters לרשימות
        public List<ITEM> get_items() { return this.items; }
        public List<ORDER> get_orders() { return this.orders; }
        public List<SHIPPING> get_shippings() { return this.shippings; }

        // --- 5. מתודות לניהול קשרים (Association Methods) ---
        public void add_Item(ITEM i) { if (i != null && !this.items.Contains(i)) this.items.Add(i); }
        public void addOrder(ORDER i) { if (i != null && !this.orders.Contains(i)) this.orders.Add(i); }
        public void addShipping(SHIPPING i) { if (i != null && !this.shippings.Contains(i)) this.shippings.Add(i); }

        public override string ToString() { return this.supplierName; }
    }
}