using System;
using System.Linq;
namespace coredb
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var db = new db20200831Context();
            var ret = from c in db.TCustomer
                      select c;
//hi
            foreach (var item in ret)
            {
                Console.WriteLine($"{item.FName} - {item.FPhone} - {item.FAddress} ");
            }
        }
    }
}
