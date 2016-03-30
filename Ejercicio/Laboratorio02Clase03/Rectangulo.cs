using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Rectangulo
    {
        private Punto verticeUno;
        private Punto verticeDos;     
        private Punto verticeTres;
        private Punto verticeCuatro;
        private miColor colorDeRectangulo;
        private float superficie;
        private float perimetro;

        public float GetSuperficie()
        {
            return this.superficie;
        }

        public float GetPerimetro()
        {
            return this.perimetro;
        }

        public Rectangulo(Punto verticeUno, Punto verticeTres)
        {
            this.verticeUno = verticeUno;
            this.verticeTres = verticeTres;

            //this.verticeDos = new Punto(this.verticeTres.x,this.verticeUno.y);
            this.verticeDos = new Punto(this.verticeTres.DevolverX(), this.verticeUno.DevolverY());
            //this.verticeCuatro = new Punto(this.verticeUno.x, this.verticeTres.y);
            this.verticeCuatro = new Punto(this.verticeUno.DevolverX(), this.verticeTres.DevolverY());
            this.CalcularSuperficie();
            this.CalcularPerimetro();
        }

        private void CalcularSuperficie()
        {
            float Base = Math.Abs(this.verticeTres.DevolverX() - this.verticeCuatro.DevolverX());
            float altura = this.verticeUno.DevolverY() - this.verticeCuatro.DevolverY();

            this.superficie = Base * altura;
        }

        private void CalcularPerimetro()
        {
            float Base = Math.Abs(this.verticeTres.DevolverX() - this.verticeCuatro.DevolverX());
            float altura = Math.Abs(this.verticeUno.DevolverY() - this.verticeTres.DevolverY());

            this.perimetro = 2 * Base + 2 * altura;
        }

        public static void MostrarRectangulo(Rectangulo rectangulo)
        {
            /*Console.WriteLine(rectangulo.verticeUno);
            Console.WriteLine(rectangulo.verticeDos);
            Console.WriteLine(rectangulo.verticeTres);
            Console.WriteLine(rectangulo.verticeCuatro);*/
            Console.WriteLine(rectangulo.superficie);
            Console.WriteLine(rectangulo.perimetro);
            Console.WriteLine(rectangulo.colorDeRectangulo);
        }
    }

    //Enumerado
    public enum miColor
    {
        rojo, verde, azul, blanco
    }
}
