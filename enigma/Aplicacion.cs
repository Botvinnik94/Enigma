using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    public class Aplicacion
    {
        public delegate void CicloCompletoEventHandler(object sender, EventArgs e);

        const string abecedario = "abcdefghijklmnopqrstuvwxyz";
        const int limiteLetras = 26;
        protected char[] input;
        private char[] output1;
        private char[] output2;
        private int _offset;
        public int offset
        {
            get { return _offset; }
            set
            {
                if (value == limiteLetras)
                {
                    value = 0;
                    OnCicloCompleto();
                }

                if(value >= 0 && value < limiteLetras)
                {
                    int numberOfRotations = 0;

                    if (value > offset)
                    {
                        numberOfRotations = value - offset;
                    }
                    else if (value < offset)
                    {
                        numberOfRotations = value - offset + limiteLetras;
                    }

                    for (int i = 0; i < numberOfRotations; ++i)
                    {
                        Rotar();
                    }

                    _offset = value;
                }                
            }
        }

        public event CicloCompletoEventHandler CicloCompleto;

        //Constructor para los rotores
        public Aplicacion(char[] salida1, char[] salida2, int offset)
        {
            output1 = salida1;
            output2 = salida2;
            input = abecedario.ToCharArray();
            this.offset = offset;
        }

        //Constructor para el plugboard
        public Aplicacion(char[] salida)
        {
            input = abecedario.ToCharArray();
            output1 = salida;
            output2 = null;
            this.offset = 0;
        }

        public void Rotar()
        {
            //Proceso al rotar:
            //Almacenamos el ultimo elemento del array y se desplaza los elementos del array una posición a la derecha
            //Finalmente el ultimo elemento pasa a ser el primero por la rotacion

            //Console.WriteLine();
            //foreach (char c in output)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine();
            var temp = output1[output1.Length-1];
            for (int i = output1.Length-1; i > 0; i--)
                output1[i] = output1[i-1];
            output1[0] = temp;

            temp = output2[output2.Length - 1];
            for (int i = output2.Length - 1; i > 0; i--)
                output2[i] = output2[i - 1];
            output2[0] = temp;

            //foreach(char c in output)
            //{
            //    Console.WriteLine(c);
            //}
            //Console.WriteLine();
            //_offset++;
            //if (_offset == limiteLetras)
            //{
            //OnCicloCompleto(); //Mandamos la señal para avisar de que se ha rotado hasta la ulima posicion
            //_offset = 0;
            //}

        }

        public char Encriptar(char entrada)
        {
            //Se buscara la letra recibida en nuestro array input a la vez que se incrementa i=indice
            //Una vez encontrada la correspondencia se devuelve la correspondiente "encriptación" de la letra con el indice
            //obtenido en el array de output
            int i = 0;
            foreach(char p in input)
            {
                if (p.Equals(entrada))
                {
                    entrada=output1[i];
                    break;
                }
                i++;
            }

            if (output2 == null)
            {
                return entrada;
            }
            else
            {
                int j = 0;
                foreach (char t in input)
                {
                    if (t.Equals(entrada))
                    {
                        return output2[j];
                    }
                    j++;
                }
            }
            

            return ' ';
        }

        public char EncriptarInverso(char entrada)
        {
            int i = 0;

            if (output2 == null)
            {
                foreach (char p in output1)
                {
                    if (p.Equals(entrada))
                    {
                        return input[i];
                    }
                    i++;
                }
            }
            else
            {
                foreach (char p in output2)
                {
                    if (p.Equals(entrada))
                    {
                        entrada=input[i];
                        break;
                    }
                    i++;
                }

                int j = 0;
                foreach (char t in output1)
                {
                    if (t.Equals(entrada))
                    {
                        return input[j];
                    }
                    j++;
                }
            }
            

            return ' ';
        }

        protected virtual void OnCicloCompleto()
        {
            if (CicloCompleto != null)
            {
                CicloCompleto(this, new EventArgs());
            }
        }

        public int getOffset()
        {
            return this.offset;
        }
    }
}
