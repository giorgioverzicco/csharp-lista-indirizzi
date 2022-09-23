namespace csharp_lista_indirizzi;

public class Address
{
    public string Name { get; }
    public string Surname { get; }
    public string Street { get; }
    public string City { get; }
    public string Province { get; }
    public string Zip { get; }

    public Address(string name, string surname, string street, string city, string province, string zip)
    {
        Name = name;
        Surname = surname;
        Street = street;
        City = city;
        Province = province;
        Zip = zip;
    }

    public override string ToString()
    {
        return
            string.Format(
                "| {0, 15} | {1, 15} | {2, 40} | {3, 20} | {4, 12} | {5, 8} |",
                Name, Surname, Street, City, Province, Zip);
    }
}