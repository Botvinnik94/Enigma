using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    class Socket
    {

        public Rotor[] Rotores { get; set; }
        Plugboard Plugboard { get; set; }
        public Log Log { get; set; }
        private Aplicacion Reflector;
        //private int rotorArotar;

        public event EventHandler EncriptacionFinalizada;
        public event EventHandler EventoRotacionRotor;

        public Socket(Rotor[] r, Plugboard p)
        {
            Rotores = r;

            //this.rotorArotar = 0;//CHANGED

            foreach(Rotor rotor in Rotores)
            {
                rotor.AvisoCicloCompleto += EventoCicloCompleto;//Suscripción a evento por cada uno de los rotores
                rotor.AvisoRotacion += EventoRotacion;
            }

            Plugboard = p;
            Reflector = new Aplicacion("yruhqsldpxngokmiebfzcwvjat".ToCharArray());//reflector tipo B
            Log = new Log();
        }

        private void EventoRotacion(object sender, EventArgs e)
        {
            Rotor r = sender as Rotor;

            for (int i = 0; i < Rotores.Length; ++i)
            {
                if (Rotores[i] == r)
                {
                    OnEventoRotacionRotor(i);
                }
            }
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
            //if (offset == 26) //CHANGED
            //{
            //    for(int i=0; i< Rotores.Length; i++)
            //    {
            //        if (Rotores[i] == r)
            //        {
            //            this.rotorArotar = i;
            //        }
            //    }
            //}
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

            OnEncriptacionFinalizada();
            return str.ToString();
        }

        private char Encriptar(char c)
        {
            char temp;

            Log.Entries.Add($"Input: {c}");

            c = Char.ToLower(c);
            temp = c;
            c = Plugboard.Encriptar(c);

            Log.Entries.Add($"{temp} -> Plugboard -> {c}");

            for (int i = 0; i < Rotores.Length; i++)
            {
                temp = c;
                c = Rotores[i].Encriptar(c);
                
                Log.Entries.Add($"{temp} -> Rotor {i+1} -> {c}");
            }

            temp = c;
            c = Reflector.Encriptar(c);
            Log.Entries.Add($"{temp} -> Reflector -> {c}");

            for (int i = Rotores.Length - 1; i >= 0; i--)
            {
                temp = c;
                c = Rotores[i].EncriptarInverso(c);

                //if (i == this.rotorArotar)
                //{
                //    Rotores[rotorArotar].Rotar(); //CHANGED
                //}

                Log.Entries.Add($"{temp} -> Rotor {i + 1} -> {c}");
            }

            temp = c;
            c = Plugboard.EncriptarInverso(c);

            Rotores[0].Rotar();

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
                    //this.rotorArotar = i+1; //CHANGED
                    Rotores[i + 1].Rotar();
                }
            }
        }

        protected virtual void OnEncriptacionFinalizada()
        {
            EncriptacionFinalizada?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnEventoRotacionRotor(int? index)
        {
            EventoRotacionRotor?.Invoke(index, EventArgs.Empty);
        }
    }
}
