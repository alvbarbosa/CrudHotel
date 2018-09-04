using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Hotel.Contratos
{
    public interface IGenericRepository<TEntity>
    {
        IEnumerable<TEntity> ObtenerTodos();

        IEnumerable<TEntity> ObtenerPor(Expression<Func<TEntity, bool>> predicado);

        bool Agregar(TEntity entity);

        bool Editar(TEntity entity);

        bool Eliminar(TEntity entity);

        void Guardar();
    }
}
