using System.Diagnostics.Tracing;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Una empresa que realiza transporte de productos frágiles cuenta con una flota de 30 camiones.
                Se generó un lote de registros con los siguientes datos para cada camión:
                    - Número de camión (1 a 30).
                    - Código de chofer (3 dígitos, no correlativos).
                Este lote se encuentra ordenado por número de camión en forma ascendente (de menor a mayor).
                Cada código de chofer maneja uno y solo un camión.
                Existe un segundo lote con la información de los viajes realizados por los camiones en el mes
                anterior, cada registro contiene:
                    - Día (1 a 31).
                    - Código de chofer (3 dígitos, no correlativos).
                    - Cantidad de kilómetros recorridos en ese viaje (entero).
                    - Cantidad de piezas rotas en ese viaje (entero).
                Este lote finaliza con un registro con día igual a cero. Se generó un registro por cada viaje realizado,
                por lo tanto, puede haber más de un registro para el mismo día y para el mismo código de chofer.
                Se pide determinar e informar:
                    a) Para cada día del mes informar cuál fue el código de chofer que haya totalizado menor
                    cantidad de piezas rotas en un solo viaje. Tener en cuenta que los choferes que no realizaron
                    viajes ese día, no deben ser considerados.
                    b) Informar cuál es el número de camión con el que se hayan recorrido mayor cantidad total de
                    kilómetros en todo el mes y qué código de chofer lo conduce.
                    c) Informar para cada código de chofer el promedio de roturas entre todos los viajes realizados
                    en la primera quincena (día 1 a 15) y los realizados en la segunda quincena (día 16 a 31). El
                    formato será:
                    Código de chofer Promedio Q1 Promedio Q2
                    999 999 999
            */

            int[] numeroCamion = new int[30];
            int[] codigoChofer = new int[30];

            //Primer lote:

            for (int x = 0; x < 30; x++)
            {
                Console.WriteLine("Ingrese numeor de camion");
                numeroCamion[x] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese codigo de chofer");
                codigoChofer[x] = int.Parse(Console.ReadLine());
            }

            int dia;
            int codChofer;
            double cantKmRecorridosPorViaje;
            int cantPiezasRotasPorViaje;

            //variables parte a:
            int[] menorCantPiezasRotas = new int[30];
            int[] dias = new int[31];

            for (int x = 0; x < 31; x++)
            {
                dias[x] = 0;
            }

            bool[] banderas = new bool[31];

            for (int x = 0; x < 31; x++)
            {
                banderas[x] = false;
            }

            //Variables parte b:
            double[] acuMayorCantKm = new double[30];
            double mayorKmRecorrido;

            //Variables parte c:
            double[] promediosQ1 = new double[30];
            double[] promediosQ2 = new double[30];
            int[] piezasRotasPorQ1 = new int[30];
            int[] piezasRotasPorQ2 = new int[30];
            int[] contViajesQ1 = new int[30];
            int[] contViajesQ2 = new int[30];

            for (int x = 0; x < 30; x++)
            {
                contViajesQ1[x] = 0;
                contViajesQ2[x] = 0;
            }

            //Ingreso de datos:
            Console.WriteLine("Viajes realizados por cada camion: ");
            Console.WriteLine("Ingrese dia: ");
            dia = int.Parse(Console.ReadLine());

            //Segundo lote:

            while (dia != 0)
            {
                Console.WriteLine("Ingrese codigo de chofer: ");
                codChofer = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de Km recorridos por viaje: ");
                cantKmRecorridosPorViaje = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese cantidad de Piezas rotas por viaje: ");
                cantPiezasRotasPorViaje = int.Parse(Console.ReadLine());

                //Punto a:

                MenorCantidadDePiezasRotasPorViaje(dia, codChofer, cantKmRecorridosPorViaje, cantPiezasRotasPorViaje,
                    dias, codigoChofer, banderas, menorCantPiezasRotas);

                //Punto b:

                for (int x = 0; x < 30; x++)
                {
                    if (codChofer == codigoChofer[x])
                    {
                        acuMayorCantKm[x] += cantKmRecorridosPorViaje;
                    }
                }

                //Punto c:

                PromediosPorQuincena(codChofer, dia, cantPiezasRotasPorViaje,
                    codigoChofer, contViajesQ1, contViajesQ2, piezasRotasPorQ1, piezasRotasPorQ2);

                Console.WriteLine("Ingrese dia: ");
                dia = int.Parse(Console.ReadLine());
            }

            //Egreso de información:
            //Parte a:

            Console.WriteLine("Los choferes que contabilizaron menor cantidad de piezas rotas por dia: ");

            for (int x = 0; x < 30; x++)
            {
                Console.WriteLine($"Codigo de chofer: {codigoChofer[x]}");
                Console.WriteLine($"Dias: {dias[x]}");
                Console.WriteLine($"Menor cantidad de piezas rotas: {menorCantPiezasRotas[x]}");
            }

            //Parte b:

            int choferMayorKmRecorrido = 0;
            mayorKmRecorrido = acuMayorCantKm[0];

            for (int x = 0; x < 29; x++)
            {
                if (acuMayorCantKm[x + 1] > mayorKmRecorrido)
                {
                    mayorKmRecorrido = acuMayorCantKm[x];
                    choferMayorKmRecorrido = codigoChofer[x];
                }
            }

            Console.WriteLine($"El camion que recorrio mayor cantidad de Km es: {mayorKmRecorrido} ");
            Console.WriteLine($"Y el chofer que lo conduce es {choferMayorKmRecorrido}");

            //Parte c:

            for (int x = 0; x < 30; x++)
            {
                promediosQ1[x] = piezasRotasPorQ1[x] / contViajesQ1[x];
                promediosQ2[x] = piezasRotasPorQ2[x] / contViajesQ2[x];
            }

            Console.WriteLine("Promedio de piezas rotas en los viajes realizados en la primera quincena: ");

            for (int x = 0; x < 30; x++)
            {
                Console.WriteLine($"{codigoChofer[x]}, {promediosQ1[x]}");
            }

            Console.WriteLine("Promedio de piezas rotas en los viajes realizados en la segunda quincena: ");

            for (int x = 0; x < 30; x++)
            {
                Console.WriteLine($"{codigoChofer[x]}, {promediosQ2[x]}");
            }

        }

        static void MenorCantidadDePiezasRotasPorViaje
        (
            int dia, int codChofer, double cantKmRecorridosPorViaje, int cantPiezasRotasPorViaje,
            int[] dias, int[] codigoChofer, bool[] banderas, int[] menorCantPiezasRotas
        )
        {
            for (int y = 0; y < 31; y++)
            {
                if (dias[y] == dia)
                {
                    for (int x = 0; x < 30; x++)
                    {
                        if (codChofer == codigoChofer[x] && cantKmRecorridosPorViaje > 0.00)
                        {
                            if (banderas[y] == false)
                            {
                                menorCantPiezasRotas[x] = cantPiezasRotasPorViaje;
                                banderas[y] = true;
                            }
                            else if (cantPiezasRotasPorViaje < menorCantPiezasRotas[x])
                            {
                                menorCantPiezasRotas[x] = cantPiezasRotasPorViaje;
                            }
                        }
                    }
                }
            }
        }
        static void PromediosPorQuincena(int codChofer, int dia, int cantPiezasRotasPorViaje,
            int[] codigoChofer, int[] contViajesQ1, int[] contViajesQ2, int[] piezasRotasPorQ1, int[] piezasRotasPorQ2)
        {
            for (int x = 0; x < 30; x++)
            {
                if (codChofer == codigoChofer[x])
                {
                    if (dia > 0 && dia < 16)
                    {
                        contViajesQ1[x]++;
                        piezasRotasPorQ1[x] += cantPiezasRotasPorViaje;
                    }
                    if (dia > 15 && dia < 32)
                    {
                        contViajesQ2[x]++;
                        piezasRotasPorQ2[x] += cantPiezasRotasPorViaje;
                    }
                }
            }
        }
    }
}
