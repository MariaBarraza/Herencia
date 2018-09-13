using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    //ave hereda de animal
    class Ave : Animal
    {
        public string ponerHuevo()
        {
            return Nombre + " puso un huevo";
        }
        //sobrecarga de la funcion
        public override string Desplazar()
        {
            //se pueden poner particularidades de la clase
            return Nombre + " está volando";
        }
    }
}
