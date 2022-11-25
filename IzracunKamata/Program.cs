double IzracunKamata(double glavnica, double stopa)
{
    if (stopa < 1 || stopa > 20)
        throw new ArgumentException("Stopa mora biti u rasponu 1-20");
    return glavnica * stopa / 100;
}

var nastavi = true;
do
{
	try
	{
		Console.Write("Glavnica: ");
		var unos = Console.ReadLine();
		if (string.IsNullOrEmpty(unos))
			nastavi = false;
		else
		{
			var ok = double.TryParse(unos, out double glavnica);
			if(!ok)
			{
				Console.WriteLine("Pogrešan format");
				continue;
			}
			Console.Write("Stopa (1-20): ");
			unos = Console.ReadLine();
			ok = double.TryParse(unos, out double stopa);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
			var kamata = IzracunKamata(glavnica, stopa);
			Console.WriteLine("Za glavnicu {0:N2} i stopu {1}% iznos kamata je {2:N2}",
				glavnica, stopa, kamata);
        }
	}
	catch (Exception ex)
	{
		Console.WriteLine("Pogreška. Tekst: {0}", ex.Message);
	}
} while (nastavi);
