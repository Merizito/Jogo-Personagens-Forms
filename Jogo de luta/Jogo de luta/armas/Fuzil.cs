using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_luta.armas
{
    class Fuzil : IArma_IF
    {
        public Fuzil() { }
        public void usarArma()
        {
            Console.WriteLine("Tiros de Fuzil!!\nTra tra tra tra");
        }
    }
}
