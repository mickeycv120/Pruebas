using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.PortableExecutable;

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
        
        public void Copy(){
            while(!archivo.EndOfStream){
                log.Write((char)archivo.Read());
            }
        }

        public void Encrypt(){
            char c;
            while(!archivo.EndOfStream){
                c=(char)archivo.Read();
                if (char.IsLetter(c))
                {
                    log.Write((char)(c+2));    
                }else{
                    log.Write(c);
                }
                
            }
        }

        public void Desencrypt(char v){
            char c;
            char[] vocales = {'A','E','I','O','U' };
            
            while(!archivo.EndOfStream){
                c=(char)archivo.Read();
                bool vocal = false;
                foreach (var i in vocales)
                {
                    if (char.IsLetter(c) && char.ToUpper(c).ToString().Contains(i)){
                        log.Write((char)(v));
                        vocal = true;
                        break;
                    }
                }

                if (!vocal)
                {  
                    log.Write(char.ToUpper(c));
                }
            }
        }

    }
}