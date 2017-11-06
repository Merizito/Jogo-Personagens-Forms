using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta.personagem
{
    class Soldado : Personagens
    {
        public override void Desenhar()
        {
            Console.WriteLine("(º.º)\nSou um Soldado!!");
        }
        public Soldado()
        {
            setArma(new Revolver());
        }
    }
}
