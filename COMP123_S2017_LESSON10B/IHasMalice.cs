using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Name : Sylvere Ekponon
 * Date : July 13, 2017
 * Description : This is an Interface that defines a Malice Property that must be implemented in any class that subscribes to it.
 * version: 0.1 - Created IHasMalice interface
 */

namespace COMP123_S2017_LESSON10B
{
    /// <summary>
    /// This is the Malice interface
    /// </summary>
    public interface IHasMalice
    {

        //PUBLIC PROPERTIES
        int Malice { get; set; }

    }
}
