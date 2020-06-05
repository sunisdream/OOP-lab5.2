using Lab05___2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Lab05___2___Test
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			List<Hour> hours = new List<Hour>();
			hours.Add(new Hour("Druzhby Narodiv", 2002, 793, "Kiev"));
			hours.Add(new Hour("Palats Sportu", 1992, 1475, "Center of Kiev"));
			hours.Add(new Hour("Arsenalna", 1989, 1284, "Also in Kiev"));
			hours.Add(new Hour("Poshtova Ploscha", 1997, 944, "Still some Kiev"));
			hours.Add(new Hour("Dnipro", 1979, 1537, "Some Kiev with Dnipro in it"));

			int sum = Hour.PassengersSum(ref hours);
			Hour leastHour = Hour.LeastPassengers(ref hours);
			Hour mostWordsHour = Hour.MostWordsInComment(ref hours);

			Assert.AreEqual(6033, sum);
			Assert.AreEqual(hours[0], leastHour);
			Assert.AreEqual(hours[4], mostWordsHour);
		}
	}
}
