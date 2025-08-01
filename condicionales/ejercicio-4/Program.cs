using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

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

            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    if (n1 < n4)
                        Console.WriteLine("El menor es " + n1);
                    else
                        Console.WriteLine("El menor es " + n4);
                }
                else if (n3 < n4)
                    Console.WriteLine("El menor es " + n3);
                else
                    Console.WriteLine("El menor es " + n4);
            }
            else if (n2 < n3)
            {
                if (n2 < n4)
                    Console.WriteLine("El menor es " + n2);
                else
                    Console.WriteLine("El menor es " + n4);
            }
            else if (n3 < n4)
                Console.WriteLine("El menor es " + n3);
            else
                Console.WriteLine("El menor es " + n4);
        }
    }
}
