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
        const string outputIII2 = "abdhpejtcflvmzoyqirwukxsgn";

        public RotorIII(int offset) : base()
        {
            aplicacion = new Aplicacion(outputIII.ToCharArray(), outputIII2.ToCharArray(), offset);
            aplicacion.CicloCompleto += EventoCicloCompleto;
        }
    }
}
