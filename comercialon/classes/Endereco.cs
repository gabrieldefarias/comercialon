﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Endereco
    { // declarando as propriedades
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        //========================================================================================

        public Endereco() // gerando os construtores
        { }

        public Endereco(string logradouro, string numero, string complemento, string cep, string bairro, string cidade, string estado = null)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado; // não obrigatorio por causa do "estado = null"
        }
    }
}
