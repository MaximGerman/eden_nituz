using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class ITEM_IN_ORDER
    {
        // --- Fields ---
        private ORDER order;
        private ITEM item;
        private int quantityInOrder;
        private decimal pricePerUnit;

        // --- Constructor ---
        public ITEM_IN_ORDER(ORDER order, ITEM item, int quantityInOrder, decimal pricePerUnit, bool is_new)
        {
            this.order = order;
            this.item = item;
            this.quantityInOrder = quantityInOrder;
            this.pricePerUnit = pricePerUnit;

            // Link to order and item
            if (this.order != null)
                this.order.addItemInOrder(this);
            if (this.item != null)
                this.item.addItemInOrder(this);

            if (is_new)
            {
                this.create_item_in_order_to_DB();
                Program.ITEM_IN_ORDERS.Add(this);
            }
        }

        // --- Getters ---
        public ORDER get_order() { return this.order; }
        public ITEM get_item() { return this.item; }
        public int get_quantityInOrder() { return this.quantityInOrder; }
        public decimal get_pricePerUnit() { return this.pricePerUnit; }

        // --- Setters ---
        public void set_quantityInOrder(int qty) { this.quantityInOrder = qty; }
        public void set_pricePerUnit(decimal price) { this.pricePerUnit = price; }

        // --- Database Methods ---
        public void create_item_in_order_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_ItemsInOrders_Insert @orderID, @internalSku, @quantity, @price";

            c.Parameters.AddWithValue("@orderID", this.order != null ? this.order.orderID : 0);
            c.Parameters.AddWithValue("@internalSku", this.item != null ? this.item.get_internalSku() : 0);
            c.Parameters.AddWithValue("@quantity", this.quantityInOrder);
            c.Parameters.AddWithValue("@price", this.pricePerUnit);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void update_item_in_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_ItemsInOrders_Update @orderID, @internalSku, @quantity, @price";

            c.Parameters.AddWithValue("@orderID", this.order != null ? this.order.orderID : 0);
            c.Parameters.AddWithValue("@internalSku", this.item != null ? this.item.get_internalSku() : 0);
            c.Parameters.AddWithValue("@quantity", this.quantityInOrder);
            c.Parameters.AddWithValue("@price", this.pricePerUnit);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}