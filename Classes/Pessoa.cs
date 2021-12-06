using System;

namespace DIO.Cadastro
{
    public class Pessoa : EntidadeBase
    {
        private string Nome;
        private int AnoNasc;
        private Sexo Sexo;
        private string Endereco;
        private bool Excluido;
        private string Cadastro;

        public Pessoa(int Id, string Nome, int AnoNasc, Sexo Sexo, string Endereco, string Cadastro)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.AnoNasc = AnoNasc;
            this.Sexo = Sexo;
            this.Endereco = Endereco;
            this.Cadastro = Cadastro;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Idade: " + (DateTime.Today.Year - this.AnoNasc) + " (" + retornaMaioridade() + ")" + Environment.NewLine;
            retorno += "Sexo: " + this.Sexo + Environment.NewLine;
            retorno += "Endereço: " + this.Endereco + Environment.NewLine;
            retorno += "Data do cadastro: " + this.Cadastro;
            return retorno;
        }

        public int retornaId()
        {
            return this.Id;
        }
        public string retornaNome()
        {
            return this.Nome;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Exclui()
        {
            this.Excluido = true;
        }
        public int retornaNascimento()
        {
            return this.AnoNasc;
        }
        public string retornaMaioridade()
        {  
            int idade = DateTime.Today.Year - this.AnoNasc;
            if (idade < 18)
            {
                return "Menor de idade";
            }
            else
            {
                return "Maior de idade";
            }
        }
        
    }
    

}
