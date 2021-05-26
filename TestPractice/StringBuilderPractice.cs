using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice
{
    public class StringBuilderPractice
    {


        public void SBBemo()
        {
            StringBuilder builder = new StringBuilder("Hello ");

            builder.Append("Sanjeet");//Hello Sanjeet
            Console.WriteLine(builder);

            builder.AppendLine(" Singh");
            Console.WriteLine(builder);
            //Hello Sanjeet Singh
            //

            builder.Append("Welcome!");
            Console.WriteLine(builder);
            //Hello Sanjeet Singh
            // Welcome

            builder.Insert(29, " To Epam");
            Console.WriteLine(builder);
            //Hello Sanjeet Singh
            // Welcome! To Epam

            builder.Remove(13, 6);
            Console.WriteLine(builder);
            //Remove singh from String

            builder.Replace("Sanjeet", "Sanjeet Singh Rautela");
            Console.WriteLine(builder);
            //Repalce 


        }

    }
}
