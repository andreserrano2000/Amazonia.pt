using System;

namespace Amazonia.DAL.Entidades
{
    public class Cliente : Entidade
    {
        public Morada Morada { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade => DateTime.Now.Year - DataNascimento.Year;


        //
        public override string ToString()
        {
            return $"Nome: {Nome} => Idade: {Idade} => Identificador: {Identificador}";
        }
    }
}