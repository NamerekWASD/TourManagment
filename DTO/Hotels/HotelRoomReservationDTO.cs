﻿namespace DTO.Hotels
{
    public class HotelRoomReservationDTO
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public int HotelStars { get; set; }
        public string HotelAddress { get; set; }
        public string HotelRoomName { get; set; }
        public int HotelRoomNumber { get; set; }
        public int HotelRoomSleepingPlaces { get; set; }
        public int HotelRoomPrice { get; set; }
        public string ClientName { get; set; }
        public string ClientSurname { get; set; }
        public DateTimeOffset ArrivalDate { get; set; }
        public DateTimeOffset DepartureDate { get; set; }
    }
}
