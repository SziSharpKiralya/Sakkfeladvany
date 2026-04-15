using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sakkfeladvany
{
	internal class Feladvany
	{
		private int MegoldasokSzama;
		private int OszlopokSzama;
		private int SorokSzama;
		private int[,] Tabla;

		public Feladvany(int oszlopokSzama, int sorokSzama, int[,] tabla)
		{
			MegoldasokSzama = 0;
			OszlopokSzama = oszlopokSzama;
			SorokSzama = sorokSzama;
			Tabla = tabla;
		}

		public int MegoldasokSzama1 { get => MegoldasokSzama; set => MegoldasokSzama = value; }
		public int OszlopokSzama1 { get => OszlopokSzama; set => OszlopokSzama = value; }
		public int SorokSzama1 { get => SorokSzama; set => SorokSzama = value; }
		public int[,] Tabla1 { get => Tabla; set => Tabla = value; }

		public void MegoldasokKeresese(int kiralynoSora)
		{
			// Ezt a metódust nem kell módosítania!
			if (kiralynoSora == SorokSzama)
			{
				MegoldasSorszama++;
				TablaKiir();
			}
			else
			{
				for (int aktOszlop = 0; aktOszlop < OszlopokSzama; aktOszlop++)
				{
					if (EzJoMezo(kiralynoSora, aktOszlop))
					{
						Tabla[kiralynoSora, aktOszlop] = 1;
						MegoldasokKeresese(kiralynoSora + 1);
						Tabla[kiralynoSora, aktOszlop] = 0;
					}
				}
			}
		}
	}
}
