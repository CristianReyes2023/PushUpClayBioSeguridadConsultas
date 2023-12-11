using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class AddressOffice : BaseEntity
{

    public string TipoVia { get; set; }

    public short NumeroPrincipal { get; set; }

    public string LetraPrincipal { get; set; }

    public string Bis { get; set; }

    public string LetraSecundaria { get; set; }

    public string CardinalPrimario { get; set; }

    public short NumeroSecundario { get; set; }

    public string CardinalSecundario { get; set; }

    public string Complemento { get; set; }

    public int IdEmployeeFk { get; set; }

    public int IdTaddressFk { get; set; }

    public virtual Employee IdEmployeeFkNavigation { get; set; } = null!;
}
