namespace Model
{
    public class Company
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<Route> Routes { get; } = new List<Route>();
        public override string ToString()
        {
            return "Company \"" + Name + "\"";
        }
    }
}
