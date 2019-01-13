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
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            
            dog.eats();
            dog.sleep();
            
            Console.ReadLine();


            Stream streamDog = File.Open("dog.xml", FileMode.Create);
            BinaryFormatter formatterDog = new BinaryFormatter();

            formatterDog.Serialize(streamDog, dog);
            streamDog.Close();

            dog = null;

            streamDog = File.Open("dog.xml", FileMode.Open);
            formatterDog = new BinaryFormatter();

            dog = (Dog)formatterDog.Deserialize(streamDog);
            streamDog.Close();

            Cats cats = new Cats();
            cats.eats();
            cats.sleep();

            Console.ReadLine();


            Stream streamCats = File.Open("cats.xml", FileMode.Create);
            BinaryFormatter formatterCats = new BinaryFormatter();

            formatterCats.Serialize(streamCats, cats);
            streamCats.Close();

            cats = null;

            streamCats = File.Open("cats.xml", FileMode.Open);
            formatterCats = new BinaryFormatter();

            cats = (Cats)formatterCats.Deserialize(streamCats);
            streamCats.Close();


            Console.ReadLine();

        }
    }
}