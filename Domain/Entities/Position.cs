using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Position : BaseEntity
{

    public string NamePosition { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
