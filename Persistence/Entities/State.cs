using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class State
{
    public int Id { get; set; }

    public string NameState { get; set; } = null!;

    public int IdCountryFk { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual Country IdCountryFkNavigation { get; set; } = null!;
}
