using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Contract
{
    public int Id { get; set; }

    public DateTime DateContract { get; set; }

    public DateTime Datefinal { get; set; }

    public int IdClientFk { get; set; }

    public int IdEmployeeFk { get; set; }

    public int IdStateContractFk { get; set; }

    public virtual Client IdClientFkNavigation { get; set; } = null!;

    public virtual Employee IdEmployeeFkNavigation { get; set; } = null!;

    public virtual Statecontract IdStateContractFkNavigation { get; set; } = null!;

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
