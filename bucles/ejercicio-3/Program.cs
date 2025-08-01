using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Hacer un programa que solicite 20 edades y luego calcule el 
            // promedio de edad de aquellas personas mayores a 18 años.

            int edad;
            float promedio;
            int acu = 0;
            int mayores = 0;

            for (int x = 0; x < 20; x++)
            {
                Console.WriteLine("Ingrese su edad");
                edad = int.Parse(Console.ReadLine());

                if (edad > 18)
                {
                    acu += edad;
                    mayores++;
                }
            }
            promedio = acu / mayores;

            Console.WriteLine("El promedio es " + promedio);

        }
    }
}
