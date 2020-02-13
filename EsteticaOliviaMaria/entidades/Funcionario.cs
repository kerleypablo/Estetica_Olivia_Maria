using System;
using System.Collections.Generic;
using System.Text;
using EsteticaOliviaMaria.entidades.Enum;

namespace EsteticaOliviaMaria.entidades
{
    class Funcionario
    {
        private string nomeFunc;
        private DateTime nascimentoFunc;
        private string profissaoFunc1;
        private double salarioFunc;

        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public Profissao profissaoFunc { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, DateTime nascimento, Profissao profissaoFunc, double salario)
        {
            Nome = nome;
            Nascimento = nascimento;
            this.profissaoFunc = profissaoFunc;
            Salario = salario;
        }


    }
}
