using System;

namespace phones
{
	public class Phone : Device
	{


		// preis/wert -> privates feld
		private decimal m_preis;
		private string abteilung;



		// constructor 
		public Phone (string hersteller, string seriennummer, string modell, decimal preis, bool simkarte, string mieter)
		{
			if (string.IsNullOrWhiteSpace (hersteller))
				throw new ArgumentException ("Hersteller muss angegeben werden");
			if (string.IsNullOrWhiteSpace (seriennummer))
				throw new ArgumentException ("Seriennummer muss angegebn werden");

			Hersteller = hersteller;
			Seriennummer = seriennummer;
			Modell = modell;
			m_preis = preis;
			Simkarte = simkarte;
			if (string.IsNullOrWhiteSpace (mieter))  {
				Mieter = "*frei*";
			} else {
				Mieter = mieter;
			}


		

		}

		// Hersteller des Phones
		public string Hersteller { get; }

		// Seriennummer des Phones
		public string Seriennummer { get; }

		// Modell des Phones
		public string Modell { get; }

		// Wert des Phones
		public decimal Preis { 
			get{
				return m_preis;
			}
			set{
				if (value <= 0) {
					throw new ArgumentException ("Preis muss größer 0 sein");
				} else {
					m_preis = value;
				}
			}

		}

		// Simkarte -> ja/nein? Testgeräte benötigen keine SIM
		public bool Simkarte { get; set; }

		// Mitarbeiter, der das Phone gerade ausgeborgt hat - wenn keiner, dann NULL? XXXX
		public string Mieter { get; set; }



		// aktualisiert den Preis/Wert
		public void PreisUpdate(decimal new_Preis)
		{
			m_preis = new_Preis;
			
		}

		// aktualisiert den Mieter
		public void MieterUpdate(string new_mieter)
		{
			Mieter = new_mieter;
		}

		// aktualisiert Bool Sim (kann dazu gekauft werden -> bzw. SIM für anderes Phone verwendet
		public void SimUpdate(bool simkarte)
		{
			Simkarte = simkarte;
		}


		// Zusatz zur Schnittstelle / Interface -> kann nicht geschrieben werden
		public string Typ => Modell;

		// Welcher Abteilung gehört das Phone? -> R/W
		public string Abteilung {
			get {
				return abteilung;
			}
			set{
				abteilung = value;
			}	

		}
	}
}

