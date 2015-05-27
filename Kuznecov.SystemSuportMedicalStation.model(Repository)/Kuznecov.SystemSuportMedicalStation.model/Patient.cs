// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Patient.cs" company="GRSU">
//   Project System Support Medical Station
// </copyright>
// <summary>
//   Defines the Patient type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSuportMedicalStation.model
{
    /// <summary>
    /// Describe the patient.
    /// </summary>
    public class Patient : BaseModel
    {
        /// <summary>
        /// Gets or sets the patient name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the patient surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the patient phone number.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the patient passport data.
        /// </summary>
        public string PassportData { get; set; }

        /// <summary>
        /// Gets or sets the patient doctor.
        /// </summary>
        public virtual Doctor Doctor { get; set; }

        /// <summary>
        /// Gets or sets the call.
        /// </summary>
        public virtual Call Call { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="surname">
        /// The surname.
        /// </param>
        /// <param name="passportdata">
        /// The passportdata.
        /// </param>
        /// <param name="phonenumber">
        /// The phonenumber.
        /// </param>
        /// <param name="doctor">
        /// The doctor.
        /// </param>
        public Patient(string name, string surname, string passportdata, string phonenumber, Doctor doctor)
        {
            this.Name = name;
            this.Surname = surname;
            this.PassportData = passportdata;
            this.PhoneNumber = phonenumber;
            this.Doctor = doctor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="surname">
        /// The surname.
        /// </param>
        /// <param name="passportdata">
        /// The passportdata.
        /// </param>
        /// <param name="phonenumber">
        /// The phonenumber.
        /// </param>
        public Patient(string name, string surname, string passportdata, string phonenumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.PassportData = passportdata;
            this.PhoneNumber = phonenumber;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        public Patient()
        {
        }
    }
}
