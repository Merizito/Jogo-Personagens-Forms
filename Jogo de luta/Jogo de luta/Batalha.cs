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
            InitializeComponent();
            button5.Enabled = false;

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

            RamdomATKDEF();

        }
        void RamdomATKDEF() {
            Random rand = new Random();

            ATK1.Maximum = rand.Next(25, 125);
            ATK1.Minimum = 0;
            textATK1.Text = ATK1.Maximum.ToString();    
            ATK1.Increment(Convert.ToInt32(textATK1.Text));

            ATK2.Maximum = rand.Next(25, 125);
            ATK2.Minimum = 0;
            textATK2.Text = ATK2.Maximum.ToString();
            ATK2.Increment(Convert.ToInt32(textATK2.Text));

            DEF1.Maximum = rand.Next(25, 125);
            DEF1.Minimum = 0;
            textDEF1.Text = DEF1.Maximum.ToString();
            DEF1.Increment(Convert.ToInt32(textDEF1.Text));

            DEF2.Maximum = rand.Next(25, 125);
            DEF2.Minimum = 0;
            textDEF2.Text = DEF2.Maximum.ToString();
            DEF2.Increment(Convert.ToInt32(textDEF2.Text));

        }
        private void Batalha_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                HP1.Value = (HP1.Value - ATK2.Value);
                textHP1.Text = HP1.Value.ToString();
                RamdomATKDEF();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (ATK2.Value > HP1.Value)
                {
                    textHP1.Text = "0";
                    HP1.Value = 0;
                    MessageBox.Show("Player 2 ganhou!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button3.Enabled = false;
                    button5.Enabled = true;
                }  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HP2.Value = (HP2.Value - ATK1.Value);
                textHP2.Text = HP2.Value.ToString();
                RamdomATKDEF();
            }
            catch (ArgumentOutOfRangeException)
            {
                if (ATK1.Value > HP2.Value)
                {
                    textHP2.Text = "0";
                    HP2.Value = 0;
                    MessageBox.Show("Player 1 ganhou!");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button4.Enabled = false;
                    button3.Enabled = false;
                    button5.Enabled = true;
                }
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
            Environment.Exit(0);
        }
    }
}
