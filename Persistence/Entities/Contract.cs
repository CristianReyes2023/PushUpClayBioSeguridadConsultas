using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Contract
{
    public int Id { get; set; }

    public DateTime DateContract { get; set; }

    public DateTime Datefinal { get; set; }

    public int IdClientFk { get; set; }

    public int IdEmployeeFk { get; set; }

    public int IdStateContractFk { get; set; }

    public virtual Client IdClientFkNavigation { get; set; }

    public virtual Employee IdEmployeeFkNavigation { get; set; }

    public virtual Statecontract IdStateContractFkNavigation { get; set; }

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
