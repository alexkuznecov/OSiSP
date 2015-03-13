// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UnitTest2.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the UnitTest2 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GenericTypeTest
{
    using Lab1___GenericTypeMy;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The unit test 2.
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        /// <summary>
        /// The test method 1.
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            IDescriptor1<Car> create1 = new Creating1();
            IDescriptor1<Hatchback> create2 = new Creating2();

            create1 = create2;

            // create2 = create1;
        }
    }
}
