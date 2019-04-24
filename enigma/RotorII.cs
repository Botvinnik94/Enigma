using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorII : Rotor
    {
        private Aplicacion apR2 = new Aplicacion(outputII.ToCharArray());
        const string outputII = "ajdksiruxblhwtmcqgznpyfvoe";

        public RotorII() : base()
        {
            aplicacion = apR2;
        }
    }
}
