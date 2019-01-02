using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithms.Solutions;

namespace Algorithms.Tests
{
	[TestClass]
	public class FibonachiTests
	{
		[TestMethod]
		public void Sequence_GetElementsBelow_100()
		{
			BigFibonachiNumbers fibonachi = new BigFibonachiNumbers();
			var sequence = fibonachi.GetFibonachiSequence(100);
			Assert.IsTrue(sequence.Count == 10);
		}

		[TestMethod]
		public void Sum_GetSumOfEvenElementsBelow_100()
		{
			BigFibonachiNumbers fibonachi = new BigFibonachiNumbers();
			var sum = fibonachi.GetEvenFibonachiNumbersSum(100);
			Assert.AreEqual(44, sum);
		}

		[TestMethod]
		public void Sum_GetSumOfEvenElementsBelow_4000000()
		{
			BigFibonachiNumbers fibonachi = new BigFibonachiNumbers();
			var sum = fibonachi.GetEvenFibonachiNumbersSum(4000000);
			Assert.AreEqual(4613732, sum);
		}
	}
}
