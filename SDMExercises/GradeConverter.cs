using System;

namespace SDMExercises
{
    public class GradeConverter
    {
        public static int ToGrade(int percentage)
        {
            if (percentage is < 0 or > 100)
                throw new ArgumentException("Percentage must always be between 0 and 100 (both included)");

            switch (percentage)
            {
                case int n when (n <= 5):
                    return -3;
                case int n when (n > 5 && n <= 49):
                    return 0;
                case int n when (n > 49 && n <= 59):
                    return 2;
                case int n when (n > 59 && n <= 79):
                    return 4;
                case int n when (n > 79 && n <= 84):
                    return 7;
                case int n when (n > 84 && n <= 94):
                    return 10;
                case int n when (n > 94):
                    return 12;
                default:
                    throw new Exception("Invalid input");
            }
        }
    }
}