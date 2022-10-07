namespace Coffee.StorageApp.Entities
{
    public class Organization
    {
        public int Code { get; set; }
        public string? Name { get; set; }

        public override string ToString() => $" Code: {Code}, FirstName: {Name}";

    }
}
