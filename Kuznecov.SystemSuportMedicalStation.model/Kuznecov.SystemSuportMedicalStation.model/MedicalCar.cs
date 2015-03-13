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
    public class MedicalCar
    {
        /// <summary>
        /// The model of medical car.
        /// </summary>
        private string model;

        /// <summary>
        /// Release date of medical car.
        /// </summary>
        private string date;

        /// <summary>
        /// The vin number of medical car.
        /// </summary>
        private string vin;

        /// <summary>
        /// List doctors who drive the medical car.
        /// </summary>
        private List<Doctor> doctors;

        /// <summary>
        /// Gets or sets the model of medical car.
        /// </summary>
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        /// <summary>
        /// Gets or sets the relaese date of medical car.
        /// </summary>
        public string Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }

        /// <summary>
        /// Gets or sets the vin number of medical car.
        /// </summary>
        public string Vin
        {
            get
            {
                return this.vin;
            }
            set
            {
                this.vin = value;
            }
        }

        /// <summary>
        /// Gets or sets the doctors who drive the medical car.
        /// </summary>
        public List<Doctor> Doctors
        {
            get
            {
                return this.doctors;
            }
            set
            {
                this.doctors = value;
            }
        }
    }
}
