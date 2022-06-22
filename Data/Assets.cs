using Model;

namespace Data
{
    public class Assets
    {
        public IEnumerable<Bus>? Buses { get; set; }
        public IEnumerable<Route>? Routes { get; init; }
        public IEnumerable<Company>? Companies { get; init; }
        public IEnumerable<BusRoute>? BusRoutes { get; init; }
    }
}
