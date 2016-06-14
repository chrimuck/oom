using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			decimal x = 7.28m;

			var mitarbeiter = new[]
			{
				new Mitarbeiter("Herbert", "Prohaska", "Fussball", 728.9m),
				new Mitarbeiter("Werner", "Faymann", "Politik", 22.3m),

			};

			foreach(var m in mitarbeiter)
			{

				Console.WriteLine($"Vorname={m.Vorname} | Nachname={m.Nachname} | Abteilung={m.Abteilung}");
			}

			mitarbeiter [1].AbteilungsWechsel ("Taxiunternehmen");

			foreach(var m in mitarbeiter)
			{

				Console.WriteLine($"Vorname={m.Vorname} | Nachname={m.Nachname} | Abteilung={m.Abteilung}");
			}



		}


	}
}
