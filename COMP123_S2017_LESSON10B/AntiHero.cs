using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name : Sylvere Ekponon
 * Date : July 20, 2017
 * Description : This is the Antihero class
 * It extends the SuperHuman class and implements both the IHasKarma and IHasMalice interfaces 
 * version: 0.1 - Created the AntiHero class
 * version: 0.2 - Implemented public Abstract method Trains
 */

namespace COMP123_S2017_LESSON10B
{
    /// <summary>
    /// This is the Antihero class
    /// </summary>
    public class AntiHero : SuperHuman, IHasKarma, IHasMalice
    {
        //PRIVATE INSTANCES VARIABLES
        private int _malice;
        private int _karma;

        //PUBLIC PROPERTIES
        public int Karma { get { return this._karma; } set { this._karma = value; } }
        public int Malice { get { return this._malice; } set { this._malice = value; } }

        //CONSTRUCTORS
        /// <summary>
        /// This is the main constructor for the Antihero class
        /// it takes three arguments - name(string) - karma (int) -  malice (int)
        /// </summary>
        /// <param name="name"></param>
        public AntiHero(string name, int karma, int malice) 
            : base(name)
        {
            this.Karma = karma;
            this.Malice = malice;
        }



        //PRIVATE METHODS



        //PUBLIC METHODS
        public override void Trains()
        {
            Console.WriteLine("NOT IMPLEMENTED");
        }

    }
}