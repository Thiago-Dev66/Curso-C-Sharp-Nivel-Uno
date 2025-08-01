using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int a;
            int b;

            Console.WriteLine("Ingrese un número");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                int resta = a - b;
                Console.WriteLine(resta);
            }
            else if (a == b)
            {
                int suma = a + b;
                Console.WriteLine(suma);
            }
            else
            {
                int producto = a * b;
                Console.WriteLine(producto);
            }
        }
    }
}
