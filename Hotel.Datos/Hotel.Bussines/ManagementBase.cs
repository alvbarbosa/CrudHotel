using Hotel.Contratos;
using Hotel.Dependencies;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Bussines
{
    public abstract class ManagementBase<TRepository, TEntity> : IManagementBase<TEntity> where TRepository : IGenericRepository<TEntity>
    {
        private TRepository repository;

        protected ManagementBase(TRepository repository)
        {
            this.repository = repository;
        }

        protected ManagementBase(): this(Container.Resolver<TRepository>())
        {
        }

        public virtual IEnumerable<TEntity> ObtenerTodos()
        {
            return this.repository.ObtenerTodos();
        }

        public abstract IEnumerable<TEntity> ObtenerPor();

        public virtual bool Agregar(TEntity entity)
        {
            return this.repository.Agregar(entity);
        }

        public virtual bool Editar(TEntity entity)
        {
            return this.repository.Editar(entity);
        }

        public virtual bool Eliminar(TEntity entity)
        {
            return this.repository.Eliminar(entity);
        }

        public virtual void Guardar(TEntity entity)
        {
            this.repository.Guardar();
        }
    }
}
