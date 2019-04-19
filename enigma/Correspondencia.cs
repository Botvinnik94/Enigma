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
        public Correspondencia( Aplicacion ap)
        {
            aplicacion = ap;
        }

        char encriptar (char entrada)
        {
            return aplicacion.Encriptar(entrada);
        }
    }
}
