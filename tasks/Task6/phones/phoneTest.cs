using NUnit.Framework;
using System;

namespace phones
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
	}
}

