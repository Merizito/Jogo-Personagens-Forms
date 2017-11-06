using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Jogo_de_luta.armas;

namespace Jogo_de_luta
{
    class Dragao : Personagens
    {

        public override void Desenhar()
        {
            Console.WriteLine("<`;`>\nSou um Dragão!");
        }
        public Dragao()
        {
            setArma(new CuspirFogo());

        }
        public void SalvarNome()
        {
            FileStream arq2 = new FileStream("personagens.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq2);

            esc.Write("Dragão");
        }

    }
}
