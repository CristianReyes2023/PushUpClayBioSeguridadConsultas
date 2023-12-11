using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ProgrammingDto
    {
        public int Id { get; set; }
        public int IdContractFk { get; set; }

        public int IdTurnFk { get; set; }

        public int IdEmployeeFk { get; set; }
    }
}