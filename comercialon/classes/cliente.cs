using System;
using System.Collections.Generic;

namespace comercialon.classes
{
    public class Cliente // classe publica // projeto de aula - ti89 - comercialon
    { // declaração de propriedades
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email{ get; set; }
        public string Telefone { get; set; }


        public Cliente()
        {
            Id = 0;
        }

        public void Inserir() // métodos da classe // inserir
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
