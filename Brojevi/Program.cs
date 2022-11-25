﻿var nastavi = true;
do
{
	try
	{
		Console.Write("Unesite broj elemenata (1-100): ");
		var unos = Console.ReadLine();
		if (string.IsNullOrEmpty(unos))
			nastavi = false;
		else
		{
			var ok = int.TryParse(unos, out int brojElemenata);
            if (!ok)
            {
                Console.WriteLine("Pogrešan format");
                continue;
            }
			if(brojElemenata < 1 || brojElemenata > 100)
			{
				Console.WriteLine("Broj je izvan raspona");
				continue;
			}
			int[] brojevi = new int[brojElemenata];
			var i = 0;
			while (i< brojElemenata)
			{
				Console.Write("Element {0}: ", i + 1);
				unos = Console.ReadLine();
				ok = int.TryParse(unos, out brojevi[i]);
				if(!ok)
				{
					Console.WriteLine("Pogrešan format");
					continue;
				}
				i++;
			}
			Console.Write("Unijeli ste polje: ");
			foreach (var broj in brojevi)
			{
				Console.Write("{0} ", broj);
			}
			Console.WriteLine();
			var suma = 0;
			var najmanji = brojevi[0];
			var najveci = brojevi[0];
			foreach (var broj in brojevi)
			{
				suma += broj;
				if (broj < najmanji)
					najmanji = broj;
				if (broj > najveci)
					najveci = broj;
			}
			var prosjek = suma * 1.0 / brojElemenata;
			Console.WriteLine("Suma elemenata je {0}", suma);
			Console.WriteLine("Prosjek elemenata je {0:N2}", prosjek);
			Console.WriteLine("Najmanji element polja je {0}", najmanji);
			Console.WriteLine("Najveći element polja je {0}", najveci);

			//Izračun upotrebom extension funkcija
			suma = brojevi.Sum();
			najmanji = brojevi.Min();
			najveci = brojevi.Max();
			prosjek = brojevi.Average();
			Console.WriteLine("Izračun upotrebom extension funkcija");
            Console.WriteLine("Suma elemenata je {0}", suma);
            Console.WriteLine("Prosjek elemenata je {0:N2}", prosjek);
            Console.WriteLine("Najmanji element polja je {0}", najmanji);
            Console.WriteLine("Najveći element polja je {0}", najveci);

        }
	}
	catch (Exception)
	{

	}
} while (nastavi);
