using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Jogo_de_luta.armas
{
     class CuspirFogo : IArma_IF
    {
        public CuspirFogo() { }
        public void usarArma()
       {
           Console.WriteLine("Whaarrrrr! Fogo!!");
       }

        public void SalvarNome()
       {
           FileStream arq = new FileStream("armas.txt", FileMode.Append);
           StreamWriter esc = new StreamWriter(arq);
        
        
       }

    }
    
}
