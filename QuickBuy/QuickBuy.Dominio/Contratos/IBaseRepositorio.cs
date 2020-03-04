using System;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity FindById(int id);
        IEnumerable<TEntity> FindAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
