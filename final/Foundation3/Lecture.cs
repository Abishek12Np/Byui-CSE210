public class Lecture : Event
{
    private string speaker;
    private int capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this.speaker = speaker;
        this.capacity = capacity;
    }

    // Getter methods for lecture attributes
    public string GetSpeaker()
    {
        return speaker;
    }

    public int GetCapacity()
    {
        return capacity;
    }

    // Override FullDetails method to include lecture-specific details
    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nSpeaker: {speaker}\nCapacity: {capacity}";
    }
}
