namespace ejercicio_3_while;

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

        char[] frase = new char[30];
        int indice = 0;
        char j;
        char f;

        Console.WriteLine("Escriba una frase letra por letra (finalice con punto)");
        frase[0] = char.Parse(Console.ReadLine());

        while (frase[indice] != '.' && indice < 30)
        {
            indice++;

            Console.WriteLine("Escriba otra letra");
            frase[indice] = char.Parse(Console.ReadLine());
        }

        frase[indice] = '\0';
        indice = 0;

        while (frase[indice] != '\0')
        {
            Console.Write(frase[indice]);
            indice++;
        }

        Console.WriteLine(" Ingrese caracter a remplazar");
        j = char.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese nuevo caracter");
        f = char.Parse(Console.ReadLine());

        for (int x = 0; x < indice; x++)
        {
            if (frase[x] == j)
                frase[x] = f;
        }
        
        indice = 0;
        
        while (frase[indice] != '\0')
        {
            Console.Write(frase[indice]);
            indice++;
        }
    }
}
