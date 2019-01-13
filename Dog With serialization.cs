using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{ [Serializable()]
    class Dog:Animal
    {

        public Dog()
        {
            Console.WriteLine("A Dog has been created!");
        }
        public override void eats()
        {
            Console.WriteLine("The dog likes to eat treats");
        }

        public override void sleep()
        {
            Console.WriteLine("The dog sleeps on the couch or his bed");
            }
        }
    }
