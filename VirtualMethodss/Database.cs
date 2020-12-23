using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    public class Database
    {
        public virtual void  Add()
        {
            Console.WriteLine("Added by default");
        }
        public void Delete()
        {
            Console.WriteLine("Deleted by default");
        }
    }
    class SqlDatabase:Database 
    {
        public override void Add()
        {
            Console.WriteLine("Added by Sql server");
        }
    }
    class MySql:Database 
    {

    }
}
