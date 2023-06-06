using System;
using System.Collections.Generic;

namespace propertyinsurance2.Data;

public partial class Customer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long? Phone { get; set; }

    public int Salary { get; set; }

    public int YearOfTenure { get; set; }

    public int CostOfProperty { get; set; }

    public string City { get; set; } = null!;

    public string? Password { get; set; }

    public int? AgentId { get; set; }
}
