using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de 
            //litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros 
            // vendidos y calcule y emita el importe con el descuento  aplicado..

            float importe;
            int litros;

            Console.WriteLine("Ingrese importe");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros vendidos");
            litros = int.Parse(Console.ReadLine());

            if (litros > 500)
            {
                float importeFinal = importe * 0.75F;
                Console.WriteLine("El importe final es " + importeFinal);
            }
            else if (litros > 300 && litros <= 500)
            {
                float importeFinal = importe * 0.85F;
                Console.WriteLine("El importe final es " + importeFinal);
            }
            else if (litros > 100 && litros < 301)
            {
                float importeFinal = importe * 0.90F;
                Console.WriteLine("El importe final es " + importeFinal);
            }
            else
                Console.WriteLine("No hay descuento");
        }
    }
}
