using System;

namespace Ejercicios_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Calcular el cubo de un número ingresado por el usuario. 
            float n1;

            Console.WriteLine("Ingrese un numero: ");
            n1 = float.Parse(Console.ReadLine());

            float potencia = n1 * n1 * n1;

            Console.WriteLine("el resultado es: " + potencia);

            //ejercicio 2: 

            Console.WriteLine("Ingrese la cantidad de kilometros:");
            float Km = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad promedio del vehiculo:");
            float velocidad = float.Parse(Console.ReadLine());

            float tiempo = Km / velocidad;

            Console.WriteLine("El tiempo de viaje es de " + tiempo.ToString("0.00")/*'ToString: expresa el resultado en 
            texto y se especifica el formato de los decimales por medio de un parametro' */ + " horas.");

            //ejercicio 3: 
            const float sueldo = 15000;
            const float comision = 0.05F;

            Console.WriteLine("Ingrese el total facturado:");
            float TotalFacturado = float.Parse(Console.ReadLine());

            float Sueldo = (TotalFacturado * comision) + sueldo;

            Console.WriteLine("El sueldo del vendedor es de: " + Sueldo.ToString("00000") + " pesos.");

            //ejercicio 4:

            float n1;   //ctrl+d = duplicar la línea, ctrl+shift+l o f2 = seleccionar todas las ocurrencias de la palabra 
            float n2;
            float n3;
            float promedio;

            Console.WriteLine("Ingrese nota 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota 3: ");
            n3 = float.Parse(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3.0F; // Usar 3.0F para asegurar que la división sea en punto flotante

            Console.WriteLine("El promedio es: " + promedio.ToString("0.00") + " puntos.");             


        }
    }
}
