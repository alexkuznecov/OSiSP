// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Waybill.cs" company="GRSU">
//   Project System Support Medical Station
// </copyright>
// <summary>
//   Defines the Waybill type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Describe the waybill.
    /// </summary>
    public class Waybill : BaseModel
    {
        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        public DateTime Date { get; set; }
        
        /// <summary>
        /// Gets or sets the call of waybill.
        /// </summary>
        public virtual List<Call> Calls { get; set; }

        /// <summary>
        /// Gets or sets the car of waybill.
        /// </summary>
        public virtual MedicalCar Car { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Waybill"/> class.
        /// </summary>
        /// <param name="call">
        /// The call.
        /// </param>
        /// <param name="medicalCar">
        /// The medical car.
        /// </param>
        public Waybill(List<Call> calls, MedicalCar medicalCar)
        {
            this.Calls = calls;
            this.Car = medicalCar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Waybill"/> class.
        /// </summary>
        /// <param name="date">
        /// The date.
        /// </param>
        public Waybill(DateTime date)
        {
            this.Date = date;
            this.Calls = new List<Call>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Waybill"/> class.
        /// </summary>
        public Waybill()
        {
        }
    }
}
