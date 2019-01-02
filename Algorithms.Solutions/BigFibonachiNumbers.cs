using System.Collections.Generic;

namespace Algorithms.Solutions
{
	public class BigFibonachiNumbers
	{
		//get Fibonachi numbers under some limit. Calculate the sum of even-valued Fibonachi numbers.

		public List<int> GetFibonachiSequence(int limit)
		{
			var fibonachiSequence = new List<int> { 1, 2 };

			int index = 1;
			int newValue = 3;

			while(newValue <= limit)
			{
				fibonachiSequence.Add(newValue);
				index++;
				newValue += fibonachiSequence[index - 1];
			}

			return fibonachiSequence;
		}

		public int GetEvenFibonachiNumbersSum(int limit)
		{
			int evenNumbersSum = 0;
			int previousValue = 1;
			int currentValue = 2;

			while (currentValue <= limit)
			{
				if(currentValue % 2 == 0)
				{
					evenNumbersSum += currentValue;
				}

				int val = currentValue;
				currentValue += previousValue;
				previousValue = val;
			}

			return evenNumbersSum;
		}
	}
}
