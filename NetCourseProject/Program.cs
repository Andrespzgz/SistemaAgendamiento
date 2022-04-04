using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace FinalProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            List<Contactos> contacts = new List<Contactos>();
            
            string numSeleccionado;
            string fechaCita;
            string desc;
            string nomCita;



            WriteLine("Bienvenido al sistema de agendamiento de citas \n");
           
            list.Add("1-Añadir cita");
            list.Add("2-Añadir contacto");
            list.Add("3-Consultar cita");
            list.Add("4-Buscar contacto");
            list.Add("0-Salir");

        
            contacts.Add( new Contactos
            {
                Id = 1,
                Nombres = "Carlos",
                Apellidos = "Rojas",
                Telefono = 310553223,
                Localidad = "Central",
            });

            contacts.Add(new Contactos
            {
                Id= 2,
                Nombres = "Juan",
                Apellidos = "Benitez",
                Telefono = 455454810,
                Localidad = "Norte",
            });

            

            foreach (string menu in list)
                WriteLine(menu);


            Write("\nPor favor seleccione una opcion del menu: ");
            numSeleccionado = ReadLine();

            WriteLine(numSeleccionado);

            switch (numSeleccionado)
            {
                case "1":

                    //Write("Ingrese la fecha de la cita (dia, mes, año, hora, minuto): ");
                    //fechaCita = ReadLine();
                    //Write("Ingrese una descripcion breve de la cita solicitada: ");
                    //desc = ReadLine();
                    Write("Ingrese el nombre con quien tendra la cita: ");
                    nomCita = ReadLine();
                    foreach (var contact in contacts)
                        WriteLine(contact.Nombres);
                    //var nombre = new contactos(nomCita);

                    //if(nombre.stack.Contains(nomCita))

                    //    nombre.AddContactoCita(nomCita);
                    //fcita(fechaCita);
                    break;
                case "2":
                    Write("Ingrese el nombre del contacto: ");
                    break;
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

            static void fcita(string Fecha)
            {
                var fecha = Fecha.Split(',');
                int i = 0;
                Hashtable hash = new Hashtable();

                foreach (string menu in fecha)
                    hash.Add(i++, menu);

                ModelDatosCita.Dia = hash[0] as string;
                ModelDatosCita.Mes = hash[1] as string;
                ModelDatosCita.Año = hash[2] as string;
                ModelDatosCita.Hora = hash[3] as string;
                ModelDatosCita.Minuto = hash[4] as string;


                WriteLine($"Fecha: {ModelDatosCita.Dia }-{ModelDatosCita.Mes}-{ModelDatosCita.Año}, hora: {ModelDatosCita.Hora}:{ModelDatosCita.Minuto}");



            }
            ReadKey();
        }
    }    

    public class Contactos
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Telefono { get; set; }
        public string Localidad { get; set; }
    }
    //public class contactos
    //{
    //    private string _nombre;
    //    public Stack stack = new Stack();
    //    public contactos(string Nombre)
    //    {
    //        _nombre = Nombre;

    //        stack.Push("Pedro");
    //        stack.Push("Juan");
    //        stack.Push("Ramiro");
    //    }

    //public string AddContactoCita(string Nombre)
    //    {
    //        stack.Push(Nombre);

    //        return $"{Nombre} ha sigo guardado";
    //    }
    //}
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
