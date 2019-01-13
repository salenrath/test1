using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    [Serializable()]
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("An Animal has been created!");

        }

        public virtual void sleep()
        {
            Console.WriteLine("An animal Sleeps");
        }

        public virtual void eats()
        {
            Console.WriteLine("An animal eats different things");
        

        }
    }
}
