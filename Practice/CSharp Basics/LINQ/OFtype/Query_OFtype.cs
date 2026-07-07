using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1.CSharp_Basics.LINQ.OFtype
{
    public class student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        internal class Query_OFtype
        {
            public static void Run()
            {
                IList mixlist = new ArrayList();
                mixlist.Add(0);
                mixlist.Add(1);
                mixlist.Add("john");
                mixlist.Add("two");
                mixlist.Add(new student() { Id = 1, Name = "one", Age = 20 });

                var stringresult = from s in mixlist.OfType<string>()
                                   select s;
                foreach(var str in stringresult)
                {
                    Console.WriteLine(str);
                }

                var intresult = from s in mixlist.OfType<int>()
                                select s;
                foreach(var integer in intresult)
                {
                    Console.WriteLine(integer);
                }

                var stdresult = from s in mixlist.OfType<student>()
                                select s;
                foreach(var std in stdresult)
                {
                    Console.WriteLine(std);
                }
        }
        }
    }
}
