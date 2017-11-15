using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_de_luta
{
    public partial class Regras : Form
    {
        public Regras()
        {
            InitializeComponent();
            textBox1.Text = "//ALGUMA INFORMAÇÃO SOBRE OS DESENVOLVEDORES";
            textBox2.Text = "Player1";
            textBox3.Text = "Player2";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Regras_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Program.variaveisPersonagens(textBox2.Text, textBox3.Text);
            Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
