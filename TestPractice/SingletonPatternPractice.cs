using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{



    /// <summary>
    /// Singleton Design Pattern
    /// Key Points to remember
    /// constructor should be private and parameterless - only instantiates from within the class
    /// class should be sealed -  cannot be inherited.
    /// Create a private static variable that is going to hold a reference to the single created instance of the class
    ///  create a public static property/method which will return the single-created instance of the singleton class
    /// </summary>
    public sealed class SingletonPatternPractice
    {

        private static int counter = 0;
        private static SingletonPatternPractice instance = null;
        private static readonly object Instancelock = new object();
        public static SingletonPatternPractice GetInstance
        {
            get
            {
                lock (Instancelock)
                {
                    if (instance == null)
                    {
                        instance = new SingletonPatternPractice();
                    }
                }
                return instance;
            }
        }
        private SingletonPatternPractice()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails(String message)
        {
            Console.WriteLine(message);
        }
    }

    /// <summary>
    /// TestSingletonPatternPractice
    /// </summary>
    public class TestSingletonPatternPractice
    {
        //static void Main(string[] args)
        //{
        //    SingletonPatternPractice firstInstance = SingletonPatternPractice.GetInstance;
        //    firstInstance.PrintDetails("First Instance");

        //    SingletonPatternPractice secondInstance = SingletonPatternPractice.GetInstance;
        //    secondInstance.PrintDetails("Second Student");

        //    //Parallel.Invoke(
        //    //  () => PrintTeacherDetails(),
        //    //  () => PrintStudentdetails()
        //    //  );

        //    //static void PrintTeacherDetails()
        //    //{
        //    //    SingletonPatternPractice fromTeacher = SingletonPatternPractice.GetInstance;
        //    //    fromTeacher.PrintDetails("From Teacher");
        //    //}
        //    //static void PrintStudentdetails()
        //    //{
        //    //    SingletonPatternPractice fromStudent = SingletonPatternPractice.GetInstance;
        //    //    fromStudent.PrintDetails("From Student");
        //    //}

        //    Console.ReadLine();
        //}
    }

}

