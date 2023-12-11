using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string IdEmployee { get; set; } = null!;

        public string NameEmployee { get; set; } = null!;

        public DateTime DateRegister { get; set; }

        public string TelephoneNumber { get; set; } = null!;

        public int IdCityFk { get; set; }

        public int IdPositionFk { get; set; }
    }
}