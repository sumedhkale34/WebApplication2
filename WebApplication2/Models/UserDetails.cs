using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class UserDetails
    {
        public UserDetails()
        {
            LoanDetails = new HashSet<LoanDetails>();
            LoanRequest = new HashSet<LoanRequest>();
        }

        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }
        public string AadharNo { get; set; }
        public string PanCardNo { get; set; }

        public virtual ICollection<LoanDetails> LoanDetails { get; set; }
        public virtual ICollection<LoanRequest> LoanRequest { get; set; }
    }
}
