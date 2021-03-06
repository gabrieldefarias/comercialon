using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comercialon.classes
{
    public class Usuario // classe publica // declarando as propriedades
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nivel { get; set; }
        public string Situacao { get; set; }
        //======================================================================================== // gerando os construtores

        public Usuario()
        {}

        public Usuario(int id, string nome, string email, string senha, string nivel, string situacao)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }

        public Usuario(string nome, string email, string senha, string nivel, string situacao)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Nivel = nivel;
            Situacao = situacao;
        }
        //======================================================================================== // metodos de classe

        public int Inserir(int id)
        {
            return id;
        }

        public List<Usuario> ListarTodos()
        {
            List<Usuario> lista = new List<Usuario>();
            return lista;
        }

        public bool Alterar(int id)
        {
            return true;
        }

        public void BuscarId(int id)
        {}
    }
}
