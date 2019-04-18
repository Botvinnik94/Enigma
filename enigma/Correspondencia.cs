using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class Correspondencia
    {
        Aplicacion aplicacion;
        //TODO manejo de eventos
        public Correspondencia( Aplicacion ap)
        {
            aplicacion = ap;
        }

        char encriptar (char entrada)
        {
            return aplicacion.Encriptar(entrada);
        }

        public Aplicacion GetAplicacion()
        {
            return aplicacion;
        }
    }
}
