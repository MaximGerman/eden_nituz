// File:    Worker.cs
// Author:  ranalm
// Created: ιεν ωπι 12 ξΰι 2014 21:00:31
// Purpose: Definition of Class Worker

using System;
using System.Data.SqlClient;

namespace Example_Project
{
    public class Worker
    {
        private string WorkerId;
        private string WorkerName;
        private Title workerTitle;

        public Worker(string id, string name, Title title, bool is_new)
        {
            this.WorkerId = id;
            this.WorkerName = name;
            this.workerTitle = title;
            if (is_new)
            {
                this.create_worker();
                Program.Workers.Add(this);
            }
        }

        public string get_name()
        {
            return this.WorkerName;
        }

        public Title get_title()
        {
            return this.workerTitle;
        }

        public void set_name(string name)
        {
            this.WorkerName = name; ;
        }

        public void set_title(Title t)
        {
             this.workerTitle=t;
        }

        public System.Collections.Generic.List<Order> orders;

        /// <summary>
        /// Property for collection of Order
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Order> Orders
        {
            get
            {
                if (orders == null)
                    orders = new System.Collections.Generic.List<Order>();
                return orders;
            }
            set
            {
                RemoveAllOrders();
                if (value != null)
                {
                    foreach (Order oOrder in value)
                        AddOrders(oOrder);
                }
            }
        }

        /// <summary>
        /// Add a new Order in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddOrders(Order newOrder)
        {
            if (newOrder == null)
                return;
            if (this.orders == null)
                this.orders = new System.Collections.Generic.List<Order>();
            if (!this.orders.Contains(newOrder))
            {
                this.orders.Add(newOrder);
                newOrder.Worker = this;
            }
        }

        /// <summary>
        /// Remove an existing Order from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveOrders(Order oldOrder)
        {
            if (oldOrder == null)
                return;
            if (this.orders != null)
                if (this.orders.Contains(oldOrder))
                {
                    this.orders.Remove(oldOrder);
                    oldOrder.Worker = null;
                }
        }

        /// <summary>
        /// Remove all instances of Order from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllOrders()
        {
            if (orders != null)
            {
                System.Collections.ArrayList tmpOrders = new System.Collections.ArrayList();
                foreach (Order oldOrder in orders)
                    tmpOrders.Add(oldOrder);
                orders.Clear();
                foreach (Order oldOrder in tmpOrders)
                    oldOrder.Worker = null;
                tmpOrders.Clear();
            }
        }

        public string getID()
        {
            return this.WorkerId;
        }

        public void create_worker()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE SP_add_worker @id, @name, @title";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            c.Parameters.AddWithValue("@name", this.WorkerName);
            c.Parameters.AddWithValue("@title", this.workerTitle.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Update_worker()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_worker  @id, @name, @title";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            c.Parameters.AddWithValue("@name", this.WorkerName);
            c.Parameters.AddWithValue("@title", this.workerTitle.ToString());
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void Delete_worker()
        {
            Program.Workers.Remove(this);
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_delete_worker @id";
            c.Parameters.AddWithValue("@id", this.WorkerId);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

    }
}