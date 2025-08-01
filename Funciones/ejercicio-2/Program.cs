namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        //2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero 
        // si no lo es.
        // Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.

        int n1;
        int cont = 0;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());

            if (Par(n1))
                cont++;
        }

        Console.WriteLine(cont + " Fueron pares");

    }

    static bool Par(int n1)
    {
        if (n1 % 2 == 0)
            return true;
        else
            return false;
    }
}
