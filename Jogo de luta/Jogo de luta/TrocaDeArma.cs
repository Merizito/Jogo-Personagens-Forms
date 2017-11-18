using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_luta
{
    public partial class TrocaDeArma : Form
    {
        string personagem;
        public TrocaDeArma()
        {
            InitializeComponent();
        }
        public TrocaDeArma(string personagem)
        {
            EscolhaPersonagem person = new EscolhaPersonagem();
            InitializeComponent();
            label1.Text = personagem;
            this.personagem = personagem;

            FileStream arq2 = new FileStream("armas" + ".txt", FileMode.Open);
            StreamReader ler = new StreamReader(arq2);

            string[] conteudo = ler.ReadToEnd().Split('\n');
            ler.Close();
            int qntLinhas = File.ReadAllLines("armas"+ ".txt").Length;

            for (int i = 0; i < qntLinhas; i++)
            {
                comboBox1.Items.Add(conteudo[i]);
            }
        }
        private void TrocaDeArma_Load(object sender, EventArgs e)
        {

        }
        public string getValor() {
            return comboBox1.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                if (personagem == "1")
                {
                    Program.arma1 = comboBox1.Text;
                    Close();
                }
                else {
                    Program.arma2 = comboBox1.Text;
                    Close();
                }

            }
            else
                MessageBox.Show("ESCOLHA UMA NOVA ARMA!");
        }

        private void TrocaDeArma_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
