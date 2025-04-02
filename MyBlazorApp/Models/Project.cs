namespace MyBlazorApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string CityImage { get; set; }
        public string HouseImage { get; set; }
        public bool IsResidential { get; set; }
    }
}
