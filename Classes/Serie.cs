using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos

        private Genero Genero {get; set;}
        private string Titulo {get; set;}
        private string Descricao {get; set;}
        private int Ano {get; set;}
        private string Elenco {get; set;}
        private string Produtora {get; set;}
        private Plataformas Plataformas {get; set;}
        private bool Excluido {get; set;}
        //Metodos

        public Serie (int id, Genero genero, string titulo, string descricao, int ano, string elenco, string produtora, Plataformas plataformas)
        {
        this.Id = id;
        this.Genero = genero;
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Ano = ano;
        this.Elenco = elenco;
        this.Produtora = produtora;
        this.Plataformas = plataformas;
        this.Excluido = false;

       }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Título: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano;
            retorno += "Elenco: " + this.Elenco + Environment.NewLine;
            retorno += "Produtora: " + this.Produtora + Environment.NewLine;
            retorno += "Plataformas: " + this.Plataformas + Environment.NewLine;
            retorno += "Excluído: " + this.Excluido;
            return retorno;
        }

        public string retornaTitulo()
        {
            return this.Titulo;
        }

        internal int retornaId()
        {
            return this.Id;
        }

        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir(){
            this.Excluido = true;
        }

    }
}