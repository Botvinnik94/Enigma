using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class RotorI : Rotor
    {
        const string outputI = "ekmflgdqvzntowyhxuspaibrcj";
        const string outputI2 = "aeltphqxrubknwcmoydfgivjzs";

        public RotorI(int offset) : base()
        {
            aplicacion = new Aplicacion(outputI.ToCharArray(), outputI2.ToCharArray(), offset);
            aplicacion.CicloCompleto += EventoCicloCompleto;
        }
    }
}
