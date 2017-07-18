using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 11, 2017
 * Description : This is the SuperHuman class extends the Abstract Human class
 * version: 0.1 - Created the SuperHuman class
 * version: 0.2 - Added _initialize method
 * Version: 0.3 - Added AddPower method 
 * Version: 0.4 - Added DisplayPowers method
 * version: 0.5 - Overridden the built-in toString method
 * version: 0.6 - Added stub Method DisplaySkills to the SuperHuman class to conform to the Human class
 */

namespace COMP123_S2017_LESSON10B
{
    /// <summary>
    /// This is the SuperHuman class
    /// </summary>
    public class SuperHuman : Human
    {

        //PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;

        //PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; //this returns a reference
            }
        }

        //CONSTRUCTORS

        /// <summary>
        /// This the main constructor for the SuperHuman class
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name) : base(name)
        {
            this._initialize();

        }

        //PRIVATE METHODS 


        /// <summary>
        /// This method initializes,instantiates and assigns values to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); //creates an empty list
        }

        //PUBLIC METHODS
        /// <summary>
        /// This method displays each of the powers stored in the Powers List
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }


        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// Overridden the built-in toString method
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string outputString = "";
            outputString += "========================================\n";
            outputString += "SuperHuman Name: " + this.Name + "\n";
            outputString += "========================================\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";

            }
            outputString += "========================================\n";
            return outputString;
        }

        //PUBLIC OVERRIDDEN METHODS
        /// <summary>
        /// This is DisplaySkills method
        /// NEED TO BE IMPLEMENTED
        /// </summary>
        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }

    }
}
