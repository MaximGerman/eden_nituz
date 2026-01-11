using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Example_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        //רשימות
        public static System.Collections.Generic.List<Worker> Workers;
        public static System.Collections.Generic.List<Order> Orders;
        [STAThread]

        //שיטה שמחפשת עובד ברשימה לפי תעודת זהות
        public static Worker seekWorker(string id)
        {
            foreach (Worker w in Workers)
            {
                if (w.getID() == id)
                    return w;
            }
            return null;
        }


        public static void initLists()//מילוי הרשימות מתוך בסיס הנתונים
        {
            init_workers();//אתחול הרשימה של העובדים
            init_orders();//אתחול הרשימה של ההזמנות
        }


        public static void init_workers()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.Get_all_Workers";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            
            Workers = new List<Worker>();

            while (rdr.Read())
            {
                Title T = (Title)Enum.Parse(typeof(Title), rdr.GetValue(2).ToString());
                Worker w = new Worker(rdr.GetValue(0).ToString(), rdr.GetValue(1).ToString(), T, false);
                Workers.Add(w);
            }
        }

        public static void init_orders()//מילוי המערך מתוך בסיס הנתונים
        {
            SqlCommand c = new SqlCommand(); 
            c.CommandText = "EXECUTE dbo.Get_all_Orders";
            SQL_CON SC = new SQL_CON();
            SqlDataReader rdr = SC.execute_query(c);
            Orders = new List<Order>();
            while (rdr.Read())
            {
                Order o = new Order(seekWorker(rdr.GetValue(0).ToString()), int.Parse(rdr.GetValue(1).ToString()), DateTime.Parse((rdr.GetValue(2).ToString())), int.Parse(rdr.GetValue(3).ToString()), false);
                Orders.Add(o);
            }
        }


        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            initLists();//אתחול כל הרשימות
            Application.Run(new main_form());
        }
    }
}
