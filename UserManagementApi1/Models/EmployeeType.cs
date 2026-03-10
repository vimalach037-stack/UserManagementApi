using System;
using System.Collections.Generic;

namespace UserManagementApi1.Models;

public partial class EmployeeType
{
    public int EmployeeTypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
