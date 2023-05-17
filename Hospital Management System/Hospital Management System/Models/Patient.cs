using System;


namespace Hospital_Management_System.Models
{
    class Patient
    {
        public int PatRegistrationId { get; set; }
        public string PatFirstName { get; set; }
        public string PatLastName { get; set; }
        public string PhoneNo { get; set; }
        public string Gender { get; set; }
        public int PatAge { get; set; }
        public string PatAddress { get; set; }  
        public string AadharNo { get; set; }
        public string SpecialityToConsult { get; set; }
    }
}
