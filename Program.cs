//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.
//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

StreamReader addresses = File.OpenText("../../../addresses.csv");

List<Address> addressList = new List<Address>();

addresses.ReadLine();

while (!addresses.EndOfStream)
{
    string line = addresses.ReadLine();

    string[] split = line.Split(',');

    try
    {
        string name = split[0];
        string surname = split[1];
        string street = split[2];
        string city = split[3];
        string province = split[4];
        string zip = split[5];
        Address address = new Address(name, surname, street, city, province, zip);
        addressList.Add(address);
        Console.WriteLine(address);
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine("Invalid address --> " + line);
    }
}

addresses.Close();
