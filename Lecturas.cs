using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Text;

namespace Pruebas
{
    public class Lecturas : IDisposable
    {
        StreamReader archivo;
        StreamWriter log;

        public Lecturas()
        {
            System.Console.WriteLine("Constructor 1");
            archivo = new StreamReader("prueba.cpp");
            log = new StreamWriter("prueba.log");
        }

        public Lecturas(string nombre)
        {
            archivo = new StreamReader(nombre);
            log = new StreamWriter("prueba.log");

        }

        public void Dispose()
        {
            archivo.Close();
            log.Close();
        }

        public void Display()
        {
            while (!archivo.EndOfStream)
            {
                Console.Write((char)archivo.Read());
            }
        }

        public void Copy()
        {
            while (!archivo.EndOfStream)
            {
                log.Write((char)archivo.Read());
            }
        }

        public void Encrypt()
        {
            char c;
            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                if (char.IsLetter(c))
                {
                    log.Write((char)(c + 2));
                }
                else
                {
                    log.Write(c);
                }

            }
        }

        public void Desencrypt(char v)
        {
            char c;
            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };

            while (!archivo.EndOfStream)
            {
                c = (char)archivo.Read();
                bool vocal = false;
                foreach (var i in vocales)
                {
                    if (char.IsLetter(c) && char.ToUpper(c).ToString().Contains(i))
                    {
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

        public int contarLetras()
        {
            int contarLetras=0;
            while (!archivo.EndOfStream)
            {
                char c=(char)archivo.Read();
                if (char.IsLetter(c))
                {
                    contarLetras++;	
                }
            }
            return contarLetras;
        }

        public int contarDigitos()
        {
            int contarLetras=0;
            while (!archivo.EndOfStream)
            {
                char c=(char)archivo.Read();
                if (char.IsDigit(c))
                {
                    contarLetras++;	
                }
            }
            return contarLetras;
        }

        public int contarEspacios()
        {
            int contarLetras=0;
            while (!archivo.EndOfStream)
            {
                char c=(char)archivo.Read();
                if (char.IsWhiteSpace(c))
                {
                    contarLetras++;	
                }
            }
            return contarLetras;
        }

        public dynamic PrimerCaracter()
        {
            dynamic d = "Empty";
            string buffer = "";
            char c;
            while (char.IsWhiteSpace(c = (char)archivo.Read()) && !archivo.EndOfStream)
            {
                       
            }

            if(char.IsLetter(c)){
                buffer +=c;
                while (char.IsLetter(c = (char)archivo.Read()) && !archivo.EndOfStream)
                {
                    buffer +=c;
                }
            }
            log.WriteLine(buffer);
            return buffer.ToString();
        }
    }
}