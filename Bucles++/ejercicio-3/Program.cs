using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. 
            // El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            int n;
            int contNumeros = 0;
            int lista = 0;

            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            while (n >= 0)
            {
                lista++;
                contNumeros = 0;

                while (n > 0)
                {
                    contNumeros++;

                    Console.WriteLine("Ingrese un número");
                    n = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("La lista " + lista + " tiene " + contNumeros + " numeros");
            
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());
            }
        }   
    }    
}
