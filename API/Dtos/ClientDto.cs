using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string IdClient { get; set; } = null!;

        public string NameCliente { get; set; } = null!;

        public DateTime DateRegister { get; set; }

        public string TelephoneNumber { get; set; } = null!;

        public int? IdTpersonFk { get; set; }

        public int? IdCityFk { get; set; }
    }
}