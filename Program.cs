using System;
//Calcular el número de pulsaciones que una persona debe tener por cada 10
//segundos de ejercicio, si la fórmula es:
//• num.pulsaciones = (220 - edad) / 10
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num_pulsaciones;
            int genero, edad;
            Console.WriteLine("POR FAVOR INGRESE LOS DATOS SOLICITADOS:\n");
            Console.WriteLine("Edad:");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seleccione el Genero\n1--- Femenino\n2--- Masculino");
            genero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nRESULTADOS:\n");
            if (genero == 1)
            {
                num_pulsaciones = (Double)(220 - edad) / 10;
                Console.WriteLine("El número de pulsaciones que debe tener es: " + num_pulsaciones + " Por cada 10 Segundos.");
            }
            else if (genero == 2)
            {
                num_pulsaciones = (Double)(210 - edad) / 10;
                Console.WriteLine("El número de pulsaciones que debe tener es: " + num_pulsaciones + " Por cada 10 Segundos.");
            }
            else
            {
                Console.WriteLine("Error en los datos ingresados.");
            }
        }

    }

}