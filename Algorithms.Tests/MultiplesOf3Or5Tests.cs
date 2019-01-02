using Algorithms.Solutions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Algorithms.Tests
{
	[TestClass]
	public class MultiplesOf3Or5Tests
	{
		[TestMethod]
		public void SupremumEqual10_SumShouldBe_23()
		{
			MultiplesOf3Or5 multiples = new MultiplesOf3Or5();

			var sum = multiples.GetSumOfMultiples3Or5(10);

			Assert.AreEqual(23, sum);
		}

		[TestMethod]
		public void SupremumEqual1000_SumShouldBe()
		{
			MultiplesOf3Or5 multiples = new MultiplesOf3Or5();

			var sum = multiples.GetSumOfMultiples3Or5(1000);

			Assert.AreEqual(233168, sum);
		}

		[TestMethod]
		public void v1_SupremumEqual10_SumShouldBe_23()
		{
			MultiplesOf3Or5 multiples = new MultiplesOf3Or5();

			var sum = multiples.GetSumOfMultiples3Or5_v1(10);

			Assert.AreEqual(23, sum);
		}

		[TestMethod]
		public void v1_SupremumEqual1000_SumShouldBe()
		{
			MultiplesOf3Or5 multiples = new MultiplesOf3Or5();

			var sum = multiples.GetSumOfMultiples3Or5_v1(1000);

			Assert.AreEqual(233168, sum);
		}
	}
}
