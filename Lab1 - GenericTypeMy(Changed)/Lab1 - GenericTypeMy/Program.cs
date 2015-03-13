// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="GRSU">
//   LAB 1
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Lab1___GenericTypeMy
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
               public static void Main(string[] args)
        {
            IDescriptor<Car> desk1 = new Descriptor1();
            IDescriptor<Hatchback> desk2 = new Description2();
            try
            {
                desk1 = (IDescriptor<Car>)desk2;
            }
            catch (Exception exception)
            {
                // throw new Exception("Exception");
                Console.WriteLine("Невозможное преобразование");
            }
            
            desk2 = desk1;

            IDescriptor1<Car> create1 = new Creating1();
            IDescriptor1<Hatchback> create2 = new Creating2();

            create1 = create2;
            
            try
            {
                create2 = (IDescriptor1<Hatchback>)create1;
            }
            catch (Exception exception)
            {
                 Console.WriteLine("Erorr");
            }
            
        }
    }
}
