using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jogo_de_luta.armas
{
    class Fuzil : IArma_IF
    {
        public Fuzil() { }
        public void usarArma()
        {
            Console.WriteLine("Tiros de Fuzil!!\nTra tra tra tra");
        }
        public void SalvarNome()
        {
            FileStream arq = new FileStream("armas.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq);


        }
    }
}
