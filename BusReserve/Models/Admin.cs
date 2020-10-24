using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusReserve.Models
{
    public class Admin
    {
        [Key]
        public string AdminId { get; set; }
        public string Password { get; set; }
    }
}
