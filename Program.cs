using System;

namespace tp_7_ejr_3
{
    class Program
    {
        static void Main(string[] args)
        {
               Console.Clear();
            int dia = 0, dia2 = 0, num = 0, alta = 0, baja = 10, acumulador = 0;
            float promedio = 0f;
            string entrada;

            for (int i = 1; i <= 7; i = i + 1)
            {
                Console.WriteLine("Ingrese la temperatura del dia ");
                entrada = Console.ReadLine();
                num = Convert.ToInt32(entrada);
                acumulador = acumulador + num;

                if (num > alta)
                {
                    alta = num;
                    dia = i;
                }
                if (num < baja)
                {
                    baja = num;
                    dia2 = i;
                }



            }
                        promedio=acumulador/7;
            Console.WriteLine("la temperatura mas alta es {0}, y fue el dia {1}", alta, dia);
            Console.WriteLine("la temperatura mas baja es {0}, y fue el dia {1}", baja, dia2);
            Console.WriteLine("el promedio de las temperaturas ingresadas es {0}",promedio);

        }
    }
}
