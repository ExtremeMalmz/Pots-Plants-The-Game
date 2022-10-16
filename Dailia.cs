using Plant_Space;

namespace Dalia_Space
{
    class Dalia : Plant
    {
        private const int maxGrowthInDay = 3;
        private const int maxDaysWithoutWater = 3;
        private const string name = "Dalia";
        public Dalia() : base(maxGrowthInDay, maxDaysWithoutWater, name)
        {
            /// <summary>
            /// Constructor for Class Dalia (misspelled dahlia)
            /// </summary>
        }

        public void PrintStuff()
        {
            /// Debug stuff
            Console.WriteLine(Get_daysAlive());
        }
    }
}