using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ContractDto
    {
        public int Id { get; set; }
        public DateTime DateContract { get; set; }

        public DateTime Datefinal { get; set; }

        public int IdClientFk { get; set; }

        public int IdEmployeeFk { get; set; }

        public int IdStateContractFk { get; set; }
    }
}