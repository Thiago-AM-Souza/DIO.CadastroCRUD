using System.Collections.Generic;
using DIO.Cadastro.Interfaces;

namespace DIO.Cadastro.Interfaces{
    public class PessoaRepositorio : RepositorioBase<Pessoa>
    {
        private List<Pessoa> listPessoa = new List<Pessoa>();

        public void Atualiza(int id, Pessoa pessoa)
        {
            listPessoa[id] = pessoa;
        }

        public void Exclui(int id)
        {
            listPessoa[id].Exclui();
        }

        public void Insere(Pessoa pessoa)
        {
            listPessoa.Add(pessoa);
        }

        public List<Pessoa> Lista()
        {
            return listPessoa;
        }

        public int ProximoId()
        {
            return listPessoa.Count;
        }

        public Pessoa RetornaPorId(int id)
        {
            return listPessoa[id];
        }
    }
}
