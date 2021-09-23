using System;

namespace SDMExercises
{
    public class TeenageClass
    {
        public static bool IsTeenager(DateTime birthday)
        {
            var age = CalculateAge(birthday.Date, DateTime.Today);
            return age is >= 13 and <= 19;
        }
        
        private static int CalculateAge(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
        }
    }
}