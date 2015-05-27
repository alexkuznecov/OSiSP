// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DatabaseOperationTest.cs" company="GRSU">
//   System Support Medical Station
// </copyright>
// <summary>
//   Defines the DatabaseOperationTest type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace kuznecov.SystemSupportMedicalStation.Test
{
    using System;
    using System.Linq;

    using kuznecov.SystemSuportMedicalStation.Data;
    using kuznecov.SystemSuportMedicalStation.Data.Repository;
    using kuznecov.SystemSuportMedicalStation.model;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The database operation test.
    /// </summary>
    [TestClass]
    public class DatabaseOperationTest
    {
        /// <summary>
        /// The create add.
        /// </summary>
        [TestMethod]
        public void CreateAdd()
        {
            var patient = new Patient("Ivan", "Ivanov", "KI55000", "+375152996");
            var patient1 = new Patient("Petr", "Sergeev", "KH1234311", "+375291545");

            var doctor = new Doctor("Platon", "Sidorov", "Therapist");

            var car = new MedicalCar("Mercedes Benz Sprinter 412", "12.05.2009", "VBGTF48483D6");

            var call = new Call(new DateTime(2015, 3, 15));
            var call1 = new Call(new DateTime(2015, 3, 16));

            var waybill = new Waybill(new DateTime(2015, 3, 16));

            doctor.Patients.Add(patient);
            doctor.Patients.Add(patient1);
            doctor.Car.Add(car);

            car.Doctors.Add(doctor);
            car.Waybills.Add(waybill);

            call.Patient.Add(patient);
            call.Waybill = waybill;

            call1.Patient.Add(patient1);
            call1.Waybill = waybill;

            waybill.Car = car;
            waybill.Calls.Add(call);
            waybill.Calls.Add(call1);

            patient.Call = call;
            patient.Doctor = doctor;

            patient1.Call = call1;
            patient1.Doctor = doctor;

            using (var context = new DataContext())
            {
                context.Database.CreateIfNotExists();

                // context.Database.Delete();
                BaseRepository<Call> calls = new CallRepository(context);
                BaseRepository<Doctor> doctors = new DoctorRepository(context);
                BaseRepository<MedicalCar> medicalCars = new MedicalCarRepository(context);
                BaseRepository<Patient> patients = new PatientRepository(context);
                BaseRepository<Waybill> waybills = new WaybillRepository(context);

                patients.Add(patient1);
                patients.Save();
            }
        }

        /// <summary>
        /// The delete test.
        /// </summary>
        [TestMethod]
        public void DeleteTest()
        {
            int countBeforeDeleting;
            int countAfterDeleting;
            using (var context = new DataContext())
            {
                BaseRepository<Patient> patients = new PatientRepository(context);
                countBeforeDeleting = patients.GetAll().Count();

                var patient = patients.Get(2);
                patients.Delete(patient);
                patients.Save();

                countAfterDeleting = patients.GetAll().Count();
            }
            Assert.AreEqual(countBeforeDeleting - 1, countAfterDeleting);
        }

        /// <summary>
        /// The update test.
        /// </summary>
        [TestMethod]
        public void UpdateTest()
        {
            int updatedEntityCount;

            using (var context = new DataContext())
            {
                BaseRepository<MedicalCar> medicalCars = new MedicalCarRepository(context);
                var meddicCar = medicalCars.Get(m => m.Model == "Mercedes Benz Sprinter 412").FirstOrDefault();
                meddicCar.Model = "Mercedes Benz Sprinter 312";
                medicalCars.Update(meddicCar);
                medicalCars.Save();

                updatedEntityCount = medicalCars.Get(m => m.Model == "Mercedes Benz Sprinter 312").Count();
            }

            Assert.AreEqual(1, updatedEntityCount);
        }

        /// <summary>
        /// The count test.
        /// </summary>
        [TestMethod]
        public void CountTest()
        {
            int count;

            using (var context = new DataContext())
            {
                BaseRepository<Doctor> doctors = new DoctorRepository(context);
                var doc = new Doctor("Ivan", "Ivanov", "Surgeon");
                doctors.Add(doc);
                doctors.Save();
                
                count = doctors.Count(d => d.Name == "Ivan");
            }

            Assert.AreEqual(1, count);
        }
    }
}
