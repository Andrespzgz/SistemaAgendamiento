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


            foreach (string s in list)
                WriteLine(s);

            WriteLine("");
            Write("Por favor ingrese la opcion a consular: ");
            var numSeleccionado = ReadLine();

            WriteLine(numSeleccionado);
            ReadKey();
        }
    }
}
