using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakkfeladvany
{
	internal class Feladvany
	{
		private int megoldasSorszama;
		private int oszlopokSzama;
		private int sorokSzama;
		private int[,] tabla;

		public Feladvany(int OszlopokSzama, int SorokSzama, int[,] Tabla)
		{
			megoldasSorszama = 0;
			oszlopokSzama = OszlopokSzama;
			sorokSzama = SorokSzama;
			tabla = Tabla;
		}

		public int MegoldasSorszama { get => megoldasSorszama; set => megoldasSorszama = value; }
		public int OszlopokSzama { get => oszlopokSzama; set => oszlopokSzama = value; }
		public int SorokSzama { get => sorokSzama; set => sorokSzama = value; }
		public int[,] Tabla { get => tabla; set => tabla = value; }

		public void tablaKiir()
		{
			Console.WriteLine($"Megoldas {megoldasSorszama}.:");
			for (int i = 0; i < sorokSzama; i++)
			{
				for (int j = 0; j < oszlopokSzama; j++)
				{
					Console.Write(tabla[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public bool EzJoMezo(int sor, int oszlop)
		{
			for (int i = 0; i < sorokSzama; i++)
			{
				if (tabla[i, oszlop] == 1)
				{
					return false;
				}
			}
			for (int i = sor, j = oszlop; i >= 0 && j >= 0; i--, j--)
			{
				if (tabla[i, j] == 1)
				{
					return false;
				}
			}
			for (int i = sor, j = oszlop; i >= 0 && j < oszlopokSzama; i--, j++)
			{
				if (tabla[i, j] == 1)
				{
					return false;
				}
			}
			return true;
		}

		public void MegoldasokKeresese(int kiralynoSora)
		{
			// Ezt a metódust nem kell módosítania!
			if (kiralynoSora == sorokSzama)
			{
				megoldasSorszama++;
				tablaKiir();
			}
			else
			{
				for (int aktOszlop = 0; aktOszlop < oszlopokSzama; aktOszlop++)
				{
					if (EzJoMezo(kiralynoSora, aktOszlop))
					{
						tabla[kiralynoSora, aktOszlop] = 1;
						MegoldasokKeresese(kiralynoSora + 1);
						tabla[kiralynoSora, aktOszlop] = 0;
					}
				}
			}
		}
	}
}
