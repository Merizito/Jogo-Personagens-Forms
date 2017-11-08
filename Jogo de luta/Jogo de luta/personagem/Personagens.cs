using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Jogo_de_luta.armas;
using System.Threading.Tasks;

namespace Jogo_de_luta
{
    abstract class Personagens
    {
        string nome;
        IArma_IF arma;
        public int usoArma;
        public virtual void Desenhar() { }
        public void Falar() { }
        public void Arma()
        {
            arma.usarArma();
            usoArma++;
        }

        public void setNome(string nome) {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setArma(IArma_IF _arma)
        { 
            this.arma = _arma;
        }
        static public void SalvarNome(string nome1)
        {
            FileStream arq;
            StreamReader ler;
            StreamWriter esc;
            string leitura = "";

            try
            {
                arq = new FileStream("personagens.txt", FileMode.Open);
                ler = new StreamReader(arq);
                leitura = ler.ReadToEnd();
                ler.Close();
                arq.Close();
            }
            catch (FileNotFoundException erro)
            {
                string msg = erro.FileName;
                msg = msg.Remove(0, 120);
                System.Windows.Forms.MessageBox.Show("ARQUIVO NAO ENCONTRADO\n\n..." + msg);
                System.Windows.Forms.MessageBox.Show("Gerando arquivo...o");
                arq = new FileStream("personagens.txt", FileMode.Create);
                arq.Close();
            }

            if (leitura.Contains(nome1) == false)
            {
                arq = new FileStream("personagens.txt", FileMode.Append);
                esc = new StreamWriter(arq);
                esc.WriteLine(nome1);
                esc.Close();
                arq.Close();
            } 

        }
    }
}
