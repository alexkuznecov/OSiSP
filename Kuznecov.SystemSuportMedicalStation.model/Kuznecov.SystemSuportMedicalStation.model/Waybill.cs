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
    /// <summary>
    /// Describe the waybill.
    /// </summary>
    public class Waybill
    {
        /// <summary>
        /// The id of waybill.
        /// </summary>
        private int id;

        /// <summary>
        /// The call who initialize waybill.
        /// </summary>
        private Call call;

        /// <summary>
        /// The car fixed in waybill.
        /// </summary>
        private MedicalCar car;

        /// <summary>
        /// Gets or sets the id of waybill.
        /// </summary>
        public int Id
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
        /// Gets or sets the call of waybill.
        /// </summary>
        public Call Call
        {
            get
            {
                return this.call;
            }
            set
            {
                this.call = value;
            }
        }

        /// <summary>
        /// Gets or sets the car of waybill.
        /// </summary>
        public MedicalCar Car
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
