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
using System.Diagnostics;
using System.IO;

namespace Jogo_de_luta
{
    public partial class EscolhaPersonagem : Form
    {
        public EscolhaPersonagem()
        {
            InitializeComponent();
            AddPersonagem("personagens");
            AddPersonagem("armas");
            
        }
        public void AddPersonagem(string x)
        {
            FileStream arq;
            try
            { 
                if (x.ToUpper() == "PERSONAGENS")
                {
                    FileStream arq2 = new FileStream(x + ".txt", FileMode.Open);
                    StreamReader ler = new StreamReader(arq2);

                    string[] conteudo = ler.ReadToEnd().Split('\n');
                    ler.Close();
                    int qntLinhas = File.ReadAllLines(x + ".txt").Length;

                    for (int i = 0; i < qntLinhas; i++)
                    {
                        comboBox1.Items.Add(conteudo[i]);
                        comboBox3.Items.Add(conteudo[i]);
                    }
                }
            
            
                else if (x.ToUpper() == "ARMAS")
                {
                    FileStream arq2 = new FileStream(x + ".txt", FileMode.Open);
                    StreamReader ler = new StreamReader(arq2);

                    string[] conteudo = ler.ReadToEnd().Split('\n');
                    ler.Close();
                    int qntLinhas = File.ReadAllLines(x + ".txt").Length;

                    for (int i = 0; i < qntLinhas; i++)
                    {
                        comboBox2.Items.Add(conteudo[i]);
                        comboBox4.Items.Add(conteudo[i]);
                    }
                }
            }
            catch (FileNotFoundException erro)
            {
                string msg = erro.FileName;
                msg = msg.Remove(0, msg.LastIndexOf("bin") - 1);
                System.Windows.Forms.MessageBox.Show("ARQUIVO NAO ENCONTRADO!\n\n..." + msg);
                System.Windows.Forms.MessageBox.Show("Gerando arquivo...");
                arq = new FileStream("armas.txt", FileMode.Append);
                arq.Close();
            }
            else if ()
            {

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Batalha batalha = new Batalha(comboBox1.Text,comboBox2.Text,comboBox3.Text,comboBox4.Text);
            
        }
    }
}
