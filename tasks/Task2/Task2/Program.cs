using System;

namespace Task2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var mitarbeiter = new[]
			{
				new Mitarbeiter("Herbert", "Prohaska", "Fussball"),
				new Mitarbeiter("Werner", "Faymann", "Politik"),

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
