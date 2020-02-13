using System;
using System.Collections.Generic;
using System.Text;
using EsteticaOliviaMaria.entidades.Enum;

namespace EsteticaOliviaMaria.entidades
{
    class Servico
    {
        public string NomeServ { get; set; }
        public double ValorSev { get; set; }
        public int DuracaoServ { get; set; }

        public Profissao TipoProfServ { get; set; }

        public double ComissaoServ { get; set; }



        public Servico(string nomeServ, double valorSev, int duracaoServ, Profissao tipoProfServ, Double comissaoServ)
        {
            NomeServ = nomeServ;
            ValorSev = valorSev;
            DuracaoServ = duracaoServ;
            TipoProfServ = tipoProfServ;
            ComissaoServ = comissaoServ;

        }


        




    }
}
