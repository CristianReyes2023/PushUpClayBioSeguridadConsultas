using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Client
{
    public int Id { get; set; }

    public string IdClient { get; set; } = null!;

    public string NameCliente { get; set; } = null!;

    public DateTime DateRegister { get; set; }

    public string TelephoneNumber { get; set; } = null!;

    public int? IdTpersonFk { get; set; }

    public int? IdCityFk { get; set; }

    public virtual ICollection<Addressclient> Addressclients { get; set; } = new List<Addressclient>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual City? IdCityFkNavigation { get; set; }

    public virtual Typeperson? IdTpersonFkNavigation { get; set; }
}
