using System.Collections.Generic;
using ViewingsApp.Models.Database;
using ViewingsApp.Models.Request;
using ViewingsApp.Models.ViewModel;

namespace ViewingsApp.Services
{
    public interface IBookingValidator
    {
        BookingValidation ValidateBooking(BookingRequest bookingRequest, IEnumerable<Agent> allAgents, IEnumerable<Property> allProperties);
    }

    public class BookingValidator : IBookingValidator
    {
        public BookingValidation ValidateBooking(BookingRequest bookingRequest, IEnumerable<Agent> allAgents, IEnumerable<Property> allProperties)
        {
            if (bookingRequest.Name == "")
            {
                return BookingValidation.Invalid("You must provide a name");
            }
             if (bookingRequest.PhoneNumber == "")
            {
                return BookingValidation.Invalid("You must provide a valid phone number");
            }
            return new BookingValidation 
            { 
                IsValid = true, ErrorMessage = "" 
            };
           
        }
    }
}




//Longer versions of above code 
//     if (bookingRequest.Name == null)
//     {
//         return new BookingValidation
//         {
//             IsValid = false,
//             ErrorMessage = "You must provide a name"
//         };
//     }
//     return new BookingValidation
//     {
//         IsValid = true,
//         ErrorMessage = ""
//     };
// }

//Old version of 3rd test
//    if (bookingRequest.PhoneNumber == "")
//             {
//                 return new BookingValidation
//                 {
//                     IsValid = false, ErrorMessage = "You must provide a valid phone number"
//                 };