using System;
using System.Collections.Generic;

namespace comercialon.classes
{
    public class Cliente // classe publica // projeto de aula - ti89 // declaração de propriedades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email{ get; set; }
        public string Telefone { get; set; }
        public List<Endereco> Endereco { get; set; } // lista de endereços
        public bool Ativo { get; set; }
        //======================================================================================== // gerando os construtores

        public Cliente()
        {
            Id = 0;
        }

        public Cliente(int id, string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }

        public Cliente(string nome, string cpf, string email, string telefone, bool ativo = true, List<Endereco> endereco = null)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Telefone = telefone;
            Endereco = endereco;
            Ativo = ativo;
        }
        //======================================================================================== // métodos da classe

        public void Inserir() // inserir
        {}

        public bool Alterar(int id) // alterar
        {
            return true;
        }

        public List<Cliente> ListarTodos() // listar todos os clientes
        {
            List<Cliente> lista = new List<Cliente>(); // codigo de listar cliente
            return lista; // retornar a lista de cliente
        }

        public void BuscarId(int id) // buscar id
        {}
    }
}
