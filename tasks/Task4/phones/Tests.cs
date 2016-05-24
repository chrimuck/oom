using System;
using NUnit.Framework;

namespace phones
{
	
	public class Tests
	{
		[TestFixture]
		public class phoneTest
		{
			[Test]
			public void KannPhoneErstellen()
			{
				var a = new Phone ("Samsung", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");

				Assert.IsTrue (a.Simkarte == true);
			}


			// ein test der fehlschlägt
			[Test]
			public void KannPhoneErstellen2()
			{
				var a = new Phone ("Samsung", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");

				Assert.IsTrue (a.Simkarte == false);
			}
				
			[Test]
			public void HerstellerMussAngegebenWerden()
			{
				Assert.Catch(() => 
					{

						var a = new Phone (null, "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
					});

			}

			// schlägt auch fehl, weil alles richtig angegeben wurde
			[Test]
			public void HerstellerMussAngegebenWerden2()
			{
				Assert.Catch(() => 
				{
					
					var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				});

			}

			[Test]
			public void KannMieterUpdaten()
			{
				var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				a.MieterUpdate ("Herbert Mustermann");
				Assert.IsTrue (a.Mieter == "Herbert Mustermann");
			}

			[Test]
			public void KannMieterUpdaten2()
			{
				var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				a.MieterUpdate ("Herbert Mustermann");
				Assert.IsFalse (a.Mieter == "Max Mustermann");
			}


			// schlägt fehl, weil Abfrage ob alter noch richtig ist 
			[Test]
			public void KannMieterUpdaten3()
			{
				var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				a.MieterUpdate ("Herbert Mustermann");
				Assert.IsTrue (a.Mieter == "Max Mustermann");
			}

			[Test]
			public void AbteilungGeben()
			{
				var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				a.Abteilung = "IT";
				Assert.IsTrue (a.Abteilung == "IT");
			}

			// 0 bei Preis ist fehler
			[Test]
			public void PreisGroesserNull()
			{
				Assert.Catch(()=>
					{
					var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
					a.Preis = 0;
					});

			}

			// schlagt fehl, da die PreisUpdate Methode nicht kleinergleich 0 prüft
			[Test]
			public void PreisGroesserNull2()
			{
				Assert.Catch(()=>
					{
						var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
						a.PreisUpdate(0);
					});

			}



			[Test]
			public void SimUpdate()
			{
				var a = new Phone ("Apple", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann");
				a.SimUpdate (false);
				Assert.IsTrue (a.Simkarte == false);
			}






		}
	}
}

