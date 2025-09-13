namespace Ejercicio_1;

class Program
{
    static void Main(string[] args)
    {
        /*1. Una empresa que fabrica 20 artículos tiene la siguiente información para cada uno de ellos:
                - Código de Artículo (4 dígitos, no correlativos).
                - Precio Unitario.
            Este primer lote no se encuentra ordenado.
            Cuenta por otro lado con un lote de registros con las ventas del año anterior. Cada registro contiene
            la siguiente información:
                - Número de Cliente (1 a 300).
                - Código de Artículo (4 dígitos no correlativos).
                - Mes (1 a 12).
                - Día (1 a 31).
                - Cantidad vendida.
            Puede haber más de un registro para el mismo artículo. El lote finaliza con un registro con número de
            cliente igual a cero.
            Se pide:
                a) Un listado con el siguiente formato:
                Código de Artículo - Cantidad Total Vendida (Monto en $)
                999                  999
                Este listado debe salir ordenado de mayor a menor por cantidad total vendida.
                b) Informar, si los hubiera, los nombres de los meses en que no hubo ventas.
                c) Informar los códigos de los artículos cuyas ventas en cantidad son mayores al promedio.*/

        //Lote uno:

        int[] codigoArticulo = new int[20];
        int[] precioUnitario = new int[20];

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese el codigo del articulo");
            codigoArticulo[x] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio");
            precioUnitario[x] = int.Parse(Console.ReadLine());
        }

        double promedio = 0;
        int[] acuVentasCantidad = new int[20];
        int[] acuMontoTotal = new int[20];
        int[] boolVentaMes = new int[12];
        int[] meses = new int[12];
        string[] mesesLiteral = new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

        for (int x = 0; x < 12; x++)
        {
            boolVentaMes[x] = 0;
        }

        for (int x = 0; x < 12; x++)
        {
            meses[x] = x + 1;
        }

        Console.WriteLine("Ingrese las ventas del año anterior:");
        Console.WriteLine("Numero de cliente:");
        int nDeCliente = int.Parse(Console.ReadLine());

        //Lote dos:

        while (nDeCliente != 0)
        {
            //Ingreso de datos:
            Console.WriteLine("Codigo de articulo:");
            int codArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Mes:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Dia");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Cantidad vendida");
            int cantidadVendida = int.Parse(Console.ReadLine());

            //Punto a:

            for (int x = 0; x < 20; x++)
            {
                if (codArticulo == codigoArticulo[x])
                    acuMontoTotal[x] += cantidadVendida * precioUnitario[x];
            }

            //Punto b:

            for (int x = 0; x < 12; x++)
            {
                if (mes == meses[x] && cantidadVendida > 0)
                {
                    boolVentaMes[x] = 1;
                }
            }

            //Punto c:
    
            for (int x = 0; x < 20; x++)
            {
                if (codArticulo == codigoArticulo[x])
                    acuVentasCantidad[x] += cantidadVendida;
            }

            Console.WriteLine("Numero de cliente:");
            nDeCliente = int.Parse(Console.ReadLine());
        }

        //Egreso de informacion:
        //Parte a:

        OrdenarVectorMayorAMenor(acuMontoTotal, codigoArticulo);

        Console.WriteLine("Articulos y cantidad total vendida:");
        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine($"{codigoArticulo[x]} - {acuMontoTotal[x]}");
        }

        //Parte b:

        for (int x = 0; x < 12; x++)
        {
            if (boolVentaMes[x] == 0)
            {
                Console.WriteLine("En el mes de " + mesesLiteral[x] + " no hubieron ventas");
            }
        }

        //Parte c:

        Console.WriteLine("Articulos cuyas ventas fueron mayores al promedio: ");

        for (int x = 0; x < 20; x++)
        {
            promedio += acuVentasCantidad[x];
        }

        promedio /= 20;

        for (int x = 0; x < 20; x++)
        {
            if (acuVentasCantidad[x] > promedio)
            {
                Console.WriteLine(codigoArticulo[x]);
            }
        }
    }

    //Punto a:
    static void OrdenarVectorMayorAMenor(int[] acuMontoTotal, int[] codigoArticulo)
    {
        int aux;

        for (int x = 0; x < 20; x++)
        {
            for (int y = 0; y < 19; y++)
            {
                if (acuMontoTotal[y] < acuMontoTotal[y + 1])
                {
                    aux = acuMontoTotal[y];
                    acuMontoTotal[y] = acuMontoTotal[y + 1];
                    acuMontoTotal[y + 1] = aux;

                    aux = codigoArticulo[y];
                    codigoArticulo[y] = codigoArticulo[y + 1];
                    codigoArticulo[y + 1] = aux;
                }
            }
        }

    }
}
