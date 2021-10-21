namespace Amazonia.DAL
{
    public class LivroImpresso : Livro
    {
        public int QuantidadePaginas { get; set; }
        public Dimensoes Dimensoes { get; set; }
    }
}
