using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Turn
{
    public int Id { get; set; }

    public string NameTurns { get; set; }

    public TimeOnly HourShiftStart { get; set; }

    public TimeOnly HourShiftFinally { get; set; }

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
