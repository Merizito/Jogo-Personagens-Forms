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

        public Dragao()
        {
            setNome("Dragao");
            setArma(new CuspirFogo());
        }
        public override void Desenhar()
        {
            Console.WriteLine("<`;`>\nSou um Dragão!");
        }
        public Dragao(string nome)
        {
            setNome(nome);
            setArma(new CuspirFogo());

        }
        /* public void SalvarNome()
        {
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
                FileStream arq3 = new FileStream("personagens.txt", FileMode.Create);
                arq3.Close();
            }
            leitura = leitura.ToLower();
            if (leitura.("dragao") == false)
            { 
                    FileStream arq2 = new FileStream("personagens.txt", FileMode.Append);
                    StreamWriter esc = new StreamWriter(arq2);
                    esc.WriteLine("Dragao");
                    esc.Close();

            }*/


    

    }
}
