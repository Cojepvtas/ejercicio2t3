using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2t3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Elija el modo de conversión:");
                Console.WriteLine("1. Grados a Radianes");
                Console.WriteLine("2. Radianes a Grados");
                Console.WriteLine("3. Salir");

                // Leer la opción del usuario
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        GradosARadianes();
                        break;
                    case 2:
                        RadianesAGrados();
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        return;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }

        static void GradosARadianes()
        {
            Console.WriteLine("Ingrese el valor en grados:");
            double grados = Convert.ToDouble(Console.ReadLine());
            double radianes = grados * Math.PI / 180;
            Console.WriteLine($"{grados} grados equivalen a {radianes} radianes.");
            Console.WriteLine();
        }

        static void RadianesAGrados()
        {
            Console.WriteLine("Ingrese el valor en radianes:");
            double radianes = Convert.ToDouble(Console.ReadLine());
            double grados = radianes * 180 / Math.PI;
            Console.WriteLine($"{radianes} radianes equivalen a {grados} grados.");
            Console.WriteLine();
        }
        

        }
    }

