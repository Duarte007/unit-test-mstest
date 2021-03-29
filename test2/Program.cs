using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using classes;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Triangle t1 = new Triangle(5, 10, 9);
                Console.WriteLine("Esse é um triângulo: " + t1.getType());
                Triangle t2= new Triangle(20, 15, 5);
                Console.ReadKey();
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }


    }
}
