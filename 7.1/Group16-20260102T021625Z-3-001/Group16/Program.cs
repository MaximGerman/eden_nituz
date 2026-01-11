using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group16
{
    public static class Program
    {
        // Global Lists (Database in RAM)
        public static List<SUPPLIER> SUPPLIERS;
        public static List<ITEM> ITEMS;
        public static List<SITE> SITES;
        public static List<REGION> REGIONS;
        public static List<USER> USERS;
        public static List<ITEM_IN_ORDER> ITEM_IN_ORDERS;
        public static List<ITEM_IN_SITE_STOCK> ITEM_IN_SITE_STOCKS;
        public static List<ORDER> ORDERS;
        public static List<SHIPPING> SHIPPINGS;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1. Load all data (SQL -> RAM)
            initLists();

            // 2. Open Main Form
            Application.Run(new HomeScreen());
        }

        public static void initLists()
        {
            // The order is important! Load lookup/parent tables first
            init_REGIONS();
            init_SUPPLIERS();
            init_SITES();
            init_USERS();
            init_ITEMS();
            init_ORDERS();
            init_SHIPPINGS();
            init_ITEM_IN_ORDERS();
            init_ITEM_IN_SITE_STOCKS();
            init_UsersSites();
        }

        // ==================== INIT METHODS ====================

        public static void init_REGIONS()
        {
            REGIONS = new List<REGION>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Regions_Select";

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    REGION r = new REGION(rdr.GetValue(0).ToString(), false);
                    REGIONS.Add(r);
                }
                rdr.Close();
            }
        }

        public static void init_SUPPLIERS()
        {
            SUPPLIERS = new List<SUPPLIER>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Suppliers_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    SUPPLIER_STATUS status = (SUPPLIER_STATUS)Enum.Parse(
                        typeof(SUPPLIER_STATUS), rdr.GetValue(1).ToString());

                    string activityFromDB = rdr.GetValue(2).ToString().Replace(" ", "_");
                    SUPPLIER_ACTIVITY activity = (SUPPLIER_ACTIVITY)Enum.Parse(
                        typeof(SUPPLIER_ACTIVITY), activityFromDB);

                    SUPPLIER s = new SUPPLIER(
                        rdr.GetValue(0).ToString(),
                        status,
                        activity,
                        rdr.GetValue(3).ToString(),
                        rdr.GetValue(4).ToString(),
                        decimal.Parse(rdr.GetValue(5).ToString()),
                        bool.Parse(rdr.GetValue(6).ToString()),
                        false
                    );

                    SUPPLIERS.Add(s);
                }
                rdr.Close();
            }
        }

        public static void init_SITES()
        {
            SITES = new List<SITE>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Sites_Select";

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    REGION r = seekRegion(rdr.GetValue(5).ToString());

                    string contactPerson = "";
                    if (rdr.GetValue(4) != DBNull.Value)
                    {
                        contactPerson = rdr.GetValue(4).ToString();
                    }

                    SITE s = new SITE(
                        rdr.GetValue(0).ToString(),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2).ToString(),
                        bool.Parse(rdr.GetValue(3).ToString()),
                        contactPerson,
                        r,
                        false
                    );

                    SITES.Add(s);
                }
                rdr.Close();
            }
        }

        public static void init_USERS()
        {
            USERS = new List<USER>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Users_Select";

            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    string roleStr = rdr.GetValue(4).ToString().Replace(" ", "");
                    ROLE userRole = (ROLE)Enum.Parse(typeof(ROLE), roleStr, true);

                    USER u = new USER(
                        rdr.GetValue(0).ToString(),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2).ToString(),
                        bool.Parse(rdr.GetValue(3).ToString()),
                        userRole,
                        false
                    );

                    USERS.Add(u);
                }
                rdr.Close();
            }
        }

        public static void init_ITEMS()
        {
            ITEMS = new List<ITEM>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Items_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    string supplierName = rdr.GetValue(6).ToString();
                    SUPPLIER sup = seekSupplier(supplierName);

                    // Handle nullable supplierSku
                    int supplierSku = 0;
                    if (rdr.GetValue(4) != DBNull.Value)
                    {
                        supplierSku = int.Parse(rdr.GetValue(4).ToString());
                    }

                    ITEM i = new ITEM(
                        int.Parse(rdr.GetValue(0).ToString()),
                        rdr.GetValue(1).ToString(),
                        rdr.GetValue(2) != DBNull.Value ? rdr.GetValue(2).ToString() : "",
                        rdr.GetValue(3) != DBNull.Value ? rdr.GetValue(3).ToString() : "",
                        supplierSku,
                        decimal.Parse(rdr.GetValue(5).ToString()),
                        sup,
                        bool.Parse(rdr.GetValue(7).ToString()),
                        false
                    );

                    ITEMS.Add(i);
                }
                rdr.Close();
            }
        }

        public static void init_ORDERS()
        {
            ORDERS = new List<ORDER>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Orders_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    SITE site = seekSite(rdr.GetValue(5).ToString());
                    SUPPLIER sup = seekSupplier(rdr.GetValue(6).ToString());
                    USER user = seekUser(rdr.GetValue(7).ToString());

                    DateTime? deliveryDate = null;
                    if (rdr.GetValue(4) != DBNull.Value)
                    {
                        deliveryDate = DateTime.Parse(rdr.GetValue(4).ToString());
                    }

                    ORDER o = new ORDER(
                        int.Parse(rdr.GetValue(0).ToString()),
                        DateTime.Parse(rdr.GetValue(1).ToString()),
                        rdr.GetValue(2).ToString(),
                        decimal.Parse(rdr.GetValue(3).ToString()),
                        deliveryDate,
                        rdr.GetValue(5).ToString(),
                        false,
                        sup,
                        user
                    );

                    // Link order to site, supplier, and user
                    if (site != null) site.addOrder(o);
                    if (sup != null) sup.addOrder(o);
                    if (user != null) user.addOrder(o);

                    ORDERS.Add(o);
                }
                rdr.Close();
            }
        }

        public static void init_SHIPPINGS()
        {
            SHIPPINGS = new List<SHIPPING>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_Shippings_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    SUPPLIER sup = seekSupplier(rdr.GetValue(1).ToString());
                    REGION reg = seekRegion(rdr.GetValue(2).ToString());

                    string hours = "";
                    if (rdr.GetValue(4) != DBNull.Value)
                    {
                        hours = rdr.GetValue(4).ToString();
                    }

                    SHIPPING sh = new SHIPPING(
                        int.Parse(rdr.GetValue(0).ToString()),
                        sup,
                        reg,
                        rdr.GetValue(3).ToString(),
                        hours,
                        false
                    );

                    SHIPPINGS.Add(sh);
                }
                rdr.Close();
            }
        }

        public static void init_ITEM_IN_ORDERS()
        {
            ITEM_IN_ORDERS = new List<ITEM_IN_ORDER>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_ItemsInOrders_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    ORDER order = seekOrder(int.Parse(rdr.GetValue(0).ToString()));
                    ITEM item = seekItem(int.Parse(rdr.GetValue(1).ToString()));

                    ITEM_IN_ORDER iio = new ITEM_IN_ORDER(
                        order,
                        item,
                        int.Parse(rdr.GetValue(2).ToString()),
                        decimal.Parse(rdr.GetValue(3).ToString()),
                        false
                    );

                    ITEM_IN_ORDERS.Add(iio);
                }
                rdr.Close();
            }
        }

        public static void init_ITEM_IN_SITE_STOCKS()
        {
            ITEM_IN_SITE_STOCKS = new List<ITEM_IN_SITE_STOCK>();

            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_SiteItemStocks_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    SITE site = seekSite(rdr.GetValue(0).ToString());
                    ITEM item = seekItem(int.Parse(rdr.GetValue(1).ToString()));

                    ITEM_IN_SITE_STOCK stock = new ITEM_IN_SITE_STOCK(
                        site,
                        item,
                        int.Parse(rdr.GetValue(2).ToString()),
                        int.Parse(rdr.GetValue(3).ToString()),
                        false
                    );

                    ITEM_IN_SITE_STOCKS.Add(stock);
                }
                rdr.Close();
            }
        }

        public static void init_UsersSites()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.sp_UsersSites_Select";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);

            if (rdr != null)
            {
                while (rdr.Read())
                {
                    string uName = rdr.GetString(0);
                    string sName = rdr.GetString(1);

                    USER u = seekUser(uName);
                    SITE s = seekSite(sName);

                    if (u != null && s != null)
                    {
                        u.addSite(s);
                        s.addUser(u);
                    }
                }
                rdr.Close();
            }
        }

        // ==================== SEEK/FIND METHODS ====================

        public static REGION seekRegion(string name)
        {
            if (REGIONS == null) return null;
            foreach (REGION r in REGIONS)
            {
                if (r.get_name() == name)
                    return r;
            }
            return null;
        }

        public static SUPPLIER seekSupplier(string name)
        {
            if (SUPPLIERS == null) return null;
            foreach (SUPPLIER s in SUPPLIERS)
            {
                if (s.get_supplierName() == name)
                    return s;
            }
            return null;
        }

        public static SITE seekSite(string name)
        {
            if (SITES == null) return null;
            foreach (SITE s in SITES)
            {
                if (s.get_name() == name)
                    return s;
            }
            return null;
        }

        public static USER seekUser(string userName)
        {
            if (USERS == null) return null;
            foreach (USER u in USERS)
            {
                if (u.get_userName() == userName)
                    return u;
            }
            return null;
        }

        public static ITEM seekItem(int sku)
        {
            if (ITEMS == null) return null;
            foreach (ITEM i in ITEMS)
            {
                if (i.get_internalSku() == sku)
                    return i;
            }
            return null;
        }

        public static ORDER seekOrder(int orderID)
        {
            if (ORDERS == null) return null;
            foreach (ORDER o in ORDERS)
            {
                if (o.orderID == orderID)
                    return o;
            }
            return null;
        }
    }
}

