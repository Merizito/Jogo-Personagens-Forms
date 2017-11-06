using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta
{
    class Dragao:Personagens
    {

        public override void Desenhar()
        {
            Console.WriteLine("<`;`>\nSou um Dragão!");
        }
        public Dragao()
        {
            setArma(new CuspirFogo());

        }
    }
}
