namespace Ejercicio_3;

class Program
{
    static void Main(string[] args)
    {
        /*3. Una empresa de transporte de carga por camión posee 20 tarifas distintas de acuerdo al destino
            de los envíos que deba realizar. Dispone de un lote de registros con la siguiente información:
                - Número de Tarifa (Número de 4 cifras, no correlativos).
                - Importe por KM.

            Este lote no viene ordenado. A continuación, dispone de un segundo lote de registros con la
            información de los envíos que se realizaron durante la semana pasada, conteniendo cada uno de
            ellos los siguientes campos:
                - Número de Camión (1 a 100).
                - Número de Tarifa.
                - Kilómetros Recorridos.

            Este lote finaliza con un registro con número de camión negativo. Se nos pide realizar un programa
            que determine e informe:
                a) El total recaudado por cada tarifa.
                b) Un listado como el siguiente:
                Número de camión / Total recaudado
                xxx                xxx
                Este listado debe salir ordenado por total recaudado, de mayor a menor.
                c) Indicar el número de camión que recorrió la menor cantidad de kilómetros entre los que
                realizaron viajes. Nota: cada camión realizó cero, uno o varios viajes.
            */

        int[] numeroDeTarifa = new int[20];
        int[] importePorKM = new int[20];

        Console.WriteLine("Cargue 20 tarifas y su debido importe por KM");

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("Ingrese numero de tarifa");
            numeroDeTarifa[x] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese importe por KM");
            importePorKM[x] = int.Parse(Console.ReadLine());
        }

        int[] numeroDeCamion = new int[100];
        int[] totalRecaudado = new int[20];
        int indice = 0;

        Console.WriteLine("Envios de la semana pasada");
        Console.WriteLine("Ingrese numero de camion");
        numeroDeCamion[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese numero de tarifa");
        int numDeTarifa = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese km recorridos");
        int kmRecorridos = int.Parse(Console.ReadLine());


        while (numeroDeCamion[indice] > 0)
        {

            TotalRecaudadoPorTarifa(numDeTarifa, kmRecorridos, importePorKM, numeroDeTarifa, totalRecaudado);
            ListadoX2MayorAMenor(totalRecaudado, numeroDeCamion);
            MenosKmRecorridos(totalRecaudado, kmRecorridos, numeroDeCamion, indice);

            Console.WriteLine("Ingrese numero de camion");
            numeroDeCamion[indice] = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero de tarifa");
            numDeTarifa = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese km recorridos");
            kmRecorridos = int.Parse(Console.ReadLine());

            indice++;
        }
    }

    //Parte a:
    static void TotalRecaudadoPorTarifa(
        int numDeTarifa, int kmRecorridos, int[] importePorKM,
        int[] numeroDeTarifa, int[] totalRecaudado)
    {
            for (int y = 0; y < 20; y++)
            {
                if (numDeTarifa == numeroDeTarifa[y])
                {
                    totalRecaudado[y] += importePorKM[y] * kmRecorridos;
                    break;
                }
            }
    }

    //Parte b:
    static void ListadoX2MayorAMenor(int[] totalRecaudado, int[] numeroDeCamion)
    {
        int aux;

        for (int x = 0; x < 20; x++)
        {
            for (int y = 0; y < 20; y++)
            {
                if (totalRecaudado[y] < totalRecaudado[y + 1])
                {
                    aux = totalRecaudado[y];
                    totalRecaudado[y] = totalRecaudado[y + 1];
                    totalRecaudado[y + 1] = aux;

                    aux = numeroDeCamion[y];
                    numeroDeCamion[y] = numeroDeCamion[y + 1];
                    numeroDeCamion[y + 1] = aux;
                }
            }
        }
    }
    
    //Parte c:
    static void MenosKmRecorridos(int[] totalRecaudado, int kmRecorridos, int[] numeroDeCamion, int indice)
    {
        int b = 0;
        int menorKmRecorrido = 0;
        int camionMenorkmRecorrido;

        for (int x = 0; x < 100; x++)
        {
            if (totalRecaudado[x] > 0 && b == 0)
            {
                menorKmRecorrido = kmRecorridos;
                b = 1;
            }
            else if (kmRecorridos < menorKmRecorrido)
            {
                camionMenorkmRecorrido = numeroDeCamion[indice];
            }
        }
    }
}