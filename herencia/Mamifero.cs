using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    //mamifero hereda de animal
    class Mamifero : Animal
    {
        //sobrecarga de la funcion
        public override string Desplazar()
        {
            //se pueden poner particularidades de la clase
            return Nombre + " está caminando";
        }
    }
}
