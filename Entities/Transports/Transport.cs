﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Transports
{
    public class Transport
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string DeparturePoint { get; set; }
        public DateTimeOffset DepartureTime { get; set; }
        public string ArrivalPoint { get; set; }
        public DateTimeOffset ArrivalTime { get; set; }
        public int TourId { get; set; }
        public virtual Tour Tour { get; set; }
        public virtual List<TransportPlace> TransportPlaces { get; set; }
    }
}
