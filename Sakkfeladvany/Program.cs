namespace Sakkfeladvany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int oszlopokSzama = 0;
            int sorokSzama = 0;
            string input = "";
            bool err = true;

            while (err)
            {
				err = false;
				Console.WriteLine("7. feladat:");
				Console.Write("Adja meg a sakktábla oszlopainak számát: ");
                input = Console.ReadLine();
                if (!int.TryParse(input, out oszlopokSzama) || oszlopokSzama <= 0)
                {
					err = true;
					Console.WriteLine("Hibás adat, próbálja újra!");
				}

				Console.Write("Adja meg a sakktábla sorainak számát: ");
				input = Console.ReadLine();
				if (!int.TryParse(input, out sorokSzama) || sorokSzama <= 0)
				{
					err = true;
					Console.WriteLine("Hibás adat, próbálja újra!");
				}
			}

			Feladvany feladvany = new Feladvany(oszlopokSzama, sorokSzama, new int[oszlopokSzama, sorokSzama]);
            feladvany.MegoldasokKeresese(0);

			if (feladvany.MegoldasSorszama == 0)
			{
				Console.WriteLine("9. feladat:");
				Console.WriteLine("Nincs megoldás!");
			}
		}
    }
}
