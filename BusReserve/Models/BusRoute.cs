using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BusReserve.Models
{
    public class BusRoute
    {
        [Key]
        public string RouteId { get; set; }
        public string ArrTime { get; set; }
        public string DepTime { get; set; }
        public string Date { get; set; }
    }
}
