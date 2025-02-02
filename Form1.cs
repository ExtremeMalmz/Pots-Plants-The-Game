using Rose_Space;
using Dalia_Space;
using Arduino_Space;
using Pot_Space;

using System.Runtime.Intrinsics.X86;
using System.Windows.Forms;
using Plant_Space;

namespace Pot_Plant_the_Game
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Partial class form is the GUI for our program
        /// </summary>
        private Plant? plant = null;
        private Arduino? arduino = new Arduino();
        private Pot? pot = new Pot();
        public Form1()
        {
            /// <summary>
            ///  Constructor for the Visual Form. InitializeComponent() initializes form components while InitializeGUI() is to initialize the values of the GUI
            /// </summary>
            InitializeComponent();
            InitializeGUI();
        }
        
        private void InitializeGUI()
        {
            /// <summary>
            /// Initializer for the GUI, sets values to what they need to be at the start of the program
            /// </summary>
            
            aliveBox.Text = "No Plant Selected";
            aliveBox.ForeColor = Color.Blue;
            daysSurvivedBox.Text = "0";
            daysSinceWaterBox.Text = "0";

            waterButton.Enabled = true;
            changePotsButton.Enabled = true;
            nextDayButton.Enabled = true;

            //sets picturebox visibility to false
            supremePictureBox.Visible = false;

            //sets buttons visiblity to false
            nextDayButton.Visible = false;
            changePotsButton.Visible = false;
            waterButton.Visible = false;
            resetButton.Visible = false;

            //sets what we want the user to see when starting up to Visibility = true
            chooseYourPlantLabel.Visible = true;
            chooseRoseButton.Visible = true;
            chooseDaliaButton.Visible = true;

            //set the water plant button to white
            daysSinceWaterBox.BackColor = Color.White;

            //set the pot detection to transparent 
            changePotButton.BackColor = Color.Transparent;
            changePotButton.Checked = false;
        }

        private void nextDayButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// This class is triggered when an user clicks on the next day button
            /// Handles everything that needs to happen on the next day
            /// </summary>

            //plant next day
            if (plant.Get_isAlive())
            {
                //sets the picture for the plant
                PictureForDay();

                plant.NextDay();

                daysSurvivedBox.Text = Convert.ToString(plant.Get_daysAlive());
                daysSinceWaterBox.Text = Convert.ToString(plant.Get_daysSinceWatered());

                changePotButton.Checked = arduino.shouldLightBeOn(plant, pot);
                if(changePotButton.Checked )
                {
                    changePotButton.BackColor = Color.DarkRed;
                }
                else
                {
                    changePotButton.BackColor = Color.Transparent;
                }

                //check the water levels of the plant
                CheckWater();
                
                //If plant weighs mroe than the pot
                if (arduino.IsPlantWeightGreaterThanPotWeight(plant, pot))
                {
                    DeathOfPlant();
                }
                
            }
            else
            {
                DeathOfPlant();
            }
        }

        private void CheckWater() {
            /// <summary>
            /// Checks what the water button color should be, yellow and red denote danger
            /// </summary>
            
            if (plant.Get_name() == "Dalia")
            {
                if(plant.Get_daysSinceWatered() >= 1)
                {
                    daysSinceWaterBox.BackColor = Color.Yellow;
                }
                if(plant.Get_daysSinceWatered() > 2)
                {
                    daysSinceWaterBox.BackColor = Color.Red;
                }
            }

            if (plant.Get_name() == "Rose")
            {
                if (plant.Get_daysSinceWatered() > 2)
                {
                    daysSinceWaterBox.BackColor = Color.Yellow;
                }
                if (plant.Get_daysSinceWatered() >= 6)
                {
                    daysSinceWaterBox.BackColor = Color.Red;
                }
            }
        }

        private void PictureForDay()
        {
            /// <summary>
            /// Controls what picture gets displayed in the Picturebox, picture of which plant and if it should be in a upgraded pot
            /// </summary>
            
            //gets name for the picture
            supremePictureBox.Visible = true;

            if (plant.Get_name() == "Dalia")
            {
                supremePictureBox.Image = Properties.Resources.Dahlia1;

                //if pot1 is upgraded
                if (pot.Get_isUpgradedPot())
                {
                    supremePictureBox.Image = Properties.Resources.DahliaA1;
                }

                //if plant weight is greater than 6
                if (plant.Get_plantWeight() >= 4)
                {
                    supremePictureBox.Image = Properties.Resources.Dahlia2;

                    //if pot is upgraded
                    if (pot.Get_isUpgradedPot())
                    {
                        supremePictureBox.Image = Properties.Resources.DahliaA2;
                    }

                    //if plant weight is greater than 10
                    if (plant.Get_plantWeight() >= 8)
                    {
                        supremePictureBox.Image = Properties.Resources.Dahlia3;

                        //if pot3 is upgraded
                        if (pot.Get_isUpgradedPot())
                        {
                            supremePictureBox.Image = Properties.Resources.DahliaA3;
                        }
                    }
                }
            }

            //if plant name is Rose
            if(plant.Get_name() == "Rose")
            {
                supremePictureBox.Image = Properties.Resources.Rose11;
                //if its upgraded
                if (pot.Get_isUpgradedPot())
                {
                    supremePictureBox.Image = Properties.Resources.RoseA1;
                }

                //if plant weight is greater than 10
                if (plant.Get_plantWeight() >= 10)
                {
                    supremePictureBox.Image = Properties.Resources.Rose2;

                    //if pot is upgraded
                    if (pot.Get_isUpgradedPot())
                    {
                        supremePictureBox.Image = Properties.Resources.RoseA2;
                    }

                    //if plant weight is greater than 20
                    if (plant.Get_plantWeight() >= 20)
                    {
                        supremePictureBox.Image = Properties.Resources.Rose3;

                        //if pot is upgraded
                        if (pot.Get_isUpgradedPot())
                        {
                            supremePictureBox.Image = Properties.Resources.RoseA31;
                        }
                    }
                }
            }
        }
        
        private void DeathOfPlant()
            {
                /// <summary>
                /// If this method is run the plant "dies" and the game is l
                /// </summary>

                //determine cause of death with a method and then put in the accurate picture
                aliveBox.ForeColor = Color.Red;
                aliveBox.Text = "DEAD";

                //set picture to surrender
                supremePictureBox.Image = Properties.Resources.Surrender; 

                //prevents buttons from being clicked
                waterButton.Enabled = false;
                changePotsButton.Enabled = false;
                nextDayButton.Enabled = false;
            }
        
        private void waterButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If the user clicks the water button button this method is run. 
            /// Waters the plant basically
            /// </summary>
            
            plant.WaterPlant();
            daysSinceWaterBox.Text = Convert.ToString(plant.Get_daysSinceWatered());
            daysSinceWaterBox.BackColor = Color.White;
        }

        private void changePotsButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If the user clicks the change pots button this method is run
            /// Double checks if the user SHOULD be upgrading, if not then the plant dies (too much space)
            /// </summary>
            
            if (arduino.Get_isLightOn())
            {
                pot.UpgradePotWeightCapacity();
                changePotButton.Checked = arduino.shouldLightBeOn(plant, pot);
            }
            else
            {
                DeathOfPlant();
            }   
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// If the user clicks reset button then this method is run
            /// Resets everything as if the user is just starting the game
            /// </summary>
            
            pot.ResetPot();
            InitializeGUI();
        }

        private void chooseRoseButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Selects the rose plant
            /// </summary>

            //set plant to Rose
            this.plant = new Rose();

            supremePictureBox.Image = Properties.Resources.Rose11;

            InitializePart2();
        }

        private void chooseDaliaButton_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// Selects the Dahlia plant, sometimes misspelled as Dalia 
            /// </summary>
            
            this.plant = new Dalia();

            supremePictureBox.Image = Properties.Resources.Dahlia1;

            InitializePart2();
        }

        private void InitializePart2()
        {
            /// <summary>
            /// Initializer after the user picks a plant at the start of the program
            /// </summary>


            aliveBox.ForeColor = Color.Green;
            aliveBox.Text = "Alive";

            //sets picturebox visibility to true
            supremePictureBox.Visible = true;

            //sets buttons visiblity to false
            nextDayButton.Visible = true;
            changePotsButton.Visible = true;
            waterButton.Visible = true;
            resetButton.Visible = true;

            //Sets the game buttons to visible while making the menu choices invisible
            chooseYourPlantLabel.Visible = false;
            chooseRoseButton.Visible = false;
            chooseDaliaButton.Visible = false;
        }
    }
}