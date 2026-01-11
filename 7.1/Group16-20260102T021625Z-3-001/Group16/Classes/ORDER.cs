using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class ORDER
    {
        // --- 1. Properties ---
        public int orderID { get; set; }
        public DateTime creationDate { get; set; }
        public string status { get; set; }
        public decimal totalPrice { get; set; }
        public DateTime? deliveryDate { get; set; }
        public string siteName { get; set; }
        public SUPPLIER OrderSupplier{ get; set; }
        public USER openedBy { get; set; }// The user who opened the order

        private List<ITEM_IN_ORDER> itemsInOrder;



        public static int ID = 10;


        // --- 2. Constructors ---
        public ORDER() { }

        public ORDER(int orderID, DateTime creationDate, string status,
                      decimal totalPrice, DateTime? deliveryDate, string siteName, bool is_new, SUPPLIER orderSupplier, USER openedBy)
        {
            this.orderID = orderID;
            this.creationDate = creationDate;
            this.status = status;
            this.totalPrice = totalPrice;
            this.deliveryDate = deliveryDate;
            this.siteName = siteName;
            this.OrderSupplier = orderSupplier;
            this.openedBy = openedBy;
            this.itemsInOrder = new List<ITEM_IN_ORDER>();
            // Logic for new orders: save to DB and add to global list
            if (is_new)
            {
                this.create_order_to_DB();
                Program.ORDERS.Add(this);
            }
        }

        // --- 3. Database Methods ---

        // Adds the order to the database
        public void create_order_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Orders_Insert @orderID, @creationDate, @status, @totalPrice, @deliveryDate, @siteName, @supplierName, @openedBy";

            c.Parameters.AddWithValue("@orderID", this.orderID);
            c.Parameters.AddWithValue("@creationDate", this.creationDate);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@totalPrice", this.totalPrice);
            c.Parameters.AddWithValue("@deliveryDate", (object)this.deliveryDate ?? DBNull.Value);
            c.Parameters.AddWithValue("@siteName", this.siteName);
            c.Parameters.AddWithValue("@supplierName", this.OrderSupplier != null ? this.OrderSupplier.get_supplierName() : (object)DBNull.Value);
            c.Parameters.AddWithValue("@openedBy", this.openedBy != null ? this.openedBy.get_userName() : (object)DBNull.Value);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // Updates order details (status, price, delivery)
        public void update_order()
        {
            SqlCommand c = new SqlCommand();
            // Matches: dbo.sp_Orders_Update @orderID, @status, @totalPrice, @deliveryDate
            c.CommandText = "EXECUTE dbo.sp_Orders_Update @orderID, @status, @totalPrice, @deliveryDate";

            c.Parameters.AddWithValue("@orderID", this.orderID);
            c.Parameters.AddWithValue("@status", this.status);
            c.Parameters.AddWithValue("@totalPrice", this.totalPrice);
            c.Parameters.AddWithValue("@deliveryDate", (object)this.deliveryDate ?? DBNull.Value);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
        public void addItemInOrder(ITEM_IN_ORDER i)
        {
            if (i != null && !this.itemsInOrder.Contains(i))
            {
                this.itemsInOrder.Add(i);
            }
        }


        public static int getNextID()
        {
            return ID++;
        }
    }
}