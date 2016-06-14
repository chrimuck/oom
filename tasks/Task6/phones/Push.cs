using System;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;


namespace phones
{
	public static class Push
	{
		public static void Run ()
		{
			var producer = new Subject<Phone>();

			producer
				.Where(x => x.Hersteller == "Samsung")
				.Subscribe(x => 
					{
						Console.WriteLine("subscribed - Hersteller = {0}", x.Hersteller);

					});
		

			var t = new Thread(() =>
				{
					var i = 0;
					while(i<100){
						Thread.Sleep(250);	
						var x = new[] {
							new Phone ("Samsung", "I12325-3", "Galaxy Ace 2", 99.99m, true, "Max Mustermann"),
							new Phone ("Apple", "A32325-3", "Iphone 6 Plus", 899.99m, false, " "),
							new Phone ("Windows", "I12325-3", "Surface", 399.99m, true, "Max Mustermann")
						};
						foreach (var y in x){
						producer.OnNext(y);
						Console.WriteLine("produced - Hersteller = {0}", y.Hersteller);
						}
						i++;
					}
				});
			t.Start();

		}
	}
}

