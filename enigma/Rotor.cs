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
        public event EventHandler AvisoRotacion;

        public Rotor(Aplicacion ap): base(ap) {
            ap.CicloCompleto += EventoCicloCompleto;//Suscripción al evento
        }

        public Rotor() : base()
        {
        }

        public void Rotar()
        {
            ChangeOffset(aplicacion.offset + 1);
        }

        public void ChangeOffset(int offset)
        {
            aplicacion.offset = offset;
            OnAvisoRotacion();
        }

        protected void EventoCicloCompleto(object sender, EventArgs e)
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

        protected virtual void OnAvisoRotacion()
        {
            AvisoRotacion?.Invoke(this, EventArgs.Empty);
        }
    }


}
