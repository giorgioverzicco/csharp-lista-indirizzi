using csharp_lista_indirizzi;

List<Address> addresses = new();

string currentDir = Directory.GetCurrentDirectory();
StreamReader? addressesFile = null;
bool skipLine = false;

try
{
    addressesFile = File.OpenText(currentDir + @"\addresses.csv");
    addressesFile.ReadLine(); // skip table headers

    for (int i = 0; !addressesFile.EndOfStream; i++)
    {
        if (skipLine) continue; // skip wrong rows

        string line = addressesFile.ReadLine()!;
        string[] wordsInLine = line.Split(",");

        var name = wordsInLine[0];
        var surname = wordsInLine[1];
        var street = wordsInLine[2];
        var city = wordsInLine[3];
        var province = wordsInLine[4];
        var zip = wordsInLine[5];

        addresses.Add(
            new Address(name, surname, street, city, province, zip));

        skipLine = false;
    }
}
catch (IndexOutOfRangeException)
{
    skipLine = true;
}
finally
{
    addressesFile?.Close();
}

addresses.ForEach(Console.WriteLine);