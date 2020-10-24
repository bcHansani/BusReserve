using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusReserve.Models
{
    public class Bus
    {
        [Key]
        public string BusId { get; set; }
        public string BusName { get; set; }
        public string AvailableSeats { get; set; }
    }
}
