using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Se dispone de una lista de 5 listas de números enteros separados 
            // entre ellos por ceros. Se pide determinar e informar:

            // El número de grupo con mayor porcentaje de números impares respecto 
            // al total de números que forman el grupo.
            // Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            int n, nDeGrupo = 0, nDeGrupoMayorMenor = 0, mayorAMenor = 0;
            float mayorGrupoImpares = 0;
            bool bImp = true;

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine());

                int contImp = 0;
                int contGeneral = 0;
                bool bMayor = true;
                bool Ordenado = true;

                while (n != 0)
                {
                    contGeneral++;

                    if (n % 2 != 0)
                        contImp++;

                    if (bMayor == true)
                    {
                        mayorAMenor = n;
                        bMayor = false;
                    }
                    else if (n > mayorAMenor)
                        Ordenado = false;
                    else
                        mayorAMenor = n;

                    Console.WriteLine("Ingrese un número");
                    n = int.Parse(Console.ReadLine());
                }

                float porcentaje = (contImp * 100f) / contGeneral;

                if (bImp == true)
                {
                    mayorGrupoImpares = porcentaje;
                    nDeGrupo = x + 1;
                    bImp = false;
                }
                else if (porcentaje > mayorGrupoImpares)
                {
                    mayorGrupoImpares = porcentaje;
                    nDeGrupo = x + 1;
                }
                if (Ordenado)
                    nDeGrupoMayorMenor++;


            }

            Console.WriteLine("El grupo con mayor porcentaje de impares fue " + nDeGrupo);
            Console.WriteLine(nDeGrupoMayorMenor + " Estan ordenados de mayor a menor");

        }
    }
}
