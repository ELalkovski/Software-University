namespace BusTicketSystem.Models
{
    using BusTicketSystem.Models.Enums;
    using System;

    public class Trip
    {
        public Trip()
        {
        }

        public Trip(string departureTime, string arrivalTime, BusStation originStation, BusStation destinationStation, BusCompany busCompany)
        {
            this.DepartureTime = departureTime;
            this.ArrivalTime = arrivalTime;
            this.OriginBusStation = originStation;
            this.DestinationBusStation = destinationStation;
            this.BusCompany = busCompany;
        }

        public int Id { get; set; }

        public string DepartureTime { get; set; }

        public string ArrivalTime { get; set; }

        public Status? Status { get; set; }

        public int? OriginBusStationId { get; set; }
        public BusStation OriginBusStation { get; set; }

        public int? DestinationBusStationId { get; set; }
        public BusStation DestinationBusStation { get; set; }

        public int BusCompanyId { get; set; }
        public BusCompany BusCompany { get; set; }
    }
}
