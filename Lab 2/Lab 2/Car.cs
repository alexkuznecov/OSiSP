using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2
{
    [AlternateName(Name = "CA")]
    public class Car : IHaveEngine
    {
        private readonly int cylinderCount;

        public Car(int cylinderCount)
        {
            this.cylinderCount = cylinderCount;
        }

        public int GetCylindersCount()
        {
            return this.cylinderCount;
        }
    }
}
