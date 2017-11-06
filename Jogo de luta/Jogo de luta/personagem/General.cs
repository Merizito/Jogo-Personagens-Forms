using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta.personagem
{
    class General : Personagens
    {
        public override void Desenhar()
        {
            Console.WriteLine("(-.-)\nSou um General!!!");
        }
        public General()
        {
            setArma(new Fuzil());
        }
    }
}
