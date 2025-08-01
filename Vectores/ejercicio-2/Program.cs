namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        // 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
        // Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores
        // que son mayores al promedio.

        int[] numeros = new int[10];
        int acu = 0;
        double promedio = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero");
            numeros[x] = int.Parse(Console.ReadLine());
        }
        for (int y = 0; y < 10; y++)
        {
            acu += numeros[y];
        }

        promedio = acu / 10;

        for (int z = 0; z < 10; z++)
        {
            if (numeros[z] > promedio)
                Console.WriteLine(numeros[z] + " Es mayor al promedio");
        }

        Console.WriteLine("El promedio es " + promedio);

    }
}
