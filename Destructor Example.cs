using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorExample
{
    class myClass
    {
        private string name;

        public myClass(string tempName)
        {
            name = tempName;
        }

        ~myClass()
        {
            Console.WriteLine("Deleted a referenceobject of this class. Object name was: {0}.", this.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myClass p1 = new myClass("Test1");
            myClass p2 = new myClass("Test2");

            p2 = null;

            GC.Collect();

            Console.ReadKey();
        }
    }
}
