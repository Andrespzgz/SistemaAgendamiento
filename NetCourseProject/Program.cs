using System;
using System.Collections;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Convert;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Bienvenido a su sistema de agendamiento");
            WriteLine("");
            List<string> list = new List<string>();
            list.Add("1-Añadir cita");
            list.Add("2-Añadir contacto");
            list.Add("3-Consultar cita");
            list.Add("4-Buscar contacto");
            list.Add("0-Salir");

            string numSeleccionado;

            foreach (string s in list)
                WriteLine(s);

            WriteLine("");
            Write("Por favor ingrese la opcion a consular: ");
            numSeleccionado = ReadLine();

            WriteLine(numSeleccionado);

            switch (numSeleccionado)
            {
                case "1":
                    Write("Ingrese la fecha de la cita (dia, mes, año, hora, minuto): ");
                    break;
                case "2":
                    Write("Ingrese el nombre del contacto: ");
                    break ;
                case "3":
                    Write("Sub menu: ");
                    break;
                case "4":
                    Write("Ingrese el nombre del contacto: ");
                    break;
                case "0":
                    Write("Por favor ingrese la opcion (S) si desea terminar el proceso: ");
                    break;



            }    
            ReadKey();
        }
    }
}
