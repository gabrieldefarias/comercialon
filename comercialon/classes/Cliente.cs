using System;
using System.Collections.Generic;

namespace comercialon.classes
{
    public class Cliente // classe publica // projeto de aula - ti89
    { // declaração de atributo
        public int Id {get; set;}
        public string Nome {get; set;}
        // métodos construtores


        public Cliente()
        {}
        public Cliente(string nome)
        {
            Nome = nome;
        }
        public Cliente(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        // métodos da classe
        public void Inserir()
        {}
        public bool Alterar(int id)
        {
            return true;
        }
        public List<Cliente> ListarTodos()
        {
            List<Cliente> lista = new List<Cliente>();
            // codigo de listar
            return lista;
        }
        public void BuscarId(int id)
        {

        }
    }
}
