using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args) 
        {
           using (Lecturas L = new Lecturas("prueba.cpp")){
            /* L.Encrypt(); */
            /* L.Desencrypt('O'); */

            //System.Console.WriteLine("El número de letras es: "+L.contarLetras());
            System.Console.WriteLine(L.PrimerCaracter());

           }
            /* Lecturas L = new Lecturas(); */
        }
    }
}
