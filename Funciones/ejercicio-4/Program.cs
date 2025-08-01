namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        //4. Hacer una función de tipo void (porque no va a devolver nada) llamada “positivoNegativoCero” que 
        // reciba un número por valor y una variable por referencia. 
        // Que analice el número y escriba variable recibida por referencia con:

        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        int m = 0;
        int n;

        Console.WriteLine("Ingrese un numero");
        n = int.Parse(Console.ReadLine());

        PositivoNegativoCero(n, ref m);

        switch (m)
        {
            case 1:
                Console.WriteLine(n + " Es positivo");
                break;
            case -1:
                Console.WriteLine(n + " Es negativo");
                break;
            case 0:
                Console.WriteLine(n + " Es cero");
                break;
        }
    }

    static void PositivoNegativoCero(int n, ref int m)
    {
        if (n > 0)
            m = 1;
        else if (n < 0)
            m = -1;
    }
}
