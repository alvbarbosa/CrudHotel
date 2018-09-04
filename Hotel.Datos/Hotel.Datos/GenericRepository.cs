using Hotel.Contratos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Datos
{
    public abstract class GenericRepository<TContext, TEntity> : IGenericRepository<TEntity>
        where TContext : DbContext, new() where TEntity : class
    {
        private TContext contexto = new TContext();

        protected GenericRepository()
        {
            this.contexto.Configuration.ProxyCreationEnabled = false;
        }

        public TContext Contexto    
        {
            get { return contexto; }
            set { contexto = value; }
        }


        public virtual bool Agregar(TEntity entity)
        {
            try
            {
                this.contexto.Set<TEntity>().Add(entity);
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public virtual bool Editar(TEntity entity)
        {
            try
            {
                this.contexto.Entry<TEntity>(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public virtual bool Eliminar(TEntity entity)
        {
            try
            {
                this.contexto.Set<TEntity>().Remove(entity);
                return true;
            }
            catch 
            {

                return false;
            }
        }

        public virtual void Guardar()
        {
            this.contexto.SaveChanges();
        }

        public virtual IEnumerable<TEntity> ObtenerPor(Expression<Func<TEntity, bool>> predicado)
        {
            return this.contexto.Set<TEntity>().Where(predicado);
        }

        public virtual IEnumerable<TEntity> ObtenerTodos()
        {
            return this.contexto.Set<TEntity>();
        }
    }
}
