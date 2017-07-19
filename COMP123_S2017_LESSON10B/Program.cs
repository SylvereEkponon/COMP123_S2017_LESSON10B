using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name : Sylvere Ekponon
 * Date : July 11, 2017
 * Description : Demo for Lesson 9
 * version: 0.1 - Created the program class
 * Version: 0.2 - Instantiated an object of type SuperHuman
 * Version: 0.3 - Added a Power to the SuperHuman object
 * version: 0.4 - Adde another Power to the SuperHuman object
 *              - Also displayed all the powers in the Powers List
 * version: 0.5 - used the toString method 
 * version: 0.6 - Implemented the SuperHero class
 * version: 0.7 - Outputed the Karma value
 * version: 0.8 - Implemented the SuperVillain > and < overloaded operator methods
 */
namespace COMP123_S2017_LESSON10B
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperVillain superVillain = new SuperVillain("SuperVillain Dude", 100);
            superVillain.AddPower("Cheating", 50);
            superVillain.AddPower("Stealing", 40);
            superVillain.AddPower("Combat Senses", 30);
            Console.WriteLine(superVillain.ToString());
            Console.WriteLine("Malice: " + superVillain.Malice);

            if (superVillain.GetPower("Cheating") >

                superVillain.GetPower("Combat Senses"))

            {

                Console.WriteLine("Cheating is more powerful than Combat Senses");

            }



            if (superVillain.GetPower("Combat Senses") >

                superVillain.GetPower("Stealing"))

            {

                Console.WriteLine("Combat Senses is more powerful than Stealing");

            }

            else

            {

                Console.WriteLine("Combat Senses is weaker than Stealing");

            }





        }
    }
}
