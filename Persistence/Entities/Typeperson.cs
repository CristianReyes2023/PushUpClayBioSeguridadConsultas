using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Typeperson
{
    public int Id { get; set; }

    public string Description { get; set; }

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();
}
