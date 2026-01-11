using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group16
{
    public class REGION
    {
        // --- Fields ---
        private string name;
        private List<SITE> sites;
        private List<SHIPPING> shippings;

        // --- Constructor ---
        public REGION(string name, bool is_new)
        {
            this.name = name;
            this.sites = new List<SITE>();
            this.shippings = new List<SHIPPING>();

            if (is_new)
            {
                this.create_region_to_DB();
                Program.REGIONS.Add(this);
            }
        }

        // --- Database Methods ---
        public void create_region_to_DB()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Regions_Insert @Name";
            c.Parameters.AddWithValue("@Name", this.name);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        // --- Association Methods ---
        public void add_site(SITE s)
        {
            if (s != null && !this.sites.Contains(s))
            {
                this.sites.Add(s);
            }
        }

        public void addShipping(SHIPPING sh)
        {
            if (sh != null && !this.shippings.Contains(sh))
            {
                this.shippings.Add(sh);
            }
        }

        // --- Getters ---
        public string get_name() { return this.name; }
        public List<SITE> getSites() { return this.sites; }
        public List<SHIPPING> getShippings() { return this.shippings; }

        // Get suppliers that ship to this region (through shippings)
        public List<SUPPLIER> getSuppliers()
        {
            List<SUPPLIER> suppliers = new List<SUPPLIER>();
            foreach (SHIPPING sh in this.shippings)
            {
                SUPPLIER sup = sh.get_supplier();
                if (sup != null && !suppliers.Contains(sup))
                {
                    suppliers.Add(sup);
                }
            }
            return suppliers;
        }
    }
}