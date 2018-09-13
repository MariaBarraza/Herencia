using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia 
{
    //Reptil hereda de animal
    class Reptil : Animal
    {
        public string CambiarPiel()
        {
            return Nombre + " cambió de piel";
        }

        //sobrecarga de la funcion
        public override string Desplazar()
        {
            //se pueden poner particularidades de la clase
            return Nombre + " está caminando";
        }
    }
}
