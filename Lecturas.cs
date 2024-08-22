using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Pruebas
{
    public class Lecturas : IDisposable
    {
        StreamReader archivo;
        StreamWriter log;

        public Lecturas(){
            System.Console.WriteLine("Constructor 1");
            archivo = new StreamReader("prueba.cpp");
            log = new StreamWriter("prueba.log");
        }

        public Lecturas(string nombre){
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");

        }
    
        public void Dispose(){
            archivo.Close();
            log.Close();
        }

        public void Display(){
            while(!archivo.EndOfStream){
                Console.Write((char)archivo.Read());
            }
        }
    }
}