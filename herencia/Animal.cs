using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    //se hace abstracta para no poder instanciar animales
    abstract class Animal
    {
        public string Identificador { get; set; }
        public string Nombre { get; set; }

        //todos tienen que tener este metodo
        abstract public string Desplazar();

    }
}
