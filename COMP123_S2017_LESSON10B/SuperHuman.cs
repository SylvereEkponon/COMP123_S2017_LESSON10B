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
 * version: 0.7 - Added private _getPowerIndex method
 * version: 0.8 - Added the GetPower method
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
        
        /// <summary>
        /// This is the private method returns the index of the Power Name in the power list
        /// If not found it returns -1
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private int _getPowerIndex(string name)
        {
            int index = 0;
            foreach (Power power in this.Powers)
            {
                if (name.Equals(power.Name))
                {
                    break;
                }
                index++;

                if (this.Powers.Count==index)
                {
                    index = -1; //this means that we did not find the Power in the list
                }
            }
            return index;
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

        /// <summary>
        /// This method returns the power object that matches the Power name.
        /// If the power is not found it returns an anonymous Power object with
        /// the name of "Power not found"
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Power GetPower(string name)
        {
            int index = this._getPowerIndex(name);
            if (index !=-1)
            {
                return this.Powers[index];
            }
            return new Power("Power not found", 0);
            
        }

    }
}
