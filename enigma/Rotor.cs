using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enigma
{
    public class Rotor : Correspondencia
    {
        public delegate void AvisoCicloCompletoEventHandler(object sender, EventArgs e);

        public event AvisoCicloCompletoEventHandler AvisoCicloCompleto;

        public Rotor(Aplicacion ap): base(ap) {
            ap.CicloCompleto += EventoCicloCompleto;//Suscripción al evento
        }

        public void Rotar()
        {
            aplicacion.Rotar();
        }

        public char Encriptar(char input)
        {
            return aplicacion.Encriptar(input);
        }

        public void ChangeOffset(int offset)
        {
            aplicacion.offset = offset;
        }

        private void EventoCicloCompleto(object sender, EventArgs e)
        {
            OnAvisoCicloCompleto();
        }

        protected virtual void OnAvisoCicloCompleto()
        {
            if (AvisoCicloCompleto != null)
            {
                AvisoCicloCompleto(this, new EventArgs());
            }
        }
    }


}
