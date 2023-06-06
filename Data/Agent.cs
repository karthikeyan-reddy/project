using System;
using System.Collections.Generic;

namespace propertyinsurance2.Data;

public partial class Agent
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public long Phone { get; set; }

    public string WorkLocation { get; set; } = null!;
}
