/*
 * FileName: GradeItem
 * Author: Phillip Bridgeman
 * Date Created:
 * Last Data Modified:
 * Version: 1.0.0
 * Description: Represents a graded item with a score and max score, and provides a method to determine the LetterGrade based on the score.
 * Copyright:
 */

using System;

namespace Project3
{
    /// <summary>
    /// Representing an Graded Item.
    /// </summary>
    public class GradeItem
    {
        private decimal score;
        private decimal maxScore;

        /// <summary>
        /// Initializes an instance of GradeItem with specified score and maximum score.
        /// </summary>
        /// <param name="score">The score of student on graded item.</param>
        /// <param name="maxScore">The maximum score of the graded item.</param>
        public GradeItem(decimal score, decimal maxScore)
        {
            this.score = score; // initialize the score field with the provided score value
            this.maxScore = maxScore; // initialize the maxScore field with the provided maxScore value
        }

        /// <summary>
        /// Determines the letter grade of the graded item.
        /// </summary>
        /// <returns></returns>
        public LetterGrade GetLetterGrade()
        {
            decimal percentage = (score / maxScore) * 100; // calculate the percentage of the score out of the max score

            // determine the LetterGrade based on the percentage
            if (percentage >= 90) return LetterGrade.APlus;
            if (percentage >= 80) return LetterGrade.A;
            if (percentage >= 75) return LetterGrade.BPlus;
            if (percentage >= 70) return LetterGrade.B;
            if (percentage >= 65) return LetterGrade.CPlus;
            if (percentage >= 60) return LetterGrade.C;
            if (percentage >= 50) return LetterGrade.D;

            // if the percentage is below 50, return an F
            return LetterGrade.F;
        }
    }
}