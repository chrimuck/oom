using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

namespace phones
{
	public class Async
	{
		public bool istFertig { get; set;}

		public async void kurz (){
			istFertig = false;
			Console.WriteLine ("kurzer Prozess wurde gestartet");
			await lang ();
			Console.WriteLine ("kurzer Prozess wurde erfolgreich beendet");
			istFertig = true;

		}

		// async kann nicht überladen werden; im hintergrund als klasse angelegt; auf await setzen damit asynchron
		public  Task lang(){
			return Task.Run (() => {
				
				Console.WriteLine ("langer Prozess arbeitet");
				Thread.Sleep (2000);
			});
		}



	
}
}
