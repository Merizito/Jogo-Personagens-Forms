using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jogo_de_luta.personagem;
using Jogo_de_luta.armas;
using System.Windows.Forms;

namespace Jogo_de_luta
{
    static class Program
    {
        static string player1;
        static string player2;
        static string personagem1;
        static string personagem2;
        static string arma1;
        static string arma2;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            ///personagens
            Dragao drag = new Dragao();
            Soldado soldado = new Soldado();
            LutadorSumo lutador = new LutadorSumo();
            General general = new General();
            ///armas
            Fuzil fuzil = new Fuzil();
            CuspirFogo cuspirfogo = new CuspirFogo();
            Desarmado desarmado = new Desarmado();
            Revolver revolver = new Revolver();
            ///Escolher Personagens
            

            Application.SetCompatibleTextRenderingDefault(false);
            Regras regra = new Regras();
            regra.Receber(regra);
         //   Application.Run(regra);
           // Application.Run(new EscolhaPersonagem(player1,player2));
            Application.Run(new Batalha(personagem1, arma1, personagem2, arma2));

        }
        public static void variaveisPersonagens(string textbox2,string textbox3) {
            player1=textbox2;
            player2=textbox3;
        }
        public static void variaveisPersonagens(string textbox1, string textbox2, string textbox3, string textbox4)
        {
            personagem1 = textbox1;
            arma1 = textbox2;
            personagem2 = textbox3;
            arma2 = textbox4;

        }



    }
}
