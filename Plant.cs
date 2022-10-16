using System;

namespace Plant_Space
{
    class Plant
    {
        private string name;
        private int daysAlive;
        private int daysSinceWatered;
        private bool isAlive;
        private int plantWeight;
        private int maxGrowthInDay;
        private int maxDaysWithoutWater;
        
        public Plant(int maxGrowthInDay, int maxDaysWithoutWater, string name)
        {
            /// <summary>
            ///  Constructor Method for Plant class. 
            ///  daysAlive is how many days the plant has lived, daysSinceWatered is how many days have gone by without water (this is set to a default of 0), and isAlive is a boolean set to true as a default value meaning the plant is alive
            ///  upperWeightRange is a parameter, its how much the plant can maximum grow in a day
            ///  name is the name of the plant, useful for when putting pictures onto the screen
            /// </summary>
            
            this.daysAlive = 0;
            this.daysSinceWatered = 0;
            this.isAlive = true;
            this.plantWeight = 0;
            this.maxGrowthInDay = maxGrowthInDay;
            this.maxDaysWithoutWater = maxDaysWithoutWater;
            this.name = name;
        }

        public void NextDay()
        {
            //check if the plants dead
            CheckIfDead();

            //if its alive do all these methods
            if(isAlive == true)
            {
                Set_daysAlive();
                Set_daysSinceWatered();
                GrowForADay();
            }
        }

        private void GrowForADay()
        {
            /// <summary>
            /// The plant grows a certain amount for the day. Based between 0 and the maxGrowthInDay variable
            /// </summary>
            plantWeight += new Random().Next(0, maxGrowthInDay);
        }

        private void CheckIfDead()
        {
            /// <summary>
            /// Checks if the plant has been properly watered, sets it the isAlive bool to false if true
            /// </summary>
           
            //if plant hasnt been watered in an amount of days
            if (daysSinceWatered >= maxDaysWithoutWater)
            {
                isAlive = false;
            }
        }

        public void WaterPlant()
        {
            /// <summary>
            /// Waters the plant, resets the days since watering to zero
            /// </summary>
            daysSinceWatered = 0;
        }
        
        public string Get_name()
        {
            /// <summary>
            /// Getter for the string name (plants name)
            /// </summary>
            return name;
        }

        public int Get_daysAlive()
        {
            /// <summary>
            /// Getter for the integer daysAlive (days the plant has been alive)
            /// </summary>
            return daysAlive;
        }

        public void Set_daysAlive()
        {
            /// <summary>
            /// Setter for the daysAlive. Always increments by 1
            /// </summary>
            this.daysAlive++;
        }

        public int Get_daysSinceWatered()
        {
            /// <summary>
            /// Getter for integer daysSinceWatered. The days since the plant has been watered
            /// </summary>
            return daysSinceWatered;   
        }

        public void Set_daysSinceWatered()
        {
            /// <summary>
            /// Setter for the daysSinceWatered. Since the game always progresses by 1 day only a maximum of 1 is added (per click/day)
            /// </summary>
            daysSinceWatered++;
        }

        public bool Get_isAlive()
        {
            /// <summary>
            /// Getter for the boolean isAlive, double checks if the plant is alive before returning
            /// </summary>
            CheckIfDead();
            return isAlive;
        }

        public int Get_plantWeight()
        {
            /// <summary>
            /// Getter for the integer plantWeight
            /// </summary>
            return plantWeight; 
        }
    }
}