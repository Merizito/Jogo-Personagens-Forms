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

            Personagens.SalvarNome(drag.getNome());
            Personagens.SalvarNome(soldado.getNome());
            


            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Regras());
            Application.Run(new EscolhaPersonagem());

        }
    }
}
