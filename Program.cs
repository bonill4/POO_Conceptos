using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Importacion de metodos static
No es muy recomendable por confuciones

using static System.Math;
using static System.Console;
*/

namespace POO_Conceptos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //realizarTarea();

            //CLASE ANONIMAS
            //Si las clase anonima tiene la misma cantidad de propiedades y del mismo tipo 
            //el copilador asume que es de la misma clase anonima
            var miVariable = new {Nombre = "Williams", Edad = 23};
            var miOtraVariable = new { Nombre = "Ulises", Edad = 25 };

            miVariable = miOtraVariable;

            Console.WriteLine(miVariable.Nombre+" "+miVariable.Edad);

            
        }

        static void realizarTarea()
        {
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);

            double distancia = origen.DistanciaHasta(destino);

            Console.WriteLine($"La distancia de los puntos es de: {distancia}");

            Console.WriteLine($"Numero de objetos creador {Punto.getContadorDeObjetos()}");
        }
    }
}
