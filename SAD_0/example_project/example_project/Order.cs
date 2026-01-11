// File:    Order.cs
// Author:  ranalm
// Created: ιεν ωπι 12 ξΰι 2014 21:00:31
// Purpose: Definition of Class Order

using System;
using System.Data.SqlClient;

namespace Example_Project
{
    public class Order
    {
        public Worker worker;
        private int orderId;
        private DateTime orderDate;
        private int OrderTotalPrice;

        public Order(Worker w, int Id, DateTime Date, int orderTotalPrice,bool is_new)
        {
            this.orderId = Id;
            this.orderDate = Date;
            this.OrderTotalPrice = orderTotalPrice;
            this.Worker = w;
            if (is_new)
            {
                this.create_order();
                Program.Orders.Add(this);
            }
        }

        public void create_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_order @workerId, @orderId, @orderDate, @orderTotalPrice";
            c.Parameters.AddWithValue("@workerId", this.worker.getID());
            c.Parameters.AddWithValue("@orderId", this.orderId);
            c.Parameters.AddWithValue("@orderDate", this.orderDate);
            c.Parameters.AddWithValue("@OrderTotalPrice", this.OrderTotalPrice);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
               
        public void Update_order()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_worker  @orderId, @OrderTotalPrice";
            c.Parameters.AddWithValue("@orderId", this.orderId);
            c.Parameters.AddWithValue("@OrderTotalPrice", this.OrderTotalPrice);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_order()
        {
            Program.Orders.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_worker @id";
            c.Parameters.AddWithValue("@orderId", this.orderId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }


        /// <summary>
        /// Property for Worker
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Worker Worker
        {
            get
            {
                return worker;
            }
            set
            {
                if (this.worker == null || !this.worker.Equals(value))
                {
                    if (this.worker != null)
                    {
                        Worker oldWorker = this.worker;
                        this.worker = null;
                        oldWorker.RemoveOrders(this);
                    }
                    if (value != null)
                    {
                        this.worker = value;
                        this.worker.AddOrders(this);
                    }
                }
            }
        }

    }
}