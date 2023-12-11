using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Employee
{
    public int Id { get; set; }

    public string IdEmployee { get; set; } = null!;

    public string NameEmployee { get; set; } = null!;

    public DateTime DateRegister { get; set; }

    public string TelephoneNumber { get; set; } = null!;

    public int IdCityFk { get; set; }

    public int IdPositionFk { get; set; }

    public virtual ICollection<Addressoffice> Addressoffices { get; set; } = new List<Addressoffice>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual City IdCityFkNavigation { get; set; } = null!;

    public virtual Position IdPositionFkNavigation { get; set; } = null!;

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
