using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestForLab2
{
    using System.Collections.Generic;
    using System.Linq;

    using Lab_2;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var myobj = new List<object>();
            myobj.Add(new Car(4));
            myobj.Add(new Scooter(2));
            myobj.Add(new MountainBike());

            foreach (var value in myobj)
            {
                object[] attribs = value.GetType().GetCustomAttributes(typeof(AlternateName), false);
                if (attribs.Count() != 0)
                {
                    AlternateName alt = (AlternateName)attribs[0];
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
    }
}
