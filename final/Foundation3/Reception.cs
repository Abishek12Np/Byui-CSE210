// Derived Reception class representing receptions with RSVP email attribute
public class Reception : Event
{
    private string rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        this.rsvpEmail = rsvpEmail;
    }

    // Getter method for RSVP email
    public string GetRsvpEmail()
    {
        return rsvpEmail;
    }

    // Override FullDetails method to include reception-specific details
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nRSVP Email: {rsvpEmail}";
    }
}