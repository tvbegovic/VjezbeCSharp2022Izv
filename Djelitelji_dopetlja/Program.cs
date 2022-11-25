﻿var nastavi = true;
do
{
    Console.Write("Unesi N (1-100.000): ");
    var unos = Console.ReadLine();
    if(string.IsNullOrEmpty(unos))
        nastavi = false;
    else
    {
        var ok = int.TryParse(unos, out int n);
        if (!ok)
        {
            Console.WriteLine("Pogrešan format");
            continue;
        }
        if (n < 1 || n > 100000)
        {
            Console.WriteLine("Broj je izvan raspona");
            continue;
        }
        long suma = 0;
        for (int i = 1; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                suma += i;
            }
        }
        Console.WriteLine("Suma brojeva od 1 do {0} djeljivih sa 3 ili 5 je {1:N0}", n, suma);
    }
} while (nastavi);
