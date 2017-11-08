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

            string leitura = "";
            try
            {
                FileStream rea = new FileStream("personagens.txt", FileMode.Open);
                StreamReader ler = new StreamReader(rea);
                leitura = ler.ReadToEnd();
                ler.Close();
            }
            catch (FileNotFoundException erro)
            {
                string msg = erro.FileName;
                msg = msg.Remove(0, 120);
                System.Windows.Forms.MessageBox.Show("ARQUIVO NAO ENCONTRADO\n\n..." + msg);
                FileStream arq2 = new FileStream("personagens.txt", FileMode.Create);
                arq2.Close();
            }
            if (leitura.Contains("Dragão") == false)
            {
                
                FileStream arq2 = new FileStream("personagens.txt", FileMode.Append);
                StreamWriter esc2 = new StreamWriter(arq2);
                esc2.WriteLine("Dragão");
                esc2.Close();

            }
        }

    }
    
}
