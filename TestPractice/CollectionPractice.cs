using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPractice
{
    public class CollectionPractice
    {
        /// <summary>
        /// 
        /// </summary>
        public void ArrayManupulation()
        {
            int[] numberArray;
            //int[] numberArray = new int[5];
            numberArray = new int[5] { 1, 2, 3, 4, 5 };
            //int[] intArray3 = { 1, 2, 3, 4, 5 };
            //int length = intArray3.Length;


            int max = numberArray[0];
            int temp = 0;

            for (int i = 0; i < numberArray.Length; i++)
            {
                if (numberArray[i] > max)
                {
                    max = numberArray[i];
                }

                //Sort the array in ascending order  
                for (int j = i + 1; j < numberArray.Length; j++)
                {
                    if (numberArray[i] > numberArray[j])
                    {
                        temp = numberArray[i];
                        numberArray[i] = numberArray[j];
                        numberArray[j] = temp;
                    }
                }

            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void ArrayListManipulation()
        {
            ArrayList arlist = new ArrayList();
            arlist.Add(1);
            arlist.Add("Bill");

            arlist.Remove(1);
            arlist.Add("Sanjeet");
            if (!arlist.Contains(1))
            {
                arlist.Add(1);
            }

            foreach (var item in arlist)
            {
                Console.Write(item + ", ");
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void ListManipulation()
        {
            City city = new City()
            {
                Id = 10,
                Name = "abc"
            };

            List<City> cities = new List<City>()
            {
                new City(){ Id = 1, Name="Dehradun"},
                new City(){ Id = 2, Name="Noida"},
                new City(){ Id = 3, Name="Gurgaon"},
                new City(){ Id = 4, Name="Pune"}
            };

            cities.Add(city);
            cities = cities.OrderBy(x => x.Name).ToList();
            String name = cities.Where(x => x.Name == "Dehradun").Select(x=>x.Name).First();

        }

        /// <summary>
        /// 
        /// </summary>
        public void DictionaryManipulation()
        {
            IDictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (var kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void HashtableManipulation()
        {
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One"); //adding a key/value using the Add() method
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");

            foreach (DictionaryEntry kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }

        }

        public void LINQDemo()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            // First way
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //Second Way
            var result = scores.Where(x => x > 80);
        }

    }

    public class TestCode
    {
        public static void Main()
        {
            CollectionPractice obj = new CollectionPractice();
            obj.ListManipulation();
        }
    }

    /// <summary>
    /// City
    /// </summary>
    public class City
    {
        public Int16 Id { get; set; }
        public String Name { get; set; }

    }

}
