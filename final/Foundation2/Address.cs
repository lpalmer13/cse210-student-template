public class Address
{
    private string streetAddress;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public string StreetAddress
    {
        get { return streetAddress; }
        set { streetAddress = value; }
    }

    public string City
    {
        get { return City; }
        set { streetAddress = value; }
    }

    public string StateOrPorvince
    {
        get { return stateOrProvince; }
        set { stateOrProvince = value; }
    }

    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public bool IsInUSA()
    {
        return country.ToUpper() == "USA";
    }

    public string GetAddressString()
    {
        return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}";
    }
}