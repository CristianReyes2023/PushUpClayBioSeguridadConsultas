using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Programming : BaseEntity
{

    public int IdContractFk { get; set; }

    public int IdTurnFk { get; set; }

    public int IdEmployeeFk { get; set; }

    public virtual Contract IdContractFkNavigation { get; set; } = null!;

    public virtual Employee IdEmployeeFkNavigation { get; set; } = null!;

    public virtual Turn IdTurnFkNavigation { get; set; } = null!;
}
