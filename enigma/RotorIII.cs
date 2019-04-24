using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorIII : Rotor
    {
        private Aplicacion apR3 = new Aplicacion(outputIII.ToCharArray());
        const string outputIII = "bdfhjlcprtxvznyeiwgakmusqo";

        public RotorIII() : base()
        {
            aplicacion = apR3;
        }
    }
}
