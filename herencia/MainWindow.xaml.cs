using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace herencia
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Animal> animales = new List<Animal>();

            Ave tucan = new Ave();
            tucan.Nombre = "Sam";

            Mamifero tigre = new Mamifero();
            tigre.Nombre = "Toño";

            animales.Add(tucan);
            animales.Add(tigre);

            //se crea una variable tipo animal y se agrega de valor su clase de animal
            Animal cocodrilo = new Reptil();
            cocodrilo.Nombre = "Godzila";

            animales.Add(cocodrilo);

            Pez pezPayaso = new Pez();
            pezPayaso.Nombre = "Nemo";

            animales.Add(pezPayaso);

            //recorrer la lista animales
            foreach (Animal animal in animales)
            {
                stckRegistro.Children.Add(
                    new TextBlock
                    {
                        Text = animal.Desplazar()
                    }
                    );

            }
            //se llama la funcion para imprimir el metodo poner huevo
            Imprimir(tucan.ponerHuevo());
            //casting para poder tratarlo como reptil ya que se declaro como animal
            Imprimir(((Reptil)cocodrilo).CambiarPiel());


        }

        //funcion para mandar imprimir las particularidades de cada hijo 
        public void Imprimir(string texto)
        {
            stckRegistro.Children.Add(
                new TextBlock
                {
                    Text = texto
                }
                );
        }
    }
}
