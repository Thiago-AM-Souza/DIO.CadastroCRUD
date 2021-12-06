using System.Collections.Generic;

namespace DIO.Cadastro.Interfaces
{
    public interface RepositorioBase<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T pessoa);
        void Exclui(int id);
        void Atualiza(int id, T pessoa);
        int ProximoId();
    }
}