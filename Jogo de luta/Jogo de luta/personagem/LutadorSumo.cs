using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta.personagem
{
    class LutadorSumo : Personagens
    {
        public override void Desenhar()
        {
            Console.WriteLine("(>.<)\nSou um Lutador de Sumo!");
        }
        public LutadorSumo()
        {
            setArma(new Desarmado());
        }

    }
}
