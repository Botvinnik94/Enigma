using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    public class Correspondencia
    {
        public Aplicacion aplicacion { get; protected set; }
        //TODO manejo de eventos

        public Correspondencia()
        {

        }

        public Correspondencia( Aplicacion ap)
        {
            aplicacion = ap;
        }

        public char Encriptar (char entrada)
        {
            return aplicacion.Encriptar(entrada);
        }

        public char EncriptarInverso (char entrada)
        {
            return aplicacion.EncriptarInverso(entrada);
        }

        public int GetOffset()
        {
            return aplicacion.getOffset();
        }
    }
}
