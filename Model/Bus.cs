namespace Model
{
    public class Bus
    {
        public Guid Id { get; init; }
        public string? Number { get; init; }
        public List<Route> Routes { get; init; } = new List<Route>();
        public override string ToString()
        {
            return "Bus number " + Number;
        }
    }
}
