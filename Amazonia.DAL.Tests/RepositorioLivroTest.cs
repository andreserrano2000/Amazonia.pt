using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazonia.DAL.Repositorios;
using Amazonia.DAL.Entidades;
using System.Collections.Generic;
using System.Linq;
using System;
using Amazonia.DAL.Infraestrutura;

namespace Amazonia.DAL.Tests
{
    [TestClass]
    public class RepositorioLivroTest
    {
        [TestMethod]
        public void DeveCriarUmObjetoDoTipoRepositorioLivros()
        {
            //Arrange
            RepositorioLivro repositorio;

            //Act
            repositorio = new RepositorioLivro();

            //Assert
            Assert.IsNotNull(repositorio);
        }

        [TestMethod]
        public void DeveCriarUmaListaDeLivrosNoObjetoDoTipoRepositorioLivros()
        {
            //Arrange
            RepositorioLivro repositorio;
            List<Livro> livros;
            var quantidadeElementos = 5;

            //Act
            repositorio = new RepositorioLivro();
            livros = repositorio.ObterTodos();
            var quantidadeLivrosNoRepositorio = livros.Count;

            //Assert
            Assert.IsNotNull(repositorio);
            Assert.IsNotNull(livros);
            Assert.IsTrue(quantidadeLivrosNoRepositorio == quantidadeElementos);
        }

        [TestMethod]
        public void DeveApagarUmLivroDaLista()
        {
            //Arrange
            var repo = new RepositorioLivro();
            var livros = repo.ObterTodos();
            var livroAApagar = livros.FirstOrDefault();

            //action
            var livrosInicialmente = livros.Count;
            repo.Apagar(livroAApagar);
            var livrosDepoisDeApagar = livros.Count;

            //Assert
            Assert.IsTrue(livrosInicialmente > livrosDepoisDeApagar);
        }

        [TestMethod]
        [ExpectedException(typeof(AmazoniaException))]
        public void DeveGerarExceptionQuandoTentaApagarLivroInexistente()
        {
            //Arrange
            var repo = new RepositorioLivro();
            var livros = repo.ObterTodos();
            var livroInexistente = new LivroDigital();

            //action
            var livrosInicialmente = livros.Count;
            repo.Apagar(livroInexistente);
            var livrosDepoisDeApagar = livros.Count;

            //Assert
            Assert.IsTrue(livrosInicialmente > livrosDepoisDeApagar);
        }
    }
}
