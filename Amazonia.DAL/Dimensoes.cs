namespace Amazonia.DAL
{
    public class Dimensoes
    {
        ///Largura em Centimetros
        public float Largura { get; set; }
        ///Altura em Centimetros
        public float Altura { get; set; }
        ///Profundide em Centimetros
        public float Profundidade { get; set; }
        ///Peso em gramas
        public float Peso { get; set; }

        public float Volume => Largura * Altura * Profundidade;

        public float ObterVolume()
        {
            return Largura * Altura * Profundidade;
        }
    }
}