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
        public char[] output;
        private int _offset;
        public int offset
        {
            get { return _offset; }
            set
            {
                _offset = value;
            }
        }

        public event CicloCompletoEventHandler CicloCompleto;

        //Constructor para los rotores
        public Aplicacion(char[] salida, int offset)
        {
            this.offset = offset;
            output = salida;
            if (offset > 0)
            {
                for (int i = 0; i <= offset; i++)
                    Rotar();
            }
            input = abecedario.ToCharArray();
        }

        //Constructor para el plugboard
        public Aplicacion(char[] salida)
        {
            input = abecedario.ToCharArray();
            output = salida;
            offset = -1;
        }

        public void Rotar()
        {
            //Proceso al rotar:
            //Almacenamos el ultimo elemento del array y se desplaza los elementos del array una posición a la derecha
            //Finalmente el ultimo elemento pasa a ser el primero por la rotacion

            char temp = output[output.Length-1];
            for(int i = output.Length - 1; i > 0; i--)
            {
                output[i] = output[i - 1];
            }
            output[0] = temp;

            offset++;
            if (offset == limiteLetras)
            {
                OnCicloCompleto(); //Mandamos la señal para avisar de que se ha rotado hasta la ulima posicion
                offset = 0;
            }

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
                    //char salida = output[i];
                    //if (offset != -1)
                    //{
                    //    Rotar();
                    //}
                    //return salida;
                    return output[i];
                }
                i++;
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
    }
}
