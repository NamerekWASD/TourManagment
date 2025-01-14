﻿namespace DTO.Transports
{
    public class TransportDTO
    {
        public TransportDTO() { }
        public TransportDTO(string Type, string DeparturePoint, DateTimeOffset DepartureTime, string ArrivalPoint, DateTimeOffset ArrivalTime)
        {
            this.Type = Type;
            this.DeparturePoint = DeparturePoint;
            this.DepartureTime = DepartureTime;
            this.ArrivalPoint = ArrivalPoint;
            this.ArrivalTime = ArrivalTime;
            TransportPlaces = new List<TransportPlaceDTO>();

        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string DeparturePoint { get; set; }
        public DateTimeOffset DepartureTime { get; set; }
        public string ArrivalPoint { get; set; }
        public DateTimeOffset ArrivalTime { get; set; }
        public int TourId { get; set; }
        public TourDTO Tour { get; set; }
        public List<TransportPlaceDTO> TransportPlaces { get; set; }
    }
}
