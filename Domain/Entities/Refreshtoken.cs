using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Refreshtoken
{
    public int RefreshTokenId { get; set; }

    public int? UserId { get; set; }

    public string Token { get; set; } = null!;

    public DateTime Expires { get; set; }

    public DateTime Created { get; set; }

    public DateTime? Revoked { get; set; }

    public bool? IsActive { get; set; }

    public virtual User RefreshToken { get; set; } = null!;
}
