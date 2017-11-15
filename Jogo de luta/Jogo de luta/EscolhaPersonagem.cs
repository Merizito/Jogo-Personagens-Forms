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
        public EscolhaPersonagem(string p1, string p2) {

            InitializeComponent();
            AddPersonagem("personagens");
            AddPersonagem("armas");
            Player1.Text = p1;
            label2.Text = p2;
            ImagemPlayer1.Image = Properties.Resources.dragao;
            //ImagemPlayer2.ImageLocation = "soldado.png";

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
        }

        private void Player1_Click(object sender, EventArgs e)
        {

        }

        private void EscolhaPersonagem_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getNome;

            getNome = Convert.ToString(comboBox1.SelectedIndex);    //Dragao = 0 / Soldado =1 / Lutador de sumo = 2 / General = 3.
            //MessageBox.Show(getNome);
            if (getNome == "0")                                         //Dragao
            {
                ImagemPlayer1.Image = Properties.Resources.dragao;
            }
            else if (getNome == "1")                                    //Soldado
            {
                ImagemPlayer1.Image = Properties.Resources.soldado;
            }
            else if (getNome == "2")                                    //Lutador de Sumo
            {
                ImagemPlayer1.Image = Properties.Resources.lutadorsumo;
            }
            else if (getNome == "3")                                    //General
            {
                ImagemPlayer1.Image = Properties.Resources.general;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string getNome2;

            getNome2 = Convert.ToString(comboBox3.SelectedIndex);    //Dragao = 0 / Soldado =1 / Lutador de sumo = 2 / General = 3.
            //MessageBox.Show(getNome);
            if (getNome2 == "0")                                         //Dragao
            {
                ImagemPlayer2.Image = Properties.Resources.dragao;
            }
            else if (getNome2 == "1")                                    //Soldado
            {
                ImagemPlayer2.Image = Properties.Resources.soldado;
            }
            else if (getNome2 == "2")                                    //Lutador de Sumo
            {
                ImagemPlayer2.Image = Properties.Resources.lutadorsumo;
            }
            else if (getNome2 == "3")                                    //General
            {
                ImagemPlayer2.Image = Properties.Resources.general;
            }
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Program.variaveisPersonagens(comboBox1.SelectedIndex.ToString(), comboBox2.Text, comboBox3.SelectedIndex.ToString(), comboBox4.Text);
                Close();

            }
            catch (NullReferenceException erro) {

                MessageBox.Show("TODOS OS CAMPOS DEVEM SER PREENCHIDOS!\n\n" + erro.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
                     
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


     /*   private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToUpper() == "DRAGAO")
                pictureBox1.Image = Image.FromFile(comboBox1.Text.ToLower()+".png");
            else if (comboBox1.Text.ToUpper() == "GENERAL")
                pictureBox1.Image = Properties.Resources.general;
            else if (comboBox1.Text.ToUpper() == "SOLDADO")
                pictureBox1.Image = Properties.Resources.soldado;
            else if (comboBox1.Text.ToUpper() == "LUTADOR DE SUMO")
                pictureBox1.Image = Properties.Resources.lutadorsumo;
            else
                pictureBox2.Image = Properties.Resources.dragao;
            if (comboBox1.Text.ToUpper() == "DRAGAO")
                pictureBox2.Image = Image.FromFile(comboBox1.Text.ToLower() + ".png");
            else if (comboBox1.Text.ToUpper() == "GENERAL")
                pictureBox2.Image = Properties.Resources.general;
            else if (comboBox1.Text.ToUpper() == "SOLDADO")
                pictureBox2.Image = Properties.Resources.soldado;
            else if (comboBox1.Text.ToUpper() == "LUTADOR DE SUMO")
                pictureBox2.Image = Properties.Resources.lutadorsumo;
            else
                pictureBox2.Image = Properties.Resources.dragao;


        }*/
    }
}
