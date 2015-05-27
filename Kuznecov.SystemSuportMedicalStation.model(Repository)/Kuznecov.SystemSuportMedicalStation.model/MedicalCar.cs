// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MedicalCar.cs" company="GRSU">
//   Project System Support Medical Station
// </copyright>
// <summary>
//   Defines the MedicalCar type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model
{
    using System.Collections.Generic;

    /// <summary>
    /// Class for describe medica car.
    /// </summary>
    public class MedicalCar : BaseModel
    {
        /// <summary>
        /// Gets or sets the model of medical car.
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the relaese date of medical car.
        /// </summary>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the vin number of medical car.
        /// </summary>
        public string Vin { get; set; }

        /// <summary>
        /// Gets or sets the doctors who drive the medical car.
        /// </summary>
        public virtual List<Doctor> Doctors { get; set; }

        /// <summary>
        /// Gets or sets the waybills.
        /// </summary>
        public virtual List<Waybill> Waybills { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCar"/> class.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <param name="date">
        /// The date.
        /// </param>
        /// <param name="vin">
        /// The vin.
        /// </param>
        /// <param name="doctors">
        /// The doctors.
        /// </param>
        public MedicalCar(string model, string date, string vin, List<Doctor> doctors)
        {
            this.Model = model;
            this.Date = date;
            this.Vin = vin;
            this.Doctors = doctors;
            this.Waybills = new List<Waybill>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCar"/> class.
        /// </summary>
        /// <param name="model">
        /// The model.
        /// </param>
        /// <param name="date">
        /// The date.
        /// </param>
        /// <param name="vin">
        /// The vin.
        /// </param>
        public MedicalCar(string model, string date, string vin)
        {
            this.Model = model;
            this.Vin = vin;
            this.Date = date;
            this.Waybills = new List<Waybill>();
            this.Doctors = new List<Doctor>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MedicalCar"/> class.
        /// </summary>
        public MedicalCar()
        {
        }
    }
}
