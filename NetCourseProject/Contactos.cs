using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Contactos
    {
        public int Id { get; set; }
        public string FisrtName { get; set; }
        public string LastName { get; set; }
        public int Telefono { get; set; }
        public string Localidad { get; set; }

        public static List<Contactos> GetContactos()
        {
            List<Contactos> contacto = new List<Contactos>();

            contacto.Add(new Contactos
            {
                Id = 1,
                FisrtName = "Juan Sebastian",
                LastName = "Rojas",
                Telefono = 2456456,
                Localidad = "Usaquen"
            });

            contacto.Add(new Contactos
            {
                Id=2,
                FisrtName = "Pedro",
                LastName = "Figueredo",
                Telefono = 8978564,
                Localidad = "Roma"
            });
            contacto.Add(new Contactos
            {
                Id = 3,
                FisrtName = "Juan Manuel",
                LastName = "Gonzalez",
                Telefono = 88745565,
                Localidad = "North"
            });

            return contacto;
        }
    }
}
