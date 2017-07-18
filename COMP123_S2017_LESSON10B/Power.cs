using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 11, 2017
 * Description : Demo for Lesson 9
 * version: 0.1 - Created the Power class
 * version: 0.2 - Added a constructor
 */

namespace COMP123_S2017_LESSON10B
{

    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {

        //PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        //CONSTRUCTORS
        /// <summary>
        /// This is the constructor for the Power class
        /// It takes two parameters - name (string) and rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

    }
}
