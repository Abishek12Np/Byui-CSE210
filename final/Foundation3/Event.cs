public class Event
{
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    public Event(string title, string description, string date, string time, Address address)
    {
        this.title = title;
        this.description = description;
        this.date = date;
        this.time = time;
        this.address = address;
    }

    // Getter methods for event attributes
    public string GetTitle()
    {
        return title;
    }

    public string GetDescription()
    {
        return description;
    }

    public string GetDate()
    {
        return date;
    }

    public string GetTime()
    {
        return time;
    }

    public Address GetAddress()
    {
        return address;
    }

    // Method to generate standard details message
    public string StandardDetails()
    {
        return $"Event: {title}\nDescription: {description}\nDate: {date}\nTime: {time}\nAddress: {address}";
    }

    // Virtual method to generate full details message
    public virtual string FullDetails()
    {
        return $"{StandardDetails()}\nType: {GetType().Name}";
    }

    // Method to generate short description message
    public string ShortDescription()
    {
        return $"Type: {GetType().Name}\nEvent: {title}\nDate: {date}";
    }
}