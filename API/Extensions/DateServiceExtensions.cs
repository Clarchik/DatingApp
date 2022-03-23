using System;

namespace API.Extensions
{
    public static class DateServiceExtensions
    {
        public static int CalculateAge(this DateTime BirthDate)
        {
            var today = DateTime.Now;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}