using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Lab_2
{
    [AlternateName(Name = "SC")]
    public class Scooter : Bicycle, IHaveEngine
    {
        /// <summary>
        /// The cylinder count.
        /// </summary>
        private readonly int cylinderCount;

        public Scooter(int cylinderCount)
        {
            this.cylinderCount = cylinderCount;
        }

        public int LightCount { get; set; }

        public int GetCylindersCount()
        {
            return cylinderCount;
        }
    }
}
