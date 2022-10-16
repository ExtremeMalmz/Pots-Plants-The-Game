using Plant_Space;
using Pot_Space;

namespace Arduino_Space
{
    class Arduino
    {
        /// <summary>
        /// An Arduino is a single board microcontroller, we try to replicate some aspects of it in this class
        /// </summary>
        private bool isLightOn;
        public Arduino()
        {
            /// <summary>
            /// Constructor for the Arduino Class
            /// </summary>
            
            //isLightOn is the "light" on the arduino which goes off when an upgrade is needed, default is set to off so its set to false
            isLightOn = false;
        }

        public bool shouldLightBeOn(Plant plant, Pot pot)
        {
            /// <summary>
            /// shouldLightBeOn is a true or false based on if the plant weight exceeds the pot weight
            /// </summary>
            
            int plantWeight = plant.Get_plantWeight();
            int potMaxWeight = pot.Get_weightCapacity();

            if(plantWeight >= potMaxWeight)
            {
                isLightOn = true;
                return isLightOn;
            }
            isLightOn = false;
            return isLightOn;
        }

        public bool Get_isLightOn()
        {
            /// <summary>
            /// Getter for boolean isLightOn
            /// </summary>
            return isLightOn;
        }

        public bool IsPlantWeightGreaterThanPotWeight(Plant plant, Pot pot)
        {
            /// <summary>
            /// Returns true or false based on if the plant weight is greater than the pot weight
            /// I do realize I wrote the same method twice.
            /// </summary>
            
            if (plant.Get_plantWeight() > pot.Get_weightCapacity())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}