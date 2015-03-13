// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest1.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the UnitTest1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericTypeTest
{
    using Lab1___GenericTypeMy;

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
            IDescriptor<Car> desk1 = new Descriptor1();
            IDescriptor<Hatchback> desk2 = new Description2();

            // desk1 = desk2;
            desk2 = desk1;
        }
    }
}
