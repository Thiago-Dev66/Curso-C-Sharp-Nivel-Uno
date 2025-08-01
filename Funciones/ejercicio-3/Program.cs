namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        //3. Hacer una función llamada “primo” que reciba un número entero y 
        // devuelva 1 si el número es primo o cero si no lo es. 
        // Hacer un programa para ingresar números. 
        // El lote corta cuando se ingresa un número cero. 
        // Informar el promedio teniendo en cuenta sólo los números primos.

        int a;
        int acu = 0;
        int cont = 0;
        double promedio;

        Console.WriteLine("Ingrese un numero");
        a = int.Parse(Console.ReadLine());

        while (a != 0)
        {
            if (Primo(a))
            {
                acu += a;
                cont++;
            }

            Console.WriteLine("Ingrese otro...");
            a = int.Parse(Console.ReadLine());
        }

        if (cont > 0)
            promedio = (double)acu / (double)cont;
        else
            promedio = 0;

        Console.WriteLine("El promedio de numeros primos es " + promedio.ToString("0.00"));    
    }

    static bool Primo(int a)
    {
        int primo = 0;

            for (int y = 1; y <= a; y++)
            {
                if (a % y == 0)
                    primo++;
            }

        if (primo == 2)
            return true;
        else
            return false;
    }
}
