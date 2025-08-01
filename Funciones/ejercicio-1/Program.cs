using System.Numerics;

namespace ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        //1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva 
        // el producto de ambos. 
        // Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
        // muestre por pantalla el monto total a pagar. Usar la función.

        int precio;
        int cantidad;

        Console.WriteLine("Ingrese precio");
        precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese cantidad");
        cantidad = int.Parse(Console.ReadLine());

        int total = Producto(precio, cantidad);

        Console.WriteLine("El total a pagar es " + total);
    }

    static int Producto(int n1, int n2)
    {
        int producto = n1 * n2;
        return producto;
    }
}
