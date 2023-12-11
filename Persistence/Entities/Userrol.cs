using System;
using System.Collections.Generic;

namespace Persistence.Entities;

public partial class Userrol
{
    public int? UsuarioId { get; set; }

    public int? RolId { get; set; }

    public virtual Rol? Rol { get; set; }

    public virtual User? Usuario { get; set; }
}
