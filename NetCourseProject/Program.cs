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
            /*Declaración de variables*/
            List<string> list = new List<string>();
            List<Contactos> contacts = Contactos.GetContactos();
            FileStream fs = new FileStream("agenda.txt", FileMode.OpenOrCreate);
            fs.Close();

            string numSeleccionado;
            string fechaCita;
            string desc;
            string nomCita;
            int id;

            WriteLine("Bienvenido al sistema de agendamiento de citas \n");
           
            list.Add("1-Añadir cita");
            list.Add("2-Añadir contacto");
            list.Add("3-Consultar cita");
            list.Add("4-Buscar contacto");
            list.Add("0-Salir");
                       

            foreach (string menu in list)
                WriteLine(menu);


            Write("\nPor favor seleccione una opcion del menu: ");
            numSeleccionado = ReadLine();

            WriteLine(numSeleccionado);

            switch (numSeleccionado)
            {
                case "1":

                    Write("Ingrese la fecha de la cita (dia, mes, año, hora, minuto): ");
                    fechaCita = ReadLine();
                    Write("Ingrese una descripcion breve de la cita solicitada: ");
                    desc = ReadLine();
                    Write("Ingrese el nombre con quien tendra la cita: ");
                    nomCita = ReadLine();

                    var existe = contacts.Exists(x => x.FisrtName.Contains(nomCita));

                    if (existe)
                    {
                        liscont(contacts, nomCita);
                        Write("Ingresa el Id del contacto: ");
                        id = ToInt32(ReadLine());
                        var resultado = fdatosCita(fechaCita);

                        var resultado1 = fsaveCita(id, contacts);
                        WriteLine($"{resultado} - {resultado1}");
                        saveDataCita.sendData(resultado1, resultado);
                    }
                        
                    else
                        WriteLine("No existe el contacto ingresado!");

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

            static string fdatosCita(string Fecha)
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


                var Datos = ($"Fecha: {ModelDatosCita.Dia }-{ModelDatosCita.Mes}-{ModelDatosCita.Año}, hora: {ModelDatosCita.Hora}:{ModelDatosCita.Minuto}");

                return Datos;
            }

            static void liscont (List<Contactos> contacts,string contacto)
            {
                var contactos = from l in contacts
                                where l.FisrtName.Contains(contacto)
                                select new
                                {
                                    ID = l.Id,
                                    FirstName = l.FisrtName,
                                    LastName = l.LastName
                                };

                foreach (var item in contactos)
                {
                    WriteLine($"Id: {item.ID} - {item.FirstName} {item.LastName}");
                }
            }

            static string fsaveCita(int id, List<Contactos> contacts)
            {
                string dato = "";
                var contacto = from l in contacts
                               where l.Id == id
                               select new
                               {
                                   FirstName = l.FisrtName,
                                   LastName = l.LastName,
                                   Telefono = l.Telefono
                               };
                
                foreach (var item in contacto)
                    dato = ($"Nombre: {item.FirstName} {item.LastName}, Telefono: {item.Telefono}");
               
                return dato;
            }
            ReadKey();
        }
    }

    public static class saveDataCita
    {

        public static void sendData(string nombre, string fecha)
        {
            try
            {
                // Escribir en un archivo
                FileStream fs = new FileStream("agenda.txt", FileMode.Append);

                string cadena = $"{nombre}|{fecha};";

                fs.Write(ASCIIEncoding.ASCII.GetBytes(cadena), 0, cadena.Length);
                fs.Close();


            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
    public  class DatosCita
    {
        private int _dia;
        private int _mes;
        private int _año;
        private int _hora;
        private int _minuto;
        public DatosCita(int dia, int mes, int año, int hora, int minuto)
            => (_dia,_mes,_año,_hora,_minuto)=(dia, mes, año, hora, minuto);

        public string print(string contacto)
        {
            var datosCita = $"La cita fue seleccionada con el contacto: y se llevara a cabo el día {_dia} del mes {_mes} del año {_año}, con la siguiente hora: {_hora}:{_minuto}";
           return datosCita;
        }
    }
}
