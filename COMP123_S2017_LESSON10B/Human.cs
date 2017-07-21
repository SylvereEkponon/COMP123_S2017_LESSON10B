using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 11, 2017
 * Description : This is the Abstract Human class
 * version: 0.1 - Created the Abstract Human class
 * version: 0.2 - Added public Abstract method DisplaySkills
 * version: 0.3 - Added public Abstract method Trains
 */

namespace COMP123_S2017_LESSON10B
{
    /// <summary>
    /// This is the Abstract Human Class
    /// </summary>
    public abstract class Human
    {
        //PRIVATE INSTANCE VARIABLE (FIELDS)
        private string _name;

        //PUBLIC PROPERTIES
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        //CONSTRUCTORS-----------------------------------------------------
        /// <summary>
        /// This is the main constructor for the Human
        /// It takes on parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public Human(string name)
        {
            this.Name = name;
        }

        //PRIVATE METHODS


        //PUBLIC ABSTRACT METHODS
        public abstract void DisplaySkills();
        public abstract void Trains();
    }
}
