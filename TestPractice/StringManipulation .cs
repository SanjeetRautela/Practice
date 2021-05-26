using System;
using System.Collections.Generic;
using System.Text;

namespace TestPractice
{
    public class StringManipulation
    {

        private String FirstName = "Sanjeet";
        private String LastName = "Rautela";
        // Initialize with a regular string literal.
        string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";
        // Initialize with a verbatim string literal.
        string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

        private String result;
       
        public void ManipulateName()
        {
            //Concatination
            result = String.Concat(FirstName, LastName); //1

            result = FirstName + " " + LastName; //2

            result = String.Format("{0} {1}", FirstName, LastName);

            char[] letters = { 'A', 'B', 'C' };
            string alphabet = new string(letters); //ABC


            //Comparision
            //string root = @"C:\users";
            //string root2 = @"C:\users";
            //bool result1 = root.Equals(root2);//True
            string root = @"C:\users";
            string root2 = @"C:\Users";
            bool result1 = root.Equals(root2);//False
            int abc = String.Compare(root, root2, true);//0 means string are equal and third parm is related to case check
        }

        //static void Main(string[] args)
        //{

        //    #region StringManupulation
        //    StringManipulation sm = new StringManipulation();
        //    sm.ManipulateName();
        //    #endregion

        //}

    }
}
