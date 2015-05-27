// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   The base repository.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;

    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The base repository.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>
        where TEntity : BaseModel
    {
        /// <summary>
        /// The data context.
        /// </summary>
        protected readonly DataContext DataContext;

        /// <summary>
        /// Gets the db set.
        /// </summary>
        protected DbSet<TEntity> DbSet
        {
            get { return this.DataContext.Set<TEntity>(); }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public BaseRepository(DataContext context)
        {
            this.DataContext = context;
        }

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        public virtual void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        public TEntity Get(int id)
        {
            return this.DbSet.Find(id);
        }

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        public virtual void Update(TEntity entity)
        {
            this.DbSet.Attach(entity);
            this.DataContext.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        public virtual void Delete(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            return this.DbSet.Where(filter).ToList();
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<TEntity> GetAll()
        {
            return this.DbSet.ToList();
        }

        /// <summary>
        /// The count.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Count(Expression<Func<TEntity, bool>> filter)
        {
            return this.DbSet.Count(filter);
        }

        /// <summary>
        /// The save.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        public void Save()
        {
            try
            {
                this.DataContext.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var builder = new StringBuilder();
                foreach (var errors in e.EntityValidationErrors)
                {
                    builder.Append(
                        string.Format(
                            "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            errors.Entry.Entity.GetType().Name,
                            errors.Entry.State) + Environment.NewLine);
                    foreach (var dbValidationError in errors.ValidationErrors)
                    {
                        builder.Append(
                            string.Format(
                                "- Property: \"{0}\", Error: \"{1}\"",
                                dbValidationError.PropertyName,
                                dbValidationError.ErrorMessage));
                    }
                }
                throw new Exception(builder.ToString(), e);
            }
        }
    }
}
