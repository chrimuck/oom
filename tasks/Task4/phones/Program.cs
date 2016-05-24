﻿using System;
using System.Linq;
using System.IO;
using Newtonsoft.Json;

namespace phones
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// LESSON 2 
			// Erstellen von Array
			var phones = new[] {
				new Phone ("Samsung", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann"),
				new Phone ("Apple", "A32325-3", "Iphone 6 Plus", 899.99m, false, " "),
				new Phone ("Windows", "I12325-3", "Surface", 399.99m, true, "Max Mustermann")
			};
				


			// ganzes Array ausgeben
			foreach (var x in phones) {
				Console.WriteLine ("Hersteller: {0} || Gerät: {1} || Simkarte: {2} || Mieter: {3}", x.Hersteller, x.Modell, x.Simkarte, x.Mieter);
			}

			// Update Methode aufgerufen
			phones[0].MieterUpdate (" ");

			// ausgeben, um Änderungen zu sehen
			foreach (var x in phones) {
				Console.WriteLine ("Hersteller: {0} || Gerät: {1} || Simkarte: {2} || Mieter: {3}", x.Hersteller, x.Modell, x.Simkarte, x.Mieter);
			}

			// Update Methode aufgerufen
			phones [2].SimUpdate (false);

			// ausgeben, um Änderungen zu sehen
			foreach (var x in phones) {
				Console.WriteLine ("Hersteller: {0} || Gerät: {1} || Simkarte: {2} || Mieter: {3}", x.Hersteller, x.Modell, x.Simkarte, x.Mieter);
			}

			// LESSON 3
			// devices ist interface/schnittstelle -> vererbt an Phone und Tablet Klasse
			var devices = new Device[] {
				new Phone ("Motorola", "a23", "Moto G 2nd Gen", 179.99m, true, " "),
				new Tablet ("Ipad Pro", "IT Operations")
			};

			// somit kann Phone und Tabletklassen zusammen angesprochen werden
			foreach (var x in devices) {
				Console.WriteLine ("Geräte:" + x.Typ);
			
			}
				

			// LESSON 4

			// Json Convert mit schöner Formatierung + Testausgabe
			string write = JsonConvert.SerializeObject (phones, Formatting.Indented);
			Console.WriteLine ("---read from json object---");
			Console.WriteLine(write);

			// Pfad definieren, und anschließend oben erzeugtes in Json-Datei auf Desktop schreiben
			var path = Directory.GetCurrentDirectory();
			// ergibt pfad Task4/phones/bin/Debug
			path = Path.Combine (path, "test.json");
			File.WriteAllText (path, write);


			// Readfile
			string readFile = File.ReadAllText (path);

			// andere Richtung -> von dem readFile lesen und dann zb die Hersteller listen
			var output = JsonConvert.DeserializeObject<Phone[]>(readFile);
			Console.WriteLine ("---read hersteller from file---");
			foreach (var x in output) {
				Console.WriteLine (x.Hersteller);
			}

			// oder wieder alles listen - also quasi json file 1 zu 1 ausgeben
			var read = JsonConvert.DeserializeObject (readFile);
			Console.WriteLine ("---read from file---");
			Console.WriteLine(read);

				
		}
	}
}
