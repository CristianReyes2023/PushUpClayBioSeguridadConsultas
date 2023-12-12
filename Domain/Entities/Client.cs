using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Client : BaseEntity
{

    public string IdClient { get; set; }

    public string NameCliente { get; set; }

    public DateTime DateRegister { get; set; }

    public string TelephoneNumber { get; set; }

    public int? IdTpersonFk { get; set; }

    public int? IdCityFk { get; set; }

    public virtual ICollection<Addressclient> Addressclients { get; set; } = new List<Addressclient>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual City IdCityFkNavigation { get; set; }

    public virtual Typeperson IdTpersonFkNavigation { get; set; }
}
