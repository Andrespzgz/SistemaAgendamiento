using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace NetCourseProject
{
    public class Mainmenu
    {
        //private string _dato;
        //public Mainmenu(string dato) => (_dato) = (dato);
        public List<string> lista;
        public Mainmenu datos()
        {
            List<string> list = new List<string>();
            list.Add("1-Añadir cita");
            list.Add("2-Añadir contacto");
            list.Add("3-Consultar cita");
            list.Add("4-Buscar contacto");
            list.Add("0-Salir");
            
            return  null;

        }
        
        

        
    }
}
