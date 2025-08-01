namespace ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        // 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
        // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan 
        // sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:

        // CADENA FUENTE: “La mar estaba serena"
        // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
        // CADENA RESULTADO: “Li mir estibi sereni".

        char[] letras = new char[10];
        char l1;
        char l2;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("ingrese letras");
            letras[x] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("ingrese una letra");
        l1 = char.Parse(Console.ReadLine());

        Console.WriteLine("ingrese otra letra");
        l2 = char.Parse(Console.ReadLine());

        for (int x = 0; x < 10; x++)
        {
            if (letras[x] == l1)
            {
                letras[x] = l2;
            }
        }

        Console.WriteLine(letras);
    }
}
