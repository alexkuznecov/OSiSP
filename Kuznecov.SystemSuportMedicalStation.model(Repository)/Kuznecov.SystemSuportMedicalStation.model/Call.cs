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
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///  Describe the call.
    /// </summary>
    public class Call : BaseModel
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the patient.
        /// </summary>
        public virtual List<Patient> Patient { get; set; }

        /// <summary>
        /// Gets or sets the waybill.
        /// </summary>
        public virtual Waybill Waybill { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call"/> class.
        /// </summary>
        /// <param name="patients">
        /// The patients.
        /// </param>
        public Call(List<Patient> patients)
        {
            this.Patient = patients;
        }

        public Call(DateTime date)
        {
            this.Date = date;
            this.Patient = new List<Patient>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Call"/> class.
        /// </summary>
        public Call()
        {
            
        }
    }
}
