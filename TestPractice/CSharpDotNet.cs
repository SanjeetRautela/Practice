using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice
{
    /// <summary>
    /// Static Class and Method practice
    /// </summary>
    public static class College
    {
        //static fields  
        public static string CollegeName;
        public static string Address;

        //static constructor  
        static College()
        {
            CollegeName = "GEHU";
            Address = "Dehradun";
        }


        /// <summary>
        /// Try catch and Finally Practice Method
        /// </summary>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <returns></returns>
        public static String ContactName(String FirstName, String LastName)
        {
            String result = String.Empty;
            try
            {
                result = String.Concat(FirstName, LastName);
            }
            catch (Exception ex)
            {

                //throw ex;
                Console.WriteLine("Error : {0}", ex.Message);
            }
            finally
            {
                Console.WriteLine("Result: {0}", String.Concat(FirstName, LastName));
            }
            return result;
        }

        /// <summary>
        /// Pratice Throw expection method
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public static int ThrowPractice(int index)
        {
            int[] numbers = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException();
            }

            return numbers[index];
        }


        /// <summary>
        /// Break and Continue Practice Method
        /// </summary>
        public static void BreakContinuePractice()
        {
            List<int> EvenNumberList = new List<int>();
            List<int> OddNumberList = new List<int>();
            //Boolean IsPrimeNumber;
            for (int i = 1; i <= 200; i++)
            {
                if (i > 100)
                    break;  //Program will terminate and execution will stop   
                if (i % 2 == 0)
                {
                    EvenNumberList.Add(i);
                    continue; //Program will skip all the below code and execution will start from starting of loop 
                }
                else
                {
                    OddNumberList.Add(i);
                }
            }
        }
    }


    public class CSharpDotNet
    {

        //static void Main(string[] args)
        //{
        //    College.BreakContinuePractice();
        //    Console.WriteLine(College.CollegeName, College.Address);
        //    Console.WriteLine(College.ContactName("Sanjeet", "Rautela"));
        //    Console.Read();
        //}

    }
}
