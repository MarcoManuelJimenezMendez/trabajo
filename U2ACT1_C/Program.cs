using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2ACT1_C
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCompleto, gradoSeccion, carrera;
            int matricula;
            int calificacion;
            byte primerUnidad, segundaUnidad, terceraUnidad;
            int promedioFinal;
            Console.WriteLine("Ingresa tu nombre completo:");
            nombreCompleto = Console.ReadLine();
            Console.WriteLine("Ingresa tu grado y seccion:");
            gradoSeccion = Console.ReadLine();
            Console.WriteLine("Ingresa tu carrera:");
            carrera = Console.ReadLine();
            Console.WriteLine("Ingresa tu matricula;");
            matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingreasa las calificaciones por unidad de la materia de fundamentos de programacion");
            Console.WriteLine("Ingresa tu calificacion de la primera unidad:");
            primerUnidad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la segunda unidad:");
            segundaUnidad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingresa tu calificacion de la tercera unidad:");
            terceraUnidad = Convert.ToByte(Console.ReadLine());

            calificacion = primerUnidad + segundaUnidad + terceraUnidad;
            promedioFinal = calificacion / 3;
            if (promedioFinal > 70)
            {
                Console.WriteLine("Felicidades acreditaste la materia");
                Console.WriteLine("Tu calificacion final es: {0}", promedioFinal);
            }
            else
            {
                Console.WriteLine("No acreditaste la materia");
            }
            Console.Read();
        }
    }
}
