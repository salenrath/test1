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
    class Cats:Animal
    {
        public Cats()
        {
            Console.WriteLine("The animal created was a Cat!");
            }
        public override void eats()
        {
            Console.WriteLine("A cat eats fish, chicken, and meats");
            }
        public override void sleep()
        {
            Console.WriteLine("A cat sleeps in a bed or in a cat tree");
            }
        }
    }
 
