using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class ITEM_IN_SITE_STOCK
    {
        // --- Fields ---
        private SITE site;
        private ITEM item;
        private int minimumQuantity;
        private int currentQuantity;

        // --- Constructor ---
        public ITEM_IN_SITE_STOCK(SITE site, ITEM item, int minimumQuantity, int currentQuantity, bool is_new)
        {
            this.site = site;
            this.item = item;
            this.minimumQuantity = minimumQuantity;
            this.currentQuantity = currentQuantity;

            // Link to site and item
            if (this.site != null)
                this.site.addItemInStock(this);
            if (this.item != null)
                this.item.addItemInStock(this);

            if (is_new)
            {
                this.create_item_in_site_stock_to_DB();
                Program.ITEM_IN_SITE_STOCKS.Add(this);
            }
        }

        // --- Getters ---
        public SITE get_site() { return this.site; }
        public ITEM get_item() { return this.item; }
        public int get_minimumQuantity() { return this.minimumQuantity; }
        public int get_currentQuantity() { return this.currentQuantity; }

        // --- Setters ---
        public void set_minimumQuantity(int qty) { this.minimumQuantity = qty; }
        public void set_currentQuantity(int qty) { this.currentQuantity = qty; }

        // --- Database Methods ---
        public void create_item_in_site_stock_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_SiteItemStocks_Insert @siteName, @internalSku, @minQty, @currQty";

            c.Parameters.AddWithValue("@siteName", this.site != null ? this.site.get_name() : "");
            c.Parameters.AddWithValue("@internalSku", this.item != null ? this.item.get_internalSku() : 0);
            c.Parameters.AddWithValue("@minQty", this.minimumQuantity);
            c.Parameters.AddWithValue("@currQty", this.currentQuantity);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_item_in_site_stock()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_SiteItemStocks_Update @siteName, @internalSku, @minQty, @currQty";

            c.Parameters.AddWithValue("@siteName", this.site != null ? this.site.get_name() : "");
            c.Parameters.AddWithValue("@internalSku", this.item != null ? this.item.get_internalSku() : 0);
            c.Parameters.AddWithValue("@minQty", this.minimumQuantity);
            c.Parameters.AddWithValue("@currQty", this.currentQuantity);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}