using System;

namespace Área_de_um_Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as medidas dos três lados");
            string l1 = Console.ReadLine();
            string l2 = Console.ReadLine();
            string l3 = Console.ReadLine();
            Convert.ToInt32(l1);
            Convert.ToInt32(l2);
            Convert.ToInt32(l3);

            


            int p = (l1 + l2 + l3) / 2;


        }
    }
}
