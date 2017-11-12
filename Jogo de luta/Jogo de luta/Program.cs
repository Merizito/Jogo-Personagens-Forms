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
        static string a;
        static string b;
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
            Application.Run(regra);
            Application.Run(new EscolhaPersonagem(a,b));


        }
        public static void variaveisPersonagens(string x,string y) {
             a=x;
            b=y;
        }



    }
}
