/*
 * FileName: LetterGrade.cs
 * Author: Phillip Bridgeman
 * Date Created:
 * Last Data Modified:
 * Version: 1.0.0
 * Description: Represents a graded item with a score and max score, and provides a method to determine the LetterGrade based on the score.
 * An enumeration called LetterGrade is also defined with values of F, D, C, CPlus, B, BPlus, A, and APlus.
 * Copyright:
 */

using System;

// Namespace for practice project 3
namespace Project3
{
    /// <summary>
    /// Specifies the letter grades for grading.
    /// </summary>
    public enum LetterGrade // Declaring Enumeration of type LetterGrade
    {
        //List the value of the enum with separate documentation for XML format.

        /// <summary>
        /// The F grade.
        /// </summary>
        F,

        /// <summary>
        /// The D grade.
        /// </summary>
        D,

        /// <summary>
        /// The C grade.
        /// </summary>
        C,

        /// <summary>
        /// The CPlus grade.
        /// </summary>
        CPlus,

        /// <summary>
        /// The B grade.
        /// </summary>
        B,

        /// <summary>
        /// The BPlus grade.
        /// </summary>
        BPlus,

        /// <summary>
        /// The A grade.
        /// </summary>
        A,

        /// <summary>
        /// The APlus grade.
        /// </summary>
        APlus,
    }
}