using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Typeperson : BaseEntity
{

    public string Description { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
