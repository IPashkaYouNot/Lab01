using System;

namespace Model
{
    public class Route
    {
        public Guid RouteId { get; set; }
        public string? Name { get; init; }
        public Point StartPoint { get; init; }
        public Point EndPoint { get; init; }
        public double Duration { get; init; }
        public int BusAmount => Buses.Count;
        public Company? Company { get; init; }
        public IEnumerable<string?> BusesNumbers => Buses.Select(x => x.Number);
        public List<Bus> Buses { get; } = new List<Bus>();
    }
}
