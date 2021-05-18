using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.ValidationAttributes
{
    class SeatNumberValidationAttribute : ValidationAttribute
    {
        public static ValidationResult IsValidSeatNumber(int seatNr)
        {
            if (seatNr < 20 && seatNr > 0)
                return ValidationResult.Success;
            else
                return new ValidationResult("Its not a valid seat number.");
        }
    }
}
