using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Rol
{
    public int RolId { get; set; }

    public string Nombre { get; set; } = null!;
}
