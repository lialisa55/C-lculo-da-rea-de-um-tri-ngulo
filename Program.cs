using System;

namespace Área_de_um_Triângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira as medidas dos três lados");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double p = (a + b + c) / 2;
            Console.WriteLine(p);
            double area = (p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("A área do triângulo é: ", area);


        }
    }
}
