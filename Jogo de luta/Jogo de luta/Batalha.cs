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
        public static int Rounds = 1;
        static int vicP1 = 0;
        static int vicP2 = 0;
        public Batalha()
        {
            InitializeComponent();
        }
        public Batalha(string getNome, string arma1, string getNome2, string arma2, bool verfica)
        {
            string personagem1 = "";
            string personagem2 = "";

            InitializeComponent();
            RoundsTextBox.Text = +Rounds+" º"+" ROUND";

            player2Atk.Enabled = false;
            player2Def.Enabled = false;

            if (getNome == "0")                                         //Dragao
            {
                ImagemPlayer1.Image = Properties.Resources.dragao;
                personagem1 = "dragao";
            }
            else if (getNome == "1")                                    //Soldado
            {
                ImagemPlayer1.Image = Properties.Resources.soldado;
                personagem1 = "soldado";

            }
            else if (getNome == "2")                                    //Lutador de Sumo
            {
                ImagemPlayer1.Image = Properties.Resources.lutadorsumo;
                personagem1 = "lutadorsumo";

            }
            else if (getNome == "3")                                    //General
            {
                ImagemPlayer1.Image = Properties.Resources.general;
                personagem1 = "general";

            }

            if (getNome2 == "0")                                         //Dragao
            {
                ImagemPlayer2.Image = Properties.Resources.dragao;
                personagem2 = "Dragao";
            }
            else if (getNome2 == "1")                                        //Soldado
            {
                ImagemPlayer2.Image = Properties.Resources.soldado;
                personagem2 = "soldado";
            }
            else if (getNome2 == "2")                                    //Lutador de Sumo
            {
                ImagemPlayer2.Image = Properties.Resources.lutadorsumo;
                personagem2 = "lutadorsumo";
            }
            else if (getNome2 == "3")                                    //General
            {
                ImagemPlayer2.Image = Properties.Resources.general;
                personagem2 = "general";
            }

            textBox1.Text = personagem1;
            textBox2.Text = personagem2;

            HP1.Maximum = 1000;
            HP1.Minimum = 0;
            HP1.Increment(1000);
            textHP1.Text = HP1.Maximum.ToString();

            HP2.Maximum = 1000;
            HP2.Minimum = 0;
            textHP2.Text = HP2.Maximum.ToString();
            HP2.Increment(1000);

            RandomATKDEF();
            RamdomATKDEF2();
        }
        void RandomATKDEF()
        {
            Random rand = new Random();

            ATK1.Maximum = rand.Next(25, 125);
            ATK1.Minimum = 0;
            textATK1.Text = ATK1.Maximum.ToString();
            ATK1.Increment(Convert.ToInt32(textATK1.Text));

            DEF1.Maximum = rand.Next(25, 125);
            DEF1.Minimum = 0;
            textDEF1.Text = DEF1.Maximum.ToString();
            DEF1.Increment(Convert.ToInt32(textDEF1.Text));
        }
        void RamdomATKDEF2() {
            Random rand2 = new Random();

            ATK2.Maximum = rand2.Next(25, 125);
            ATK2.Minimum = 0;
            textATK2.Text = ATK2.Maximum.ToString();
            ATK2.Increment(Convert.ToInt32(textATK2.Text));

            DEF2.Maximum = rand2.Next(25, 125);
            DEF2.Minimum = 0;
            textDEF2.Text = DEF2.Maximum.ToString();
            DEF2.Increment(Convert.ToInt32(textDEF2.Text));

        }
        private void Batalha_Load(object sender, EventArgs e)
        {

        }
        private void player2Atk_Click(object sender, EventArgs e)
        {
            try
            {
                HP1.Value = (HP1.Value - ATK2.Value);
                textHP1.Text = HP1.Value.ToString();
                RamdomATKDEF2();
                player1Atk.Enabled = true;
                player1Def.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                HP1.Value = 0;
                if (ATK2.Value > HP1.Value)
                {
                    textHP1.Text = "0";
                    HP1.Value = 0;
                    MessageBox.Show("Player 2 ganhou!");
                    player1Atk.Enabled = false;
                    player1Def.Enabled = false;
                    player2Atk.Enabled = false;
                    player2Def.Enabled = false;
                    button5.Enabled = true;
                    Program.Rounds++;
                    Batalha.Rounds++;
                    Program.vicP2++;
                    Program.ultvit = 1;

                    Close();
                }  
            }
            finally
            {
                player2Atk.Enabled = false;
                player2Def.Enabled = false;
            }
        }
      /*  public void ProximoRound(int vencedor) {
            TrocaDeArma novaarma = new TrocaDeArma();
            if (Rounds == 1)
            {
                this.Hide();
                Application.Run(new TrocaDeArma(textBox1.Text));
                string novaarmaperson1 = novaarma.getValor();
                Application.Run( new TrocaDeArma(textBox2.Text));
                string novaarmaperson2 = novaarma.getValor();
                this.Show();
            }
            else if (Rounds == 2)
            {
                if (vencedor == 1)
                {
                    Application.Run(new TrocaDeArma(textBox2.Text));
                    string novaarmaperson1 = novaarma.getValor();
                }
                else
                {
                    Application.Run(new TrocaDeArma(textBox1.Text));
                    string novaarmaperson2 = novaarma.getValor();
                }
            }


        }*/
        private void player1Atk_Click(object sender, EventArgs e)
        {
            try
            {
                HP2.Value = (HP2.Value - ATK1.Value);
                textHP2.Text = HP2.Value.ToString();
                RandomATKDEF();
                player2Atk.Enabled = true;
                player2Def.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                if (ATK1.Value > HP2.Value)
                {
                    textHP2.Text = "0";
                    HP2.Value = 0;
                    MessageBox.Show("Player 1 ganhou!");
                    player1Atk.Enabled = false;
                    player1Def.Enabled = false;
                    player2Atk.Enabled = false;
                    player2Def.Enabled = false;
                    button5.Enabled = true;
                    Program.Rounds++;
                    Batalha.Rounds++;
                    Program.vicP1++;
                    Program.ultvit = 2;
                    Close();
                }
            }
            finally
            {
                player1Atk.Enabled = false;
                player1Def.Enabled = false;
            }
        }
        private void HP1_Click(object sender, EventArgs e)
        {

        }
        private void textHP1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
        private void player1Def_Click(object sender, EventArgs e)
        {

        }
        private void player2Def_Click(object sender, EventArgs e)
        {

        }

        private void RoundsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
