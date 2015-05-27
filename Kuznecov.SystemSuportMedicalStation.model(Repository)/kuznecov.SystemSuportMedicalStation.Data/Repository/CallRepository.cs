// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CallRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the CallRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The call repository.
    /// </summary>
    public class CallRepository : BaseRepository<Call>, ICallRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public CallRepository(DataContext context)
            : base(context)
        {
        }
    }
}
