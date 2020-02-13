using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace EsteticaOliviaMaria.entidades
{
    class Cliente
    {
        public string Name { get; set; }
        public DateTime Nascimento { get; set; }
        public double Identidade { get; set;  }
        public double CPF { get; set }
        public string Endereco { get; set;  }
        public string  Telefone { get; set; }
        public List<Agenda> ServicoAgendado { get; set; } = new List<Agenda>();



        public Cliente(string name, DateTime nascimento, double identidade, double cpf, string endereco, string telefone)
        {
            Name = name;
            Nascimento = nascimento;
            Identidade = identidade;
            CPF = cpf;
            Endereco = endereco;
            Telefone = telefone;
        }

        public Cliente(string name, DateTime nascimento, double identidade, string endereco, string telefone)
        {
            Name = name;
            Nascimento = nascimento;
            Identidade = identidade;
  
            Endereco = endereco;
            Telefone = telefone;
        }


    }

}
