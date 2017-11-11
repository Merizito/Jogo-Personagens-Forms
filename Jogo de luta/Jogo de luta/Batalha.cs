using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_luta
{
    public partial class Batalha : Form
    {
        public Batalha()
        {
            InitializeComponent();
        }
        public Batalha(string personagem1, string arma1, string personagem2, string arma2)
        {
            Regras regras = new Regras();
            EscolhaPersonagem escolha = new EscolhaPersonagem();
            InitializeComponent();

            regras.Close();
            escolha.Close();
        }

        private void Batalha_Load(object sender, EventArgs e)
        {

        }
    }
}
