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


            Personagens.SalvarPersonagem(drag.getNome());
            Personagens.SalvarPersonagem(soldado.getNome());
            Personagens.SalvarPersonagem(lutador.getNome());
            Personagens.SalvarPersonagem(general.getNome());
            Armas.SalvarArma(fuzil.getNome());
            Armas.SalvarArma(cuspirfogo.getNome());
            Armas.SalvarArma(desarmado.getNome());
            Armas.SalvarArma(revolver.getNome());


            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Regras());
            Application.Run(new EscolhaPersonagem());

        }
    }
}
