using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_luta.armas
{
    class Revolver : IArma_IF
    {
        public Revolver() { }
        public void usarArma()
        {
            Console.WriteLine("Tiro de revolver!!\nPah!");
        }
    }
}
