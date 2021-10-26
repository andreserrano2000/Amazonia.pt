namespace Amazonia.DAL.Entidades
{
    public abstract class Livro : Entidade
    {
        protected decimal Preco { get; set; }
        public string Descricao { get; set; }
        public string Autor { get; set; }
        private Idioma Idioma { get; set; }   //Portugues, Espanhol, Ingles

        public virtual decimal ObterPreco(){
            return Preco;
        }
    }
}

