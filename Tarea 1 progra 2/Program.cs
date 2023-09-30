using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Tarea_1_progra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.WriteLine("1- ejercicio 1");
                Console.WriteLine("2- ejercicio 2");
                Console.WriteLine("3- ejercicio 3");
                Console.WriteLine("4- salir");
                Console.WriteLine("digite opción");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion) // cambie a una opcion
                {
                    case 1: Console.Clear();Ejercicio1(); break;
                    case 2: Console.Clear();Ejercicio2(); break;
                    case 3: Console.Clear();Ejercicio3(); break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
            } while (opcion!=4); // mientras que la opcion sea diferente de 4

        }

        public static void Ejercicio1() // ejercicio #1
        {
            float precio = 0f;
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("digite precio");
            precio = float.Parse(Console.ReadLine());
            Console.WriteLine("digite la cantidad");
            cantidad= int.Parse(Console.ReadLine());

            if (cantidad == 1) 
            {
                Console.WriteLine($"total a pagar: {cantidad*precio}");
            } else

            if (cantidad > 1 && cantidad <6)
            {
                total = (cantidad*precio) * 0.15f; //calcula 15%
                total = (cantidad*precio) - total;
                Console.WriteLine($"total a pagar: {total} + monto con descuento 15%");
            } else

            if (cantidad >=6)
            {
                total = (cantidad*precio) * 0.2f; //calcula 20%
                total = (cantidad*precio) - total;
                Console.WriteLine($"total a pagar: {total} + monto con descuento 20%");
            } 
        }

        public static void Ejercicio2() // ejercicio #2
        {
            int cantidad = 0;
            float total = 0f;

            Console.WriteLine("digite la cantidad");
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad <= 10)
            {
                Console.WriteLine($"total a pagar: {cantidad * 20 } + el precio de cada uno es de $20");
            }
            else

            if (cantidad > 11)
            {
                Console.WriteLine($"total a pagar: {cantidad * 15} + el precio de cada uno es de $15");
            }
            
        }

        public static void Ejercicio3() // ejercicio #3
        {
            String nombre;
            String carnet;
            bool estado;
            int quiz1 = 0;
            int quiz2 = 0;
            int quiz3 = 0;
            int exa1 = 0;   
            int exa2 = 0;   
            int exa3 = 0;
            int tarea1 = 0;
            int tarea2 = 0;
            int tarea3 = 0;
            float totalquiz= 0f;
            float totalexa =0f;
            float totaltarea = 0f;
            int porcentaje = 0;
            float grantotal = 0f;

            Console.WriteLine("digite el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("digite el numero carnet");
            carnet = Console.ReadLine();

            Console.WriteLine("digite el quiz 1");
            quiz1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el quiz 2");
            quiz2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el quiz 3");
            quiz3 = int.Parse(Console.ReadLine());
            totalquiz = (quiz1 + quiz2 + quiz3) * 25 /100;
            Console.WriteLine($"promedio de quices: {totalquiz}");

            Console.WriteLine("digite el examen 1");
            exa1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el examen 2");
            exa2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite el examen 3");
            exa3 = int.Parse(Console.ReadLine());
            totalexa = (exa1 + exa2 + exa3) * 45 / 100;
            Console.WriteLine($"promedio de exámenes : {totalexa}");

            Console.WriteLine("digite la tarea 1");
            tarea1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la tarea 2");
            tarea2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite la tarea 3");
            tarea3 = int.Parse(Console.ReadLine());
            totaltarea = (tarea1 + tarea2 + tarea3) * 30 / 100;
            Console.WriteLine($"promedio de tareas: {totaltarea}");

            grantotal = (totalexa+totalquiz+totaltarea) / 3;

            Console.WriteLine($"el promedio de todo: {grantotal}");
            Console.WriteLine(" nombre "  + nombre);
            Console.WriteLine(" carnet "  + carnet);

            if (grantotal >= 70)
            {
                Console.WriteLine("condición: APROBADO");
            }
            else

            if (grantotal >= 50 && grantotal < 70)
            {
                Console.WriteLine($"condición: APLAZADO");
            }
            if (grantotal < 50)
            {
                Console.WriteLine($"condición: REPROBADO");
            }
        }
    }
}
