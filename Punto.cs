using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Conceptos
{
    class Punto
    {
        private int x, y;

        private static int contadorDeObjeto = 0; 

        public Punto()
        {
            this.x = 0;
            this.y = 0;

            contadorDeObjeto++;
        }
        public Punto(int x, int y) 
        {
            this.x = x;
            this.y = y;

            contadorDeObjeto++;
        }

        public double DistanciaHasta(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;

            int yDif = this.y - otroPunto.y;

            double distanciaPunto = Math.Sqrt(Math.Pow(xDif, 2)+Math.Pow(yDif, 2));

            return distanciaPunto;
        }

        public static int getContadorDeObjetos() => contadorDeObjeto;
    }
}
