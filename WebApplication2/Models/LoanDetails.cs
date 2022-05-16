using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class LoanDetails
    {
        public int LoanNumber { get; set; }
        public string EmailId { get; set; }
        public string BankAccountNo { get; set; }
        public string MaxLoan { get; set; }
        public string LoanAmount { get; set; }
        public int LoanTenure { get; set; }
        public string Emi { get; set; }
        public DateTime? LoanDate { get; set; }

        public virtual LoanRequest BankAccountNoNavigation { get; set; }
        public virtual UserDetails Email { get; set; }
    }
}
