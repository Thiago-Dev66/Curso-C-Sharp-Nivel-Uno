using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
            //el máximo de los números pares y el mínimo de los números impares.

            int n;
            int x = 0;
            int par = 0;
            int imp = 0;
            bool b = false;
            bool b2 = false;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while (x < 20)
            {
                if (n % 2 == 0)
                {
                    if (!b)
                    {
                        par = n;
                        b = true;
                    }
                    else if (n > par)
                        par = n;
                }
                else
                {
                    if (!b2)
                    {
                        imp = n;
                        b2 = true;
                    }
                    else if (n < imp)
                        imp = n;
                }
                x++;
                Console.WriteLine("Ingrese otro");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("El mayor par es " + par + " y el menor impar es " + imp);
        }
    }
}
