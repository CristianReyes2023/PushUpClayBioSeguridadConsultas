using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class TypePerson : BaseEntity
{

    public string Description { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
