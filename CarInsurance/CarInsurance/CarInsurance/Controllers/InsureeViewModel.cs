namespace CarInsurance.Controllers
{
    public class InsureeViewModel
    {
        public string FirstName { get; internal set; }
        public int DateOfBirth { get; internal set; }
        public string CarModel { get; internal set; }
        public string CarMake { get; internal set; }
        public int CarYear { get; internal set; }
        public decimal SpeedingTickets { get; internal set; }
        public bool DUI { get; internal set; }
        public bool FullCoverage { get; internal set; }
        public string LastName { get; internal set; }
        public object Email { get; internal set; }
        public int Age { get; internal set; }
    }
}