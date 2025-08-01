using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Hacer un programa que solicite el ingreso de 10 números
            //y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int n;
            int Mayor = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Digite un número");
                n = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    Mayor = n;
                }
                else if (n > Mayor)
                {
                    Mayor = n;
                }
            }

            Console.Write("El mayor es " + Mayor);
        }
    }
}
