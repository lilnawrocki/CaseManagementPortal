public class SupportCase
{
    public string Summary;
    public string Description;
    public enum Priority
    {
        Standard=0,
        High=1,
        Urgent=2
    }

    struct PersonalData
    {
        public string FirstName;
        public string LastName;
        public string EmailAddress;
    }
    
}
