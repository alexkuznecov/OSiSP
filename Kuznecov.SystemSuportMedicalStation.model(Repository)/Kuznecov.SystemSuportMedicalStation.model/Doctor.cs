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
    public class Doctor : BaseModel
    {
        /// <summary>
        /// Gets or sets the doctor's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the doctor's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the doctor's position.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Gets or sets the patients.
        /// </summary>
        public virtual List<Patient> Patients { get; set; }

        /// <summary>
        /// Gets or sets the car which fixed the doctor.
        /// </summary>
        public virtual List<MedicalCar> Car { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="surname">
        /// The surname.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        /// <param name="patients">
        /// The patients.
        /// </param>
        public Doctor(string name, string surname, string position, List<Patient> patients)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this.Patients = patients;
            this.Car = new List<MedicalCar>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="surname">
        /// The surname.
        /// </param>
        /// <param name="position">
        /// The position.
        /// </param>
        public Doctor(string name, string surname, string position)
        {
            this.Name = name;
            this.Surname = surname;
            this.Position = position;
            this.Patients = new List<Patient>();
            this.Car = new List<MedicalCar>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Doctor"/> class.
        /// </summary>
        public Doctor()
        {
        }
    }
}
