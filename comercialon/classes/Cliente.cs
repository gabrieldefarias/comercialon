using System;
using System.Collections.Generic;

namespace comercialon.classes
{
    public class Cliente // classe publica // projeto de aula - ti89 - comercialon
    { // declaração de atributo
        public int Id {get; set;}
        public string Nome {get; set;}
        
        public Cliente() // métodos construtores
        {}
        public Cliente(string nome) // nome
        {
            Nome = nome;
        }
        public Cliente(int id, string nome) // id, nome
        {
            Id = id;
            Nome = nome;
        }

        public void Inserir() // métodos da classe // inserir
        {}
        public bool Alterar(int id) // alterar
        {
            return true;
        }
        public List<Cliente> ListarTodos() // listar todos
        {
            List<Cliente> lista = new List<Cliente>(); // codigo de listar
            return lista; // retornar a lista
        }
        public void BuscarId(int id) // buscar id
        {

        }
    }
}
