namespace ejercicio_2;

class Program
{
    static void Main(string[] args)
    {
        /*2. Se dispone de un lote de 300 registros (uno por artículo), cada uno de 
        los cuales tiene la
        siguiente información:
        - Número de artículo (4 dígitos no correlativos).
        - Cantidad de unidades en stock.
        - Precio Unitario.
        El lote está desordenado.
        Se dispone de otro lote de registros, cada uno de los cuales corresponde a una venta con la siguiente
        información:

        - Número de cliente (1 a 300).
        - Número de artículo (4 dígitos, no correlativos).
        - Cantidad de unidades vendidas.

        El último registro de este lote tiene número de cliente cero y no debe procesarse. Desarrollar el
        programa que determine e imprima:
        a) Un listado de las ventas realizadas, con el siguiente formato:

        Listado de ventas
        Nro. Cliente Nro. Artículo Cantidad Vendida Importe Total
        99           99            999              999.99
        b) Informar cuál es el número de cliente que más compró en total (en pesos).
        c) Informar cada uno de los números de los artículos que no hayan registrado ventas.*/

        int[] numArticulos = new int[300];
        int[] cantidadUnidadesEnStock = new int[300];
        int[] precioUnitario = new int[300];

        //Lote uno:
        
        for (int x = 0; x < 300; x++)
        {

            Console.WriteLine("Ingrese numero de articulo");
            numArticulos[x] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            cantidadUnidadesEnStock[x] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese precio unitario");
            precioUnitario[x] = int.Parse(Console.ReadLine());

        }

        int[] importeTotal = new int[300];

        Console.WriteLine("Ingrese numero de cliente");
        int nDeCliente = int.Parse(Console.ReadLine());
        
        //Lote dos:

        while (nDeCliente != 0)
        {
            //Ingreso de datos:
            Console.WriteLine("Ingrese numero de articulo");
            int numArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad vendida");
            int cantUniVen = int.Parse(Console.ReadLine());

            //Parte a:
            
            for (int x = 0; x < 300; x++)
            {
                if (numArticulo == numArticulos[x])
                {
                    importeTotal[x] = precioUnitario[x] * cantUniVen;
                }
            }

            numeroDeCliente[indice] = nDeCliente;
            numArt[indice] = numArticulo;
            cantUniVendidas[indice] = cantUniVen;

            indice++;

            Console.WriteLine("Ingrese numero de cliente");
            nDeCliente = int.Parse(Console.ReadLine());
        }

        int max = importeTotal[0];
        int clienteMasCompro = 0;

        for (int x = 0; x < 300; x++)
        {
            if (importeTotal[x] > max)
            {
                clienteMasCompro = numeroDeCliente[x];
            }
        }

        Console.WriteLine("Cliente que mas compro " + clienteMasCompro);

        for (int x = 0; x < 300; x++)
        {
            if (numArticulos[x] == 0)
            {
                Console.WriteLine("El articulo " + numArticulos[x] + " no tuvo ventas");
            }
        }
    }
}
