public class Address
{
    private string _Street;
    private string _City;
    private string _State;
    private string _Country;

    public Address(string street, string city, string state, string country)
    {
        _Street = street;
        _City = city;
        _State = state;
        _Country = country;
    }

    public bool IsUSA()
    {
        return _Country.Trim().ToLower() == "usa";
    }

    public string GetFullAddress()
    {
        return $"{_Street}\n{_City}, {_State}\n{_Country}";
    }
}