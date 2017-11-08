using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using System.Threading.Tasks;
using System.IO;

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
            setNome("Soldado");
            setArma(new Revolver());
        }
        /*public void SalvarNome()
        {
            FileStream arq2 = new FileStream("personagens.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq2);

        }*/
     
    }
}
