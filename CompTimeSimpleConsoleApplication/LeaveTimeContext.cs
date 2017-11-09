using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;


namespace CompTimeSimpleConsoleApplication
{
    public class LeaveTimeContext : DbContext
    {
        public LeaveTimeContext() : base() { } //"LeaveTimeContext"

        public virtual DbSet<Entry> Entries { get; set; }
       

    }
}