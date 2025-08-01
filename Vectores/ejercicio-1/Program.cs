namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        // 1.Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
        // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

        int[] numeros = new int[10];
        int maximo = 0;
        int pos = 0;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese un numero");
            numeros[x] = int.Parse(Console.ReadLine());
        }

        for (int y = 0; y < 10; y++)
        {
            if (y == 0)
            {
                maximo = numeros[y];
                pos = y;
            }
            else if (numeros[y] > maximo)
            {
                maximo = numeros[y];
                pos = y; 
            }
        }

        Console.WriteLine("El mayor es " + maximo + " y su posicon fue " + (pos + 1));
    }
}   