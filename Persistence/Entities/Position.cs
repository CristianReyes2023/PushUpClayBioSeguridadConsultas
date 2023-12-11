using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Position
{
    public int Id { get; set; }

    public string NamePosition { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
