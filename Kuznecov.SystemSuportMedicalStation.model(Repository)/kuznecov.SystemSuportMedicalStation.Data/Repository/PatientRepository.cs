// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PatientRepository.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the PatientRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.Data.Repository
{
    using kuznecov.SystemSuportMedicalStation.model;
    using kuznecov.SystemSuportMedicalStation.model.Repository;

    /// <summary>
    /// The patient repository.
    /// </summary>
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatientRepository"/> class.
        /// </summary>
        /// <param name="context">
        /// The context.
        /// </param>
        public PatientRepository(DataContext context)
            : base(context)
        {
        }
    }
}
