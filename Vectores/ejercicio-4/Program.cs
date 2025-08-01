namespace ejercicio_4;

class Program
{
    static void Main(string[] args)
    {
        //4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada 
        //genera un registro con los siguientes datos:
        // - Número de Artículo (1 a 15)
        // - Cantidad Vendida 

        // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo 
        // igual a 0.
        // Se pide determinar e informar:
        // a) El número de artículo que más se vendió en total.
        // b) Los números de artículos que no registraron ventas.
        // c) Cuantas unidades se vendieron del número de artículo 10.

        int numeroArticulo;
        int cantidadVendida;
        int[] cVen = new int[15];

        Console.WriteLine("Ingrese numero de articulo");
        numeroArticulo = int.Parse(Console.ReadLine());


        while (numeroArticulo != 0 && numeroArticulo < 16)
        {
            Console.WriteLine("Ingrese cantidad vendida");
            cantidadVendida = int.Parse(Console.ReadLine());

            cVen[numeroArticulo - 1] += cantidadVendida;

            Console.WriteLine("Ingrese numero de articulo");
            numeroArticulo = int.Parse(Console.ReadLine());
        }
        int max = cVen[0];
        int maxIndice = 0;

        for (int x = 1; x < 15; x++)
        {
            if (cVen[x] > max)
            {
                max = cVen[x];
                maxIndice = x;
            }
        }
        Console.WriteLine("El articulo mas vendido fue el " + (maxIndice + 1));

        for (int x = 0; x < 15; x++)
        {
            if (cVen[x] == 0)
            {
                Console.WriteLine("El articulo " + (x + 1) + " no registro ventas");
            }
        }
        
        Console.WriteLine("El articulo 10 vendio " + cVen[9]);
    }
}
