using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompTimeSimpleConsoleApplication;

namespace CompTimeSimpleConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new LeaveTimeContext())
            {
                var entry1 = new Entry
                {
                    PayPeriod = 2,
                    Hours = 40,
                };

                ctx.Entries.Add(entry1);

                var entry2 = new Entry
                {
                    PayPeriod = 23,
                    Hours = 88,
                };

                ctx.Entries.Add(entry2);
                ctx.SaveChanges();

                // Display all Entries from the database 
                var query = (from e in ctx.Entries
                               orderby e.PayPeriod
                               select e).ToList<Entry>();
                Console.WriteLine("Converted Comp Time Entries:");

                foreach (var item in query)
                {
                    Console.WriteLine("You added {0} hours from Pay Period {1}", // for a total of: { 2} hours", //, item.Hours.
                        item.Hours, item.PayPeriod);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
