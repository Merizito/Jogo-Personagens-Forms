using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta
{
   abstract class Personagens
    {
        IArma_IF arma;
        public int usoArma;
        public virtual void Desenhar() { }
        public void Falar() { }
        public void Arma()
        {
            arma.usarArma();
            usoArma++;
        }
        public void setArma(IArma_IF _arma)
        {
            this.arma = _arma;
        }

    }
}
