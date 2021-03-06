﻿using System;
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
        public static int Rounds = 1;
        public static int vicP1 = 0;
        public static int vicP2 = 0;
        public static int ultvit = 0;
        static string player1;
        static string player2;
        static string personagem1;
        static string personagem2;
        public static string arma1;
        public static string arma2;
        public  static bool verifica = false;
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
            Application.Run(new Regras());
            Application.Run(new EscolhaPersonagem(player1, player2));
            Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            Application.Run(new TrocaDeArma("1"));
            Application.Run(new TrocaDeArma("2"));
            Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            if (vicP2 != 2 && vicP1 != 2)
            {
                Application.Run(new TrocaDeArma(Convert.ToString(ultvit)));
                Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            }
            if (vicP1 > vicP2)
            {
                MessageBox.Show("PLAYER 1 GANHOU!!", "VITORIA");
            }
            else
                MessageBox.Show("PLAYER 2 GANHOU!!", "VITORIA");
            verifica = true;
            do
            {
                if (verifica == true)
                {
                 verifica = false;
                 StartGame();
                 DialogResult resultado= MessageBox.Show("GOSTARIA DE JOGAR NOVAMENTE?", "RECOMEÇAR", MessageBoxButtons.YesNo);
                 if (resultado == System.Windows.Forms.DialogResult.Yes)
                     verifica = true;
                }
            } while (verifica == true);
             
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
        static public void StartGame() {
            Application.Run(new Regras());
            Application.Run(new EscolhaPersonagem(player1, player2));
            Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            Application.Run(new TrocaDeArma("1"));
            Application.Run(new TrocaDeArma("2"));
            Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            if (vicP2 != 2 && vicP1 != 2)
            {
                Application.Run(new TrocaDeArma(Convert.ToString(ultvit)));
                Application.Run(new Batalha(personagem1, arma1, personagem2, arma2, verifica));
            }
            if (vicP1 > vicP2)
            {
                MessageBox.Show("PLAYER 1 GANHOU!!", "VITORIA");
            }
            else
                MessageBox.Show("PLAYER 2 GANHOU!!", "VITORIA");
        }



    }
}
