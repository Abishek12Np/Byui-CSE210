public class Address
{
    private string street;
    private string city;
    private string state;
    private string zipcode;

    public Address(string street, string city, string state, string zipcode)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.zipcode = zipcode;
    }

    // Override ToString() to provide formatted address string
    public override string ToString()
    {
        return $"{street}, {city}, {state} {zipcode}";
    }
}