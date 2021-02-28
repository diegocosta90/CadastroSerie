using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries
{
    public class Serie : EntidadeBase //os dois pontos quer dizer que a classe série está herdando da entidade base
    {
        private Genero Genero { get; set; }
        private string Titulo { get; set; }

        private string Descricao { get; set; }

        private int Ano { get; set; }

        public bool Excluido { get; set; }

        //métodos
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            Id = Id;
            Genero = genero;
            Titulo = titulo;
            Descricao = descricao;
            Ano = ano;
            Excluido = false;
        }

        //ToString
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero" + Genero + Environment.NewLine;
            retorno += "Título" + Titulo + Environment.NewLine;
            retorno += "Descrição" + Descricao + Environment.NewLine;
            retorno += "Ano de início" + Ano + Environment.NewLine;
            retorno += "Excluído" + Excluido;

            return retorno;
        }

        public string retornaTitulo()
        {
            return Titulo;
        }
        public int retornaId()
        {
            return Id;
        }
        public bool retornaExcluido()
        {
            return Excluido;
        }

        public void Exclui()
        {
            Excluido = true;
        }








    }
}
