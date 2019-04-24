using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorI : Rotor
    {
        private Aplicacion apR1 = new Aplicacion(outputI.ToCharArray());
        const string outputI = "ekmflgdqvzntowyhxuspaibrcj";

        public RotorI() : base()
        {
            aplicacion = apR1;
        }
    }
}
