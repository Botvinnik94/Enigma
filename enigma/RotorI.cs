using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorI : Rotor
    {
        const string outputI = "ekmflgdqvzntowñyhxuspaibrcj";

        public RotorI(int offset) : base()
        {
            aplicacion = new Aplicacion(outputI.ToCharArray(), offset);
            aplicacion.CicloCompleto += EventoCicloCompleto;
        }

        public override string ToString()
        {
            return "I";
        }
    }
}
