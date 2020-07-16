using System;
using System.Collections.Generic;

namespace MISA.Entity
{
    public partial class Employee
    {
        public Guid EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int? Gender { get; set; }
        public DateTime? DateOfBieth { get; set; }
        public string CitizenIdentityCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int? WorkState { get; set; }
        public Guid? PositionId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string CreatedBy { get; set; }

        public virtual Position Position { get; set; }
    }
}
