using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference_Of_Squares
{
//    Find the difference between the square of the sum and the sum of the squares of the first N natural numbers.

//The square of the sum of the first ten natural numbers is (1 + 2 + ... + 10)² = 55² = 3025.

//The sum of the squares of the first ten natural numbers is 1² + 2² + ... + 10² = 385.

//Hence the difference between the square of the sum of the first ten natural numbers and the sum of the squares 
//        of the first ten natural numbers is 3025 - 385 = 2640.
//You are not expected to discover an efficient solution to this yourself from first principles; research is allowed, 
//    indeed, encouraged.Finding the best algorithm for the problem is a key skill in software engineering.

//This exercise requires you to process a collection of data. You can simplify your code by 
//    using LINQ (Language Integrated Query). For more information, see this page.


    public static class DifferenceOfSquares
    {
        public static int CalculateSquareOfSum(int max)
        {
            if (max == 1)
                return 1;
            else
                return (max * (max + 1) / 2) * (max *(max + 1) / 2);
        }

        public static int CalculateSumOfSquares(int max)
        {
            if (max == 1)
                return 1;
            else
                return (max * max + CalculateSumOfSquares(max - 1));
        }

        public static int CalculateDifferenceOfSquares(int max)
        {
            return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
        }
    }
}
