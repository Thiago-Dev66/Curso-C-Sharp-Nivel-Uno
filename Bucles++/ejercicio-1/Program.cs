using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa para ingresar 10 números. 
            // El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            int n;
            int cont = 0;
            int contP = 0;

            Console.WriteLine("Ingrese un numero");
            n = int.Parse(Console.ReadLine());

            for (int x = 0; x < 10; x++)
            {
                cont = 0;
                
                for (int y = 1; y <= n; y++)
                {
                    if (n % y == 0)
                        cont++;
                }
                if (cont == 2)
                    contP++;

                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(contP + " fueron primos");
        }
    }
}
