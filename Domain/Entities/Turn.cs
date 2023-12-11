using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Turn : BaseEntity
{

    public string NameTurns { get; set; } = null!;

    public TimeOnly HourShiftStart { get; set; }

    public TimeOnly HourShiftFinally { get; set; }

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
