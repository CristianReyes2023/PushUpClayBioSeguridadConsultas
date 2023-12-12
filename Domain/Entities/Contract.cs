using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contract : BaseEntity
{

    public DateTime DateContract { get; set; }

    public DateTime Datefinal { get; set; }

    public int IdClientFk { get; set; }

    public int IdEmployeeFk { get; set; }

    public virtual Client IdClientFkNavigation { get; set; }

    public virtual Employee IdEmployeeFkNavigation { get; set; }

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
