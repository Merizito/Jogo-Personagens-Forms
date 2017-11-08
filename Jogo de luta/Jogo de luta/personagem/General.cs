using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;
using System.IO;

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
        /*public void SalvarNome()
        {
            FileStream arq2 = new FileStream("personagens.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq2);


        }*/
    }
}
