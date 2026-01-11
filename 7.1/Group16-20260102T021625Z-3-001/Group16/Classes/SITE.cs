using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Group16
{
    public class SITE
{
    // --- 1. Private Fields ---
    private string name;
    private string address;
    private string contactNumber;
    private bool isActive;
    private string contactPerson;
    private REGION region; 
    private List<USER> users;
    private List<ORDER> orders;
    private List<ITEM_IN_SITE_STOCK> itemsInStock;

    // --- 2. Constructor ---
    public SITE(string name, string address, string contactNumber,
            bool isActive, string contactPerson, REGION region, bool is_new)
    {
        this.name = name;
        this.address = address;
        this.contactNumber = contactNumber;
        this.isActive = isActive;
        this.contactPerson = contactPerson;

        this.region = region;
        if (this.region != null)
            this.region.add_site(this);

        this.users = new List<USER>();
        this.itemsInStock = new List<ITEM_IN_SITE_STOCK>();
        this.orders = new List<ORDER>();

        if (is_new)
        {
            this.create_site_to_DB();
            Program.SITES.Add(this);
        }
    }

    // --- 3. Database Methods ---

    public void create_site_to_DB()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.sp_Sites_Insert @name, @address, @contactNumber, @isActive, @contactPerson, @regionName";

        c.Parameters.AddWithValue("@name", this.name); 
        c.Parameters.AddWithValue("@address", this.address);
        c.Parameters.AddWithValue("@contactNumber", this.contactNumber);
        c.Parameters.AddWithValue("@isActive", this.isActive);
        c.Parameters.AddWithValue("@contactPerson", (object)this.contactPerson ?? DBNull.Value);
        c.Parameters.AddWithValue("@regionName", this.region != null ? this.region.get_name() : (object)DBNull.Value);

        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    public void update_site()
    {
        SqlCommand c = new SqlCommand();
        c.CommandText = "EXECUTE dbo.sp_Sites_Update @name, @address, @contactNumber, @isActive, @contactPerson, @regionName";

        c.Parameters.AddWithValue("@name", this.name);
        c.Parameters.AddWithValue("@address", this.address);
        c.Parameters.AddWithValue("@contactNumber", this.contactNumber);
        c.Parameters.AddWithValue("@isActive", this.isActive);
        c.Parameters.AddWithValue("@contactPerson", (object)this.contactPerson ?? DBNull.Value);
        c.Parameters.AddWithValue("@regionName", this.region != null ? this.region.get_name() : (object)DBNull.Value);

        SQL_CON SC = new SQL_CON();
        SC.execute_non_query(c);
    }

    // --- 4. Getters ---
    public string get_name() { return this.name; }
    public string get_address() { return this.address; }
    public string get_contactNumber() { return this.contactNumber; }
    public bool get_isActive() { return this.isActive; }
    public string get_contactPerson() { return this.contactPerson; }
    public REGION get_region() { return this.region; } 

        // --- 5. Helper Methods ---
        public void addUser(USER i) { if (i != null && !this.users.Contains(i)) this.users.Add(i); }
        public void addItemInStock(ITEM_IN_SITE_STOCK i) { if (i != null && !this.itemsInStock.Contains(i)) this.itemsInStock.Add(i); }
        public void addOrder(ORDER i) { if (i != null && !this.orders.Contains(i)) this.orders.Add(i); }
    }
}