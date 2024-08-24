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
            char[] voc={'A','E','I','O','U'};
            
            while(!archivo.EndOfStream){
                c=char.ToUpper((char)archivo.Read());
                

                for (int i = 0; i <voc.Length; i++)
                {
                    if (char.IsLetter(c)&&char.IsLetter(c).Equals(voc[i]))
                {
                    log.Write((char)(v));    
                }else{
                    log.Write(c);
                }        
                }
            }
        }

    }
}