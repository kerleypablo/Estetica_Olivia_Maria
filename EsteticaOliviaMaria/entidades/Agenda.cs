using System;
using System.Collections.Generic;
using System.Text;

namespace EsteticaOliviaMaria.entidades
{
    class Agenda
    {
        public DateTime DataAgen { get; set; }
        public DateTime HoraAgen { get; set; }
        public Servico TipoServ { get; set; }
        public Cliente ClienteAgen { get; set; }
        public Servico ValorServAg { get; set; }

        public Agenda(DateTime dataAgen, DateTime horaAgen, Servico tipoServ, Cliente clienteAgen, Servico valorServiAg)
        {
            DataAgen = dataAgen;
            HoraAgen = horaAgen;
            TipoServ = tipoServ;
            ClienteAgen = clienteAgen;
            ValorServAg = valorServiAg;
        }

        public String DataMarcada()
        {

            return ClienteAgen.Name +
                " data: " + DataAgen +
                " Serviço " + TipoServ.NomeServ +
                " Hora :" + HoraAgen +
                " Valor : " + ValorServAg.ValorSev;

        }
             

    }
}
