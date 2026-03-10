using System;
using System.Collections.Generic;

namespace UserManagementApi1.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string EmailAddress { get; set; } = null!;

    public string? Phone { get; set; }

    public int? EmployeeTypeId { get; set; }

    public int? CompanyId { get; set; }

    public bool? IsActive { get; set; }

    public virtual Company? Company { get; set; }

    public virtual EmployeeType? EmployeeType { get; set; }
}
