using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Jogo_de_luta.armas;
using Jogo_de_luta.personagem;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_de_luta
{
    public partial class EscolhaPersonagem : Form
    {
        public EscolhaPersonagem()
        {
            InitializeComponent();
            FileStream arq2 = new FileStream("personagens.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);

            string[] conteudo;
            int qntLinhas = File.ReadAllLines("personagens.txt").Length;
            ler.Close();

            conteudo = ler.ReadToEnd().Split('\n');

            for (int i = 0; i < qntLinhas; i++)
            {
                comboBox1.Items.Add(conteudo[i]);
            }
        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void EscolhaPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
