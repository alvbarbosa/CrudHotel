using System.Collections.Generic;

namespace Hotel.Contratos
{
    public interface IManagementBase<TEntity>
    {
        bool Agregar(TEntity entity);

        bool Editar(TEntity entity);

        bool Eliminar(TEntity entity);

        void Guardar(TEntity entity);

        IEnumerable<TEntity> ObtenerPor();

        IEnumerable<TEntity> ObtenerTodos();
    }
}