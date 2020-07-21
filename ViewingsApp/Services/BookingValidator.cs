﻿using System.Collections.Generic;
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
                return new BookingValidation 
                { 
                    IsValid = false, ErrorMessage = "You must provide a name" 
                };
            }
            return new BookingValidation 
            { 
                IsValid = true, ErrorMessage = "" 
            };
        }
    }
}

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