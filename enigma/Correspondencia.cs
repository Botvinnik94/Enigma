using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    public class Correspondencia
    {
        protected Aplicacion aplicacion;
        //TODO manejo de eventos

        public Correspondencia()
        {

        }

        public Correspondencia( Aplicacion ap)
        {
            aplicacion = ap;
        }

        public char encriptar (char entrada)
        {
            return aplicacion.Encriptar(entrada);
        }

        public int GetOffset()
        {
            return aplicacion.getOffset();
        }
    }
}
