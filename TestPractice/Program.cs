using System;
using System.Collections.Generic;
using System.Linq;

namespace TestPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            #region OOPPractice.cs

            //     // creating reference of Shape class
            //     // which refer to Square class instance
            //     Shape sh = new Square(4);
            //     double result = sh.area();
            //     Console.WriteLine(result);



            //     //Method Overloading
            //     MethodOverloadingPractice methodOverloadingPractice = new MethodOverloadingPractice();
            //     Console.WriteLine("Add with two int parameter :" + methodOverloadingPractice.Add(3, 2));
            //     Console.WriteLine("Add with three int parameter :" + methodOverloadingPractice.Add(3, 2, 8));


            //     //Polimorphism, Run Time Polymorphism Late Binding Dynamic Polymorphism
            //     PolimorphismBase polimorphismBase;
            //     polimorphismBase = new PolimorphismBase();
            //     polimorphismBase.multiplication(1, 2);//Base class method
            //     polimorphismBase = new PolimorphismChild();
            //     polimorphismBase.multiplication(3, 4); //Child class method

            #endregion

            #region StringBuilderPractice.cs

            //StringBuilderPractice sb = new StringBuilderPractice();
            //sb.SBBemo();
            #endregion

            #region StringManupulation.cs
            //    StringManipulation sm = new StringManipulation();
            //    sm.ManipulateName();
            #endregion

            #region CSharpDotNet.cs
            //College.BreakContinuePractice();
            //Console.WriteLine(College.CollegeName, College.Address);
            //Console.WriteLine(College.ContactName("Sanjeet", "Rautela"));
            //Console.Read();
            #endregion

            #region SingletonPattern
            //SingletonPatternPractice firstInstance = SingletonPatternPractice.GetInstance;
            //firstInstance.PrintDetails("First Instance");

            //SingletonPatternPractice secondInstance = SingletonPatternPractice.GetInstance;
            //secondInstance.PrintDetails("Second Student");

            ////Parallel.Invoke(
            ////  () => PrintTeacherDetails(),
            ////  () => PrintStudentdetails()
            ////  );

            ////static void PrintTeacherDetails()
            ////{
            ////    SingletonPatternPractice fromTeacher = SingletonPatternPractice.GetInstance;
            ////    fromTeacher.PrintDetails("From Teacher");
            ////}
            ////static void PrintStudentdetails()
            ////{
            ////    SingletonPatternPractice fromStudent = SingletonPatternPractice.GetInstance;
            ////    fromStudent.PrintDetails("From Student");
            ////}

            //Console.ReadLine();
            #endregion
        }
    }
}
