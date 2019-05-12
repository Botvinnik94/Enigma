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

        const string abecedario = "abcdefghijklmnñopqrstuvwxyz";
        const int limiteLetras = 27;
        protected char[] input;
        public char[] output { get; set; }
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
        public Aplicacion(char[] salida, int offset)
        {
            output = salida;
            input = abecedario.ToCharArray();
            this.offset = offset;
        }

        //Constructor para el plugboard
        public Aplicacion(char[] salida)
        {
            input = abecedario.ToCharArray();
            output = salida;
            this.offset = 0;
        }

        public void Rotar()
        {
            var temp = output[output.Length-1];
            for (int i = output.Length-1; i > 0; i--)
                output[i] = output[i-1];
            output[0] = temp;

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
                    return output[i];
                }
                i++;
            }

            return ' ';
        }

        public char EncriptarInverso(char entrada)
        {
            int i = 0;
            foreach (char p in output)
            {
                if (p.Equals(entrada))
                {
                    return input[i];
                }
                i++;
            }

            return ' ';
        }

        protected virtual void OnCicloCompleto()
        {
            CicloCompleto?.Invoke(this, new EventArgs());
        }

        public int getOffset()
        {
            return this.offset;
        }
    }
}
