using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Pruebas
{
    public class Lecturas
    {
        StreamReader archivo;
        StreamWriter log;

        public Lecturas(){
            archivo = new StreamReader("pruebas.cpp");
            log = new StreamWriter("prueba.log");
        }

        public Lecturas(string nombre){
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");

        }
    
    }
}