using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompTimeSimpleConsoleApplication
{
    public class Entry
    {
       // public Entry()
       // {        }
        public int EntryID { get; set; }
        public int PayPeriod { get; set; }
        public int Hours { get; set; }
        public bool Expired { get; set; }
        public bool Requested { get; set; }
    }
}
