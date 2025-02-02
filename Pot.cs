namespace Pot_Space
{
    class Pot
    {
        /// <summary>
        /// Class Pot is meant to be a digital recreation of a flower pot. 
        /// </summary>
        private int weightCapacity;
        private bool isUpgradedPot;

        public Pot()
        {
            /// <summary>
            ///  Constructor for the Pot. Default weight is set to 15
            /// </summary>
            //default weight capacity
            weightCapacity = 15;
            isUpgradedPot = false;
        }

        public void UpgradePotWeightCapacity()
        {
            /// <summary>
            ///  Upgrades the weight capacity of the Pot by 15 points
            /// </summary>
            weightCapacity += 15;
            isUpgradedPot = true;
        }

        public bool Get_isUpgradedPot()
        {
            /// <summary>
            /// Getter for the boolean attribute isUpgradedPot, if the pot is upgraded it returns true
            /// </summary>
            return isUpgradedPot;
        }

        public void ResetPot()
        {
            /// <summary>
            /// Resets all values to default, neccessary for repeating the program
            /// </summary>
            weightCapacity = 15;
            isUpgradedPot = false;
        }

        public int Get_weightCapacity()
        {
            /// <summary>
            /// Getter for the integer attribute weightCapacity, returns the weight of the pot (which for now always starts 15)
            /// </summary>
            return weightCapacity;
        }

        
    }
}