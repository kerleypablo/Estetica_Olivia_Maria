using System;
using System.Collections.Generic;
using System.Text;

namespace EsteticaOliviaMaria.entidades.Enum
{
    class Comissao
    {

        public DateTime Data { get; set; }
        public double ValorPorServico { get; set; }
        public Servico Tratamento  { get; set; }
        public Funcionario Funcionario { get; set; }


        public Comissao(DateTime data, double valorPorServiço , Servico tratamento,Funcionario funcionario)
        {
            Data = data;
            ValorPorServico = valorPorServiço;
            Tratamento = tratamento;
            Funcionario = funcionario;
            
        }


        public double ValorComissao()
        {
            return ValorPorServico * Tratamento.ComissaoServ ;

        }






    }

}
