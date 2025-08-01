using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            int n1;
            int n2;
            int n3;
            int n4;

            Console.WriteLine("ingrese un número");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un número");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un número");
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un número");
            n4 = int.Parse(Console.ReadLine());

            if (n1 > 100)
                Console.WriteLine(n1 + " Es mayor a 100");
            if (n2 > 100)
                Console.WriteLine(n2 + " Es mayor a 100");
            if (n3 > 100)
                Console.WriteLine(n3 + " Es mayor a 100");
            if (n4 > 100)
                Console.WriteLine(n4 + " Es mayor a 100");
            else
            {
                Console.WriteLine("Ninguno es mayor a 100");
            }
        }
    }
}
