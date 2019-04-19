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

        public RotorII(Aplicacion ap) : base(ap)
        {
            ap.output = outputII.ToCharArray();
        }
    }
}
