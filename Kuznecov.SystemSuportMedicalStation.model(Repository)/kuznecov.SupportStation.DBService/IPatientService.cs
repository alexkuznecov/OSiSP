using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuznecov.SupportStation.DBService
{
    using System.Runtime.Serialization;
    using System.ServiceModel;

    using kuznecov.SystemSuportMedicalStation.model;

    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        void Create(PatientType patient);

        [OperationContract]
        void Update(PatientType patient);

        [OperationContract]
        void Delete(PatientType patient);

        [OperationContract]
        PatientType Get(string name);
    }

    [DataContract]
    public class PatientType
    {
        //private string name;

        private string surname;

        private string telephoneNumber;

        private string passportData;

        private Doctor doctor;

        private Call call;

        [DataMember]
        public string Name
        {
            get; set; }

        [DataMember]
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

        [DataMember]
        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }

            set
            {
                this.telephoneNumber = value;
            }
        }

        [DataMember]
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

        [DataMember]
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

        [DataMember]
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
        
    }
}
