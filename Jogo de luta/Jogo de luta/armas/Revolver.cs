using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jogo_de_luta.armas
{
    class Revolver : IArma_IF
    {
        public Revolver() { }
        public void usarArma()
        {
            Console.WriteLine("Tiro de revolver!!\nPah!");
        }
        public void SalvarNome()
        {
            FileStream arq = new FileStream("armas.txt", FileMode.Append);
            StreamWriter esc = new StreamWriter(arq);


        }
    }
}
