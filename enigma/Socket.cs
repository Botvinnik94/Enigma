using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class Socket
    {

        Rotor[] Rotores { get; set; }
        Plugboard Plugboard { get; set; }
        Log Log { get; set; }

        public Socket(Rotor[] r, Plugboard p)
        {
            Rotores = r;

            foreach(Rotor rotor in Rotores)
            {
                rotor.AvisoCicloCompleto += EventoCicloCompleto;//Suscripción a evento por cada uno de los rotores
            }

            Plugboard = p;
            Log = new Log();
        }
       
        public void ChangeRotor(int position, Rotor r)
        {
            if(position >= 0 && position < Rotores.Length)
            {
                Rotores[position] = r;
            }
        }

        public void ChangeOffset(Rotor r, int offset)
        {
            r.ChangeOffset(offset);
        }

        public void ChangePlugboard(Aplicacion f)
        {
            Plugboard = new Plugboard(f);
        }

        public string Enigma(string input)
        {
            StringBuilder str = new StringBuilder();

            foreach (char c in input)
            {
                str.Append(Encriptar(c));
            }

            return str.ToString();
        }

        private char Encriptar(char c)
        {
            char temp;

            Log.Entries.Add($"Input: {c}");

            temp = c;
            c = Plugboard.encriptar(c);

            Log.Entries.Add($"{temp} -> Plugboard -> {c}");

            for (int i = 0; i < Rotores.Length; i++)
            {
                temp = c;
                c = Rotores[i].Encriptar(c);

                Log.Entries.Add($"{temp} -> Rotor {i+1} -> {c}");
            }

            for (int i = Rotores.Length - 1; i >= 0; i++)
            {
                temp = c;
                c = Rotores[i].Encriptar(c);

                Log.Entries.Add($"{temp} -> Rotor {i + 1} -> {c}");
            }

            temp = c;
            c = Plugboard.encriptar(c);

            Log.Entries.Add($"{temp} -> Plugboard -> {c}");
            Log.Entries.Add($"Output: {c}");
            return c;
        }

        private void EventoCicloCompleto(object sender, EventArgs e)
        {
            Rotor r = sender as Rotor;


            for(int i = 0; i < Rotores.Length; ++i)
            {
                if(Rotores[i] == r && i < Rotores.Length - 1)
                {
                    Rotores[i + 1].Rotar();
                }
            }
        }
    }
}
