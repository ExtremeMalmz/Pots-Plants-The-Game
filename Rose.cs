//Plant_Space is the namespace of the Plant class, "using Plant_Space" gives us access to it
using Plant_Space;
using System.Xml.Linq;

namespace Rose_Space
{
    class Rose : Plant
    {
        /// <summary>
        /// Class Rose is an inheritance from Plant. Its a digital recreation of the flower
        /// </summary>
        private const int maxGrowthInDay = 3;
        private const int maxDaysWithoutWater = 7;
        private const string name = "Rose";
        public Rose() : base(maxGrowthInDay, maxDaysWithoutWater, name)
        {
            /// <summary>
            /// Constructor for the Rose class. Note the ": base(x), its the superconstructor for the Plant class
            /// </summary>
        }

        public void PrintStuff()
        {
            //this is just a debug method
            Console.WriteLine(Get_daysAlive());
        }
    }
}