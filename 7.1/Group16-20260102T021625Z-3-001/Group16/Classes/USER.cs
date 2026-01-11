using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group16
{
    public class USER
    {
        // --- 1. Private Fields ---
        private string userName;
        private string password;
        private string email;
        private bool isActive;
        private ROLE role;
        private List<SITE> sites;
        private List<ORDER> orders;

        // --- 2. Constructor ---
        public USER(string userName, string password, string email, bool isActive, ROLE role, bool is_new)
        {
            this.userName = userName;
            this.password = password;
            this.email = email;
            this.isActive = isActive;
            this.role = role;
            this.sites = new List<SITE>();
            this.orders = new List<ORDER>();

            // Logical check: if it's a new user from UI, save to DB and add to global list
            if (is_new)
            {
                this.create_user_to_DB();
                Program.USERS.Add(this);
            }
        }

        // --- 3. Database Methods ---

        // Adds the current user instance to the SQL database
        public void create_user_to_DB()
        {
            SqlCommand c = new SqlCommand();
            // Updated to match the provided procedure: sp_Users_Insert
            c.CommandText = "EXECUTE dbo.sp_Users_Insert @userName, @password, @email, @isActive, @roleName";

            c.Parameters.AddWithValue("@userName", this.userName);
            c.Parameters.AddWithValue("@password", this.password);

            // Handle optional email field
            c.Parameters.AddWithValue("@email", (object)this.email ?? DBNull.Value);

            c.Parameters.AddWithValue("@isActive", this.isActive);

            // Convert Enum to String and replace underscores with spaces
            c.Parameters.AddWithValue("@roleName", this.role.ToString().Replace("_", " "));

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // Updates the user details in the SQL database
        public void update_user()
        {
            SqlCommand c = new SqlCommand();
            // Updated to match the provided procedure: sp_Users_Update
            c.CommandText = "EXECUTE dbo.sp_Users_Update @userName, @password, @email, @isActive, @roleName";

            c.Parameters.AddWithValue("@userName", this.userName);
            c.Parameters.AddWithValue("@password", this.password);
            c.Parameters.AddWithValue("@email", (object)this.email ?? DBNull.Value);
            c.Parameters.AddWithValue("@isActive", this.isActive);
            c.Parameters.AddWithValue("@roleName", this.role.ToString().Replace("_", " "));

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // --- 4. Getters (Accessors) ---
        public string get_userName() { return this.userName; }
        public string get_password() { return this.password; }
        public string get_email() { return this.email; }
        public bool get_isActive() { return this.isActive; }
        public ROLE get_role() { return this.role; }

        // --- 5. Override ToString ---
        public override string ToString()
        {
            return this.userName;
        }
        public void addSite(SITE i)
        {
            if (i != null && !this.sites.Contains(i))
            {
                this.sites.Add(i);
            }
        }
        public void addOrder(ORDER i)
        {
            if (i != null && !this.orders.Contains(i))
            {
                this.orders.Add(i);
            }
        }
    }
}