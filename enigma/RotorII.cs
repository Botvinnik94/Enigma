using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorII : Rotor
    {
        const string outputII = "ajdksiruxblhwtmcqgznpyfvoe";

        public RotorII(int offset) : base()
        {
            aplicacion = new Aplicacion(outputII.ToCharArray(), offset);
        }
    }
}
