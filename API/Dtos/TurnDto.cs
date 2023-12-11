using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class TurnDto
    {
        public int Id { get; set; }
        public string NameTurns { get; set; } = null!;

        public TimeOnly HourShiftStart { get; set; }

        public TimeOnly HourShiftFinally { get; set; }
    }
}