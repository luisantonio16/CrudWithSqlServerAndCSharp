using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{

    //Aqui creeamos una clase como entidad persona, para mapear los datos desde la base de datos, es como utilizar entity framework.
    public class Person
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string estadoPersona { get; set; }



    }
}
