Console.Write("Ime: ");
var ime = Console.ReadLine();
if(string.IsNullOrEmpty(ime))
{
    Console.WriteLine("Ime mora biti uneseno");
    return;
}
Console.Write("Prezime: ");
var prezime = Console.ReadLine();
if(string.IsNullOrEmpty(prezime))
{
    Console.WriteLine("Prezime mora biti uneseno");
    return;
}
Console.WriteLine("Vaši inicijali su {0}. {1}.", ime.Substring(0,1), 
    prezime.Substring(0,1));
