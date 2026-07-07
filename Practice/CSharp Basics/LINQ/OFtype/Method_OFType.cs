using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.CSharp_Basics.LINQ.OFtype
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age {  get; set; }
    }
    internal class Method_OFType
    {
        public static void Run()
        {
            IList mixed = new ArrayList();
            mixed.Add("a");
            mixed.Add(0);
            mixed.Add("b");
            mixed.Add(1);
            mixed.Add(new employee() { Id = 1, Name = "Hardik", Age = 20 });

            var strresult = mixed.OfType<string>();
            foreach (var item in strresult)
            {
                Console.WriteLine(item);
            }

            var intresult = mixed.OfType<int>();
            foreach(var item in intresult)
            {
                Console.WriteLine(item);
            }

            var clas = mixed.OfType<employee>();
            foreach(var item in clas)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
