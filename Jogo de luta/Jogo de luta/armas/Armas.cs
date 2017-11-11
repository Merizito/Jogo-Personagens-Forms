using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Jogo_de_luta.armas
{
    class Armas
    {
        private string Nome;
        static public void SalvarArma(string nome1)
        {
            FileStream arq;
            StreamReader ler;
            StreamWriter esc;
            string leitura = "";

            try
            {
                arq = new FileStream("armas.txt", FileMode.Open);
                ler = new StreamReader(arq);
                leitura = ler.ReadToEnd();
                ler.Close();
                arq.Close();
            }
            catch (FileNotFoundException erro)
            {
                string msg = erro.FileName;
                msg = msg.Remove(0, msg.LastIndexOf("bin") - 1);
                System.Windows.Forms.MessageBox.Show("ARQUIVO NAO ENCONTRADO!\n\n..." + msg);
                System.Windows.Forms.MessageBox.Show("Gerando arquivo...");
                arq = new FileStream("armas.txt", FileMode.Create);
                arq.Close();
            }

            if (leitura.Contains(nome1) == false)
            {
                arq = new FileStream("armas.txt", FileMode.Append);
                esc = new StreamWriter(arq);
                esc.WriteLine(nome1);
                esc.Close();
                arq.Close();
            }

        }
        public string getNome() {
            return this.Nome;
        }
        public void setNome(string nome) {
            this.Nome = nome;
            SalvarArma(nome);
        }
    }
}
