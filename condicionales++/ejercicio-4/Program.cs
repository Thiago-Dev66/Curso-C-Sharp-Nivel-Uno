using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar tres números y emitir un cartel aclaratorio 
            // si la suma de los dos primeros es mayor al producto del segundo con el tercero.

            int a, b, c;

            Console.WriteLine("Ingrese un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último");
            c = int.Parse(Console.ReadLine());

            int suma = a + b;
            int producto = b * c;

            if (suma > producto)
                Console.WriteLine("La suma es mayor");
            else
                Console.WriteLine("No es mayor");
        }
    }
}
