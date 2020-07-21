namespace ViewingsApp.Models.ViewModel
{
    public class BookingValidation
    {
        public bool IsValid { get; set; }
        public string ErrorMessage { get; set; }

    public static BookingValidation Invalid(string errorMessage)
    {
          return new BookingValidation
                {
                    IsValid = false, ErrorMessage = errorMessage
                };
    }  

    }

}