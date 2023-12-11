using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class PositionDto
    {
        public int Id { get; set; }
        public string NamePosition { get; set; } = null!;
    }
}