using System.Collections.Generic;
using  Amazonia.DAL;
using System;

namespace Amazonia.DAL.Repositorios
{
    public class RepositorioCliente : IRepositorio<Cliente>
    {
        private List<Cliente> ListaClientes;
        public RepositorioCliente()
        {
            ListaClientes = new List<Cliente>();
            var joao = new Cliente();
            joao.Nome = "Joao";
            joao.DataNascimento = new DateTime(1984,05,29);

            var maria = new Cliente{ Nome="Maria", DataNascimento = new DateTime(1950,01,01) };
            var marta = new Cliente{Nome="Marta",  DataNascimento =new DateTime(2021,01,02)};

            ListaClientes.Add(joao);
            ListaClientes.Add(maria);
            ListaClientes.Add(marta);
        }

        public void Apagar(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public Cliente Atualizar(Cliente obj)
        {
            throw new System.NotImplementedException();
        }

        public void Criar(Cliente obj)
        {
            ListaClientes.Add(obj);
        }

        public Cliente ObterPorNome(string Nome)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            return ListaClientes;
        }
    }
}