using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice
{
    //OOPS concept pratice
    //Implemeting Abstraction, Inheritance, Encapsulation, Polimorphism

    public abstract class Shape
    {
        public abstract int area();
    
    }

    /// <summary>
    /// 
    /// </summary>
    public class Square : Shape, ITestInterface
    {
        private int side;

        public Square(int x)
        {
            side = x;
        }

        public override int area()
        {
            return (side * side);
        }

        /// <summary>
        /// Interface method implementation
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int Multiplication(int num1, int num2)
        {
            return num1 * num2;
        }

    }

    public class MethodOverloadingPractice
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }
        public int Add(int num1, int num2, int num3)
        {
            return (num1 + num2 + num3);
        }
    }

    public class PolimorphismBase
    {
        public virtual int multiplication(int num1, int num2)
        {
            return (num1 * num2);
        }
    }

    public class PolimorphismChild : PolimorphismBase
    {
        public override int multiplication(int num1, int num2)
        {
            int result = 0;

            if (num1 > 2)
            {
                result = (num1 * num2);
            }
            else
            {
                Console.WriteLine("num1 should be greater than 2");
            }
            return result;
        }
    }
    public class OOPPractice
    {

        //static void Main(string[] args)
        // {

        //     #region OOPPractice

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

        //     #endregion

        //#region StringManupulation
        //StringManipulation sm = new StringManipulation();
        //sm.ManipulateName();
        //    #endregion

       // }
    }
}
