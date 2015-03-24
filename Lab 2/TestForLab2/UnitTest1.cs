// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="GRSU">
//   LAB 2
// </copyright>
// <summary>
//   Defines the UnitTest1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TestForLab2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Lab_2;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            var myobj = new List<object> { new Car(4), new Scooter(2), new MountainBike() };
            foreach (var value in myobj)
            {
                var attribs = value.GetType().GetCustomAttributes(typeof(AlternateName), false);
                if (attribs.Count() != 0)
                {
                    var alt = (AlternateName)attribs[0];
                    if (alt.Name == "CA")
                    {
                        Console.WriteLine("Car");
                    }
                    else
                    {
                        if (alt.Name == "SC")
                        {
                            Console.WriteLine("Scooter");
                        }
                        else
                        {
                            if (alt.Name == "MB")
                            {
                                Console.WriteLine("MountainBike");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// The test method 2.
        /// </summary>
        [TestMethod]
        public void TestMethod2()
        {
            var count = 0;
            
            var myobj = new List<object>();
            myobj.Add(new Car(4));
            myobj.Add(new Scooter(2));
            myobj.Add(new MountainBike());
            
           foreach (var value in myobj)
           {
               if (value.GetType().GetInterface("IHaveEngine") == typeof(IHaveEngine))
               {
                   count++;
                   var attribs = value.GetType().GetCustomAttributes(typeof(AlternateName), false);
                   var alt = (AlternateName)attribs[0];

                   if (alt.Name == "CA")
                   {
                       var car = new Car(4);
                       int val = car.GetCylindersCount();
                       Console.WriteLine(val);
                   }
                   else
                   {
                       if (alt.Name == "SC")
                       {
                           var scooter = new Scooter(2);
                           int val = scooter.GetCylindersCount();
                           Console.WriteLine(val);
                       }
                   }

               }
           }

            Assert.AreEqual(count, 2);
        }

        /// <summary>
        /// The test method 3.
        /// </summary>
        [TestMethod]
        public void TestMethod3()
        {
            var count = 0;

            var myobj = new List<object>();
            myobj.Add(new Car(4));
            myobj.Add(new Scooter(2));
            myobj.Add(new MountainBike());

            foreach (var value in myobj)
            {
                if (value.GetType().BaseType == typeof(Bicycle))
                {
                    count++;
                    var attribs = value.GetType().GetCustomAttributes(typeof(AlternateName), false);
                    var alt = (AlternateName)attribs[0];

                    if (alt.Name == "SC")
                    {
                        var scooter = new Scooter(2);
                        int val = scooter.GetCylindersCount();
                        Console.WriteLine(val);
                    }
                    else
                    {
                        if (alt.Name == "MB")
                        {
                            var mountBike = new MountainBike();
                            mountBike.ShockAbsorberCount = 3;
                            Console.WriteLine(mountBike.ShockAbsorberCount);
                        }
                    }

                }
            }
            Assert.AreEqual(count, 2);
        }
    }
}
