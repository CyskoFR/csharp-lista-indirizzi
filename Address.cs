public class Address
{
    public string Name;
    public string Surname;
    public string Street;
    public string City;
    public string Province;
    public int Zip;
    public Address(string name, string surname, string street, string city, string province, int zip)
    {
        this.Name = name;
        this.Surname = surname;
        this.Street = street;
        this.City = city;
        this.Province = province;
        this.Zip = zip;
    }
    public override string ToString()
    {
        string line = "";
        line += "Name:\t" + this.Name + "\n";
        line += "Surname:\t" + this.Surname + "\n";
        line += "Street:\t" + this.Street + "\n";
        line += "City:\t" + this.City + "\n";
        line += "Province:\t" + this.Province + "\n";
        line += "ZIP:\t" + this.Zip + "\n";
        line += "-------------------";

        return line;
    }
}