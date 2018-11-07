

using System;

namespace odin_raz_ne_pidoras
{
    class Program
    {
        static void Main(string[] args)
        {
            Pidr z = new Pidr();
            string pidrName = Console.ReadLine();
            z.setname(pidrName);


            Console.WriteLine("pidrName is "+ z.getname());

            Console.ReadKey();
          
        }
    }
}
