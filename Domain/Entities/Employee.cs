using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Employee : BaseEntity
{

    public string IdEmployee { get; set; } = null!;

    public string NameEmployee { get; set; } = null!;

    public DateTime DateRegister { get; set; }

    public string TelephoneNumber { get; set; } = null!;

    public int IdCityFk { get; set; }

    public int IdPositionFk { get; set; }

    public virtual ICollection<AddressOffice> Addressoffices { get; set; } = new List<AddressOffice>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual City IdCityFkNavigation { get; set; } = null!;

    public virtual Position IdPositionFkNavigation { get; set; } = null!;

    public virtual ICollection<Programming> Programmings { get; set; } = new List<Programming>();
}
