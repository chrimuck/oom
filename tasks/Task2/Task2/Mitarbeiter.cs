using System;

namespace Task2
{
	public class Mitarbeiter
	{
		
			// gehalt -> logischerweise private
			private decimal m_gehalt;

			// Vorname -> read only 
			public String Vorname { get; }

			// Nachname -> read + write (kann sich ändern)
			public String Nachname { get; set;}

			// Abteilung -> read + write (kann sich ändern)
			public String Abteilung { get; set;}

		public decimal Gehalt
		{
			get
			{
				return m_gehalt;
			}
			set
			{
				
			}
		}

		public Mitarbeiter (string newVorname, string newNachname, string newAbteilung, decimal newGehalt)
			{

			if (string.IsNullOrWhiteSpace(newVorname)) 
				throw new ArgumentException("Vorname muss angegeben werden", nameof(newVorname));
			if (string.IsNullOrWhiteSpace(newNachname)) 
				throw new ArgumentException("Nachname muss angegeben werden", nameof(newNachname));
			if (string.IsNullOrWhiteSpace(newAbteilung)) 
				throw new ArgumentException("Abteilung muss angegeben werden", nameof(Abteilung));
				Vorname = newVorname;
				Nachname = newNachname;
				Abteilung = newAbteilung;
			}

		public void AbteilungsWechsel (string newAbteilung)
		{
			Abteilung = newAbteilung;

		}



	}
}

