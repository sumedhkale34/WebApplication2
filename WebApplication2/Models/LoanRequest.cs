using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace WebApplication2.Models
{
    public partial class LoanRequest
    {
        public LoanRequest()
        {
            LoanDetails = new HashSet<LoanDetails>();
        }

        public string BankAccountNo { get; set; }
        public string EmailId { get; set; }
        public int? ReqId { get; set; }
        public string PropertyName { get; set; }
        public string Propertystreet { get; set; }
        public string Propertycity { get; set; }
        public string Propertystate { get; set; }
        public string EmploymentType { get; set; }
        public string OrganizationType { get; set; }
        public int? RetirementAge { get; set; }
        public string MonthlyIncome { get; set; }
        public string EstimatedAmount { get; set; }
        public string RequestEmi { get; set; }
        public int Tenure { get; set; }
        public DateTime? RequestDate { get; set; }
        public string Status { get; set; }

        public virtual UserDetails Email { get; set; }
        public virtual ICollection<LoanDetails> LoanDetails { get; set; }
    }
}
