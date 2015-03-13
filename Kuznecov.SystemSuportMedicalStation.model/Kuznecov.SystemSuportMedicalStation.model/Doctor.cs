// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Doctor.cs" company="GRSU">
//   Project System Support Medical Station
// </copyright>
// <summary>
//   Defines the Doctor type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model
{
    using System.Collections.Generic;

    /// <summary>
    /// Describe the doctor who works in station.
    /// </summary>
    public class Doctor
    {
        /// <summary>
        /// The doctor name.
        /// </summary>
        private string name;

        /// <summary>
        /// The doctor surname.
        /// </summary>
        private string surname;

        /// <summary>
        /// The doctor position of station.
        /// </summary>
        private string position;

        /// <summary>
        /// The patients who fixed with doctor.
        /// </summary>
        private List<Patient> patients;

        /// <summary>
        /// The car which fixed in doctor.
        /// </summary>
        private List<MedicalCar> car;

        /// <summary>
        /// Gets or sets the doctor's surname.
        /// </summary>
        public string Surname
        {
            get
            {
                return this.surname;
            }

            set
            {
                this.surname = value;
            }
        }

        /// <summary>
        /// Gets or sets the doctor's position.
        /// </summary>
        public string Position
        {
            get
            {
                return this.position;
            }

            set
            {
                this.position = value;
            }
        }

        /// <summary>
        /// Gets or sets the patients.
        /// </summary>
        public List<Patient> Patients
        {
            get
            {
                return this.patients;
            }
            set
            {
                this.patients = value;
            }
        }

        /// <summary>
        /// Gets or sets the doctor's name.
        /// </summary>
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        /// <summary>
        /// Gets or sets the car which fixed the doctor.
        /// </summary>
        public List<MedicalCar> Car
        {
            get
            {
                return this.car;
            }
            set
            {
                this.car = value;
            }
        }
    }
}
