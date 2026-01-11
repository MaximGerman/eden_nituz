using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class SHIPPING
    {
        // --- Fields ---
        private int shippingID;
        private SUPPLIER supplier;
        private REGION region;
        private string day;
        private string hours;

        // --- Constructor ---
        public SHIPPING(int shippingID, SUPPLIER supplier, REGION region, string day, string hours, bool is_new)
        {
            this.shippingID = shippingID;
            this.supplier = supplier;
            this.region = region;
            this.day = day;
            this.hours = hours;

            // Link to supplier and region
            if (this.supplier != null)
                this.supplier.addShipping(this);
            if (this.region != null)
                this.region.addShipping(this);

            if (is_new)
            {
                this.create_shipping_to_DB();
                Program.SHIPPINGS.Add(this);
            }
        }

        // --- Getters ---
        public int get_shippingID() { return this.shippingID; }
        public SUPPLIER get_supplier() { return this.supplier; }
        public REGION get_region() { return this.region; }
        public string get_day() { return this.day; }
        public string get_hours() { return this.hours; }

        // --- Database Methods ---
        public void create_shipping_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Shippings_Insert @shippingID, @supplier, @region, @day, @hours";
            c.Parameters.AddWithValue("@shippingID", this.shippingID);
            c.Parameters.AddWithValue("@supplier", this.supplier != null ? this.supplier.get_supplierName() : (object)DBNull.Value);
            c.Parameters.AddWithValue("@region", this.region != null ? this.region.get_name() : (object)DBNull.Value);
            c.Parameters.AddWithValue("@day", this.day);
            c.Parameters.AddWithValue("@hours", (object)this.hours ?? DBNull.Value);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_shipping_in_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Shippings_Update @shippingID, @supplier, @region, @day, @hours";
            c.Parameters.AddWithValue("@shippingID", this.shippingID);
            c.Parameters.AddWithValue("@supplier", this.supplier != null ? this.supplier.get_supplierName() : (object)DBNull.Value);
            c.Parameters.AddWithValue("@region", this.region != null ? this.region.get_name() : (object)DBNull.Value);
            c.Parameters.AddWithValue("@day", this.day);
            c.Parameters.AddWithValue("@hours", (object)this.hours ?? DBNull.Value);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
