﻿using Entities.Hotels;
using Entities.Transports;

namespace Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string? Meal { get; set; }
        public int AviablePeopleCount { get; set; }
        public int Duration { get; set; }
        public bool IsHotOffer { get; set; }
        public string? Description { get; set; }
        public string? ClientName { get; set; }
        public string? ClientSurname { get; set; }
        public virtual Hotel Hotel { get; set; }
        public int? TransportInId { get; set; }
        public virtual Transport? TransportIn { get; set; }
        public int? TransportOutId { get; set; }
        public virtual Transport? TransportOut { get; set; }
    }
}
