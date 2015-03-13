// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Call.cs" company="GRSU">
//   Project System Support Medical Station
// </copyright>
// <summary>
//   Defines the Call type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model
{
    using System.Collections.Generic;

    /// <summary>
    ///  Describe the call.
    /// </summary>
    public class Call
    {
        /// <summary>
        /// The id of call.
        /// </summary>
        private int id;

        /// <summary>
        /// The patient orr patient's who called.
        /// </summary>
        private List<Patient> patient;

        /// <summary>
        /// Gets or sets the id of call.
        /// </summary>
        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                this.id = value;
            }
        }

        /// <summary>
        /// Gets or sets the patient.
        /// </summary>
        public List<Patient> Patient
        {
            get
            {
                return this.Patient;
            }

            set
            {
                this.Patient = value;
            }
        }

    }
}
