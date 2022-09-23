//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

public class Address
{
    public string Name;
    public string Surname;
    public string Street;
    public string City;
    public string Province;
    public string Zip;
    public Address(string name, string surname, string street, string city, string province, string zip)
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
