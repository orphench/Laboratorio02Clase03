using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Program
    {
        static void Main(string[] args)
        {
            //name space: agrupar codigo, son como subdirectorios
            //enumerado: son como otra clase, un tipo nuevo de dato
            /*Punto puntoUno = new Punto(5,6);
            Punto puntoDos = new Punto(1, 1);*/

            //Para acceder a miColor
            //Geometria.miColor unColor;
            //unColor = Geometria.miColor.blanco;

            ////Muestra el numero 22, si se comenta muestra el color asignado
            //unColor = (Geometria.miColor)22;

            //Console.Write(unColor);

            //switch (unColor)
            //{
            //    case miColor.rojo:
            //        break;
            //    case miColor.verde:
            //        break;
            //    case miColor.azul:
            //        break;
            //    case miColor.blanco:
            //        break;
            //    default:
            //        break;
            //}

            Rectangulo mir = new Rectangulo(new Punto(1, 5), new Punto(6, 1));
            //Console.WriteLine(mir.GetSuperficie());
            //Console.WriteLine(mir.GetPerimetro());
            Rectangulo.MostrarRectangulo(mir);

            Console.ReadKey();
        }
    }


}
