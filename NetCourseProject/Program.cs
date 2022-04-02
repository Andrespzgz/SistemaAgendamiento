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
            string fecCita;

            foreach (string menu in list)
                WriteLine(menu);

            WriteLine("");
            Write("Por favor ingrese la opcion a consular: ");
            numSeleccionado = ReadLine();

            WriteLine(numSeleccionado);

            switch (numSeleccionado)
            {
                case "1":
                    
                    Write("Ingrese la fecha de la cita (dia, mes, año, hora, minuto): ");
                    fecCita = ReadLine();
                    var dato = funcita(fecCita);
                    
                    WriteLine(dato.print());
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

            static DatosCita funcita (string Cita)
            {
                ModelDatosCita modelDatosCita = new ModelDatosCita();
                modelDatosCita.Dia = Int32.Parse(Cita.Substring(0,2));
                modelDatosCita.Mes = Int32.Parse(Cita.Substring(2, 4));
                modelDatosCita.Año = Int32.Parse(Cita.Substring(4, 8));
                modelDatosCita.Hora = Int32.Parse(Cita.Substring(8, 10));
                modelDatosCita.Minuto = Int32.Parse(Cita.Substring(10, 12));
                //DatosCita cita = new DatosCita(modelDatosCita.Dia, modelDatosCita.Mes, modelDatosCita.Año, modelDatosCita.Hora, modelDatosCita.Minuto);
                DatosCita cita = new DatosCita(07, 02, 2022, 16, 59);
                return cita;
            }
            ReadKey();
        }
    }

    public class ModelDatosCita
    {
        public int Dia { get; set; }
        public int Mes { get; set; }
        public int Año { get; set; }
        public int Hora { get; set; }
        public int Minuto { get; set; }

    }
    public class DatosCita
    {
        private int _dia;
        private int _mes;
        private int _año;
        private int _hora;
        private int _minuto;
        public DatosCita(int dia, int mes, int año, int hora, int minuto)
            => (_dia,_mes,_año,_hora,_minuto)=(dia, mes, año, hora, minuto);

        public int print()
        {
           return _dia;
        }
    }
}
