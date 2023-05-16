/*
 * FileName: Program.cs
 * Author: Phillip Bridgeman
 * Date Created: 2023-05-04
 * Last Data Modified: 2023-05-04
 * Version: 1.0.0
 * Description: Demostation of arrays and for loops to test the code of GradeItem.cs and LetterGrade.cs.
 * Copyright:
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    /// <summary>
    /// Demostration the use arrays, and for loop with clasess and enumeration as apart of the project 3.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an array of GradeItem objects and initialize it with 8 items.
            GradeItem[] gradeItems = new GradeItem[]
            {
                new GradeItem(45, 100), // create a GradeItem object with a score of 45 out of 100
                new GradeItem(50, 100), // create a GradeItem object with a score of 50 out of 100
                new GradeItem(60, 100), // create a GradeItem object with a score of 60 out of 100
                new GradeItem(65, 100), // create a GradeItem object with a score of 65 out of 100
                new GradeItem(70, 100), // create a GradeItem object with a score of 70 out of 100
                new GradeItem(75, 100), // create a GradeItem object with a score of 75 out of 100
                new GradeItem(80, 100), // create a GradeItem object with a score of 80 out of 100
                new GradeItem(90, 100)  // create a GradeItem object with a score of 90 out of 100
            };

            // Iterate through the array of GradeItem objects and print the LetterGrade for each one.
            for (int i = 0; i< gradeItems.Length; i++)
            {
                Console.WriteLine($"GradeItem {i + 1}: {gradeItems[i].GetLetterGrade()}");
            }

            // Wait for the user to press a key before exiting.
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
        }
    }
}
