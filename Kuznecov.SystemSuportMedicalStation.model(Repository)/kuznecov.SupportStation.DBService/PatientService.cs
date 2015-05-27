using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kuznecov.SupportStation.DBService
{
    using kuznecov.SystemSuportMedicalStation.Data.Repository;

    class PatientService : IPatientService
    {
        private PatientRepository patientRepository;

        public PatientService(PatientRepository patientRepository)
        {
            
        }

        public void Create(PatientType patient)
        {
            throw new NotImplementedException();
        }

        public void Update(PatientType patient)
        {
            throw new NotImplementedException();
        }

        public void Delete(PatientType patient)
        {
            throw new NotImplementedException();
        }

        public PatientType Get(string name)
        {
            throw new NotImplementedException();
        }
    }
}
