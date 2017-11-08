using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jogo_de_luta.personagem;
using System.Windows.Forms;

namespace Jogo_de_luta
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Dragao drag = new Dragao();
            Soldado soldado = new Soldado();
            LutadorSumo lutador = new LutadorSumo();
            General general = new General();

            Personagens.SalvarNome(drag.getNome());
            Personagens.SalvarNome(soldado.getNome());
            Personagens.SalvarNome(lutador.getNome());
            Personagens.SalvarNome(general.getNome());
            


            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Regras());
            Application.Run(new EscolhaPersonagem());

        }
    }
}
