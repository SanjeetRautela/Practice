using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice
{
    public class AccessModifierPractice
    {

        public string creta = "1"; //accessible for all
        private string breeza = "2"; //within the same class
        protected string nexon = "3"; //ccessible within the same class or in child
        internal string indica = "4"; //within own assembly

    }


    public class ChildAccessModifierPractice : AccessModifierPractice
    {

        public void TestAccess()
        {
            creta = "Creta";
            //breeza -- not accessible
            nexon = "Nexon";
            indica = "Indica";
            //ENUM
            Level level = Level.Medium;
            Console.WriteLine(level);
        }


    }

    /// <summary>
    /// Level Enum
    /// </summary>
    public enum Level
    {
        Low,//0
        Medium,//1
        High//2
    }
}
