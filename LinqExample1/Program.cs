using System;
using System.Collections.Generic;
using System.Linq;//If you want to use LINQ in your class, you need to include/import this namespace
using System.Text;
using System.Threading.Tasks;

namespace LinqExample1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };//Here assign the data to list.
//LinqSyntax:var query=from object in datasource
                     //where condition
                     //Select object;
            var query = from obj in list
                        where obj > 2
                        select obj;//select * fom list
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
