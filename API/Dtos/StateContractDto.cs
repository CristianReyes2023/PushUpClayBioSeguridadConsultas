using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class StateContractDto
    {
        public int Id { get; set; }
        public string Description { get; set; } = null!;
    }
}