using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        public void Insere(T entidade);
        public void Exclui(T entidade);
        public void Atualiza(int id, T entidade);
        public int ProximoId();


    }
}
