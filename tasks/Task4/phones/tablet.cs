using System;

namespace phones
{
	public class Tablet:Device
	{
		public string Modell { get; }
		public string Mieter { get; set; } 



		public string Abteilung { get; set; }

		public Tablet ( string modell, string mieter ){
			Modell = modell;
			Mieter = mieter;
		
		}

		public string Typ => Modell;

	}
}

