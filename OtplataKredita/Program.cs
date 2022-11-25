void IzracunParametara(double iznos, double stopa, int brojGodina, 
    out double anuitet, out double iznosKamata)
{
    if (iznos < 0 || stopa < 0 || brojGodina < 0)
        throw new ArgumentException("Parametri moraju biti veći jednaki 0");
    var r = Kamatnjak(stopa);
    var n = brojGodina * 12;
    anuitet = iznos * Math.Pow(r,n) * (r - 1) / (Math.Pow(r,n) - 1);
    iznosKamata = n * anuitet - iznos;
}

double Kamatnjak(double stopa)
{
    return 1 + stopa / 100 / 12;
}

var nastavi = true;
do
{
    try
    {
        Console.Write("Iznos kredita: ");
        var unos = Console.ReadLine();
        if (string.IsNullOrEmpty(unos))
            nastavi = false;
        else
        {
            var ok = double.TryParse(unos, out double glavnica);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Stopa: ");
            unos = Console.ReadLine();
            ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            Console.Write("Broj godina: ");
            unos = Console.ReadLine();
            ok = int.TryParse(unos, out int brojGodina);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
            IzracunParametara(glavnica, stopa, brojGodina,
                out double anuitet, out double iznosKamata);
            Console.WriteLine(
             "Za glavnicu {0:N2}, stopu {1}% i broj godina {2} iznos anuiteta je {3:N2}" +
             " a ukupno plaćena kamata je {4:N2}",
                glavnica, stopa, brojGodina, anuitet, iznosKamata);
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Pogreška. Tekst: {0}", ex.Message);
    }
} while (nastavi);

