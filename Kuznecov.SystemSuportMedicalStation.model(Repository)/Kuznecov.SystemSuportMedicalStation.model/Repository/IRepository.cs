// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the IRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    /// <summary>
    /// The Repository interface.
    /// </summary>
    /// <typeparam name="TEntity">
    /// </typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Add(TEntity entity);

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        TEntity Get(int id);

        /// <summary>
        /// The update.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Update(TEntity entity);

        /// <summary>
        /// The delete.
        /// </summary>
        /// <param name="entity">
        /// The entity.
        /// </param>
        void Delete(TEntity entity);

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// The get all.
        /// </summary>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<TEntity> GetAll();

        /// <summary>
        /// The count.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        int Count(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// The save.
        /// </summary>
        void Save();
    }
}
