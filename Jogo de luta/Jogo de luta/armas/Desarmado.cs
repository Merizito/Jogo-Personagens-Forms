using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_luta.armas
{
    class Desarmado : IArma_IF
    {
        public Desarmado() { }
        public void usarArma()
        {
            Console.WriteLine("Estou desarmado\n:/");
        }
    }
}
