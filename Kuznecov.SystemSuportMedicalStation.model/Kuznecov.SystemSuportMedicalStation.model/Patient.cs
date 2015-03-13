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
    public class Patient
    {
        /// <summary>
        /// The patient name.
        /// </summary>
        private string name;

        /// <summary>
        /// The patient surname.
        /// </summary>
        private string surname;

        /// <summary>
        /// The patient phone number.
        /// </summary>
        private string phoneNumber;

        /// <summary>
        /// The patient passport data.
        /// </summary>
        private string passportData;

        /// <summary>
        /// The patient doctor .
        /// </summary>
        private Doctor doctor;

        /// <summary>
        /// Gets or sets the patient name.
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
        /// Gets or sets the patient surname.
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
        /// Gets or sets the patient phone number.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        /// <summary>
        /// Gets or sets the patient passport data.
        /// </summary>
        public string PassportData
        {
            get
            {
                return this.passportData;
            }
            set
            {
                this.passportData = value;
            }
        }

        /// <summary>
        /// Gets or sets the patient doctor.
        /// </summary>
        public Doctor Doctor
        {
            get
            {
                return this.doctor;
            }
            set
            {
                this.doctor = value;
            }
        }
    }
}
