using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            database.Add();
            
            SqlDatabase sqlDatabase = new SqlDatabase();
            sqlDatabase.Add();
            Console.Read();
        }
    }
}
