using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jogo_de_luta.armas
{
    class Desarmado : IArma_IF
    {
        public Desarmado() { }
        public void usarArma()
        {
            Console.WriteLine("Estou desarmado\n:/");
        }
        public void SalvarNome()
        {
            FileStream arq = new FileStream("armas.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq);


        }
    }
}
