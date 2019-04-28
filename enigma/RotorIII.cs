using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorIII : Rotor
    {
        const string outputIII = "bdfhjlcprtxvznyeiwgakmusqo";

        public RotorIII(int offset) : base()
        {
            aplicacion = new Aplicacion(outputIII.ToCharArray(), offset);
        }
    }
}
