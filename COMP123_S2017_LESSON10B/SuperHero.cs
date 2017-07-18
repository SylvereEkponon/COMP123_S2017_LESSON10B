using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 13, 2017
 * Description : Demo for Lesson 9
 * version: 0.1 - Created the SuperHero class
 * version: 0.2 - Modified Constructor to take Karma Value 
 */

namespace COMP123_S2017_LESSON10B
{
    /// <summary>
    /// This is the SuperHero class
    /// </summary>
    public class SuperHero : SuperHuman, IHasKarma
    {
        //PUBLIC INSTANCE VARIABLES
        private int _karma;


        //PUBLIC PROPERTIES
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }


        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the SuperHero class
        /// It takes one parameter - name(string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHero(string name, int karma) : base(name)
        {
            this.Karma = karma;
        }
    }
}
