﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Cliente
{
    public class Titular
    {
        public Titular(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
            ContasCriadas++;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public static decimal ContasCriadas { get; private set; }
    }
}