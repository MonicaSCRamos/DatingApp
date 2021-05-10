using System;

namespace API.Extensions
{
    public static class DateTimeExtensions
    {
        public static int CalculateAge(this DateTime dob)
        {
            var today = DateTime.Today;
            var age = today.Year - dob.Year;
<<<<<<< HEAD
            if(dob.Date > today.AddYears(-age)) age--;
=======
            if (dob.Date > today.AddYears(-age)) age--;
>>>>>>> 75c43fc1347a43cfc220646f0fe5b1a3c0f1dcf9
            return age;
        }
    }
}