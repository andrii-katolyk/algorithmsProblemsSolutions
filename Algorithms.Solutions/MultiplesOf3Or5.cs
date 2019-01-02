namespace Algorithms.Solutions
{
	public class MultiplesOf3Or5
	{
		//get all multiples of 3 or 5 under some Supremum. after that calculate the Sum

		public long GetSumOfMultiples3Or5(int supremum)
		{
			long sum = 0;

			for (int i = 3; i < supremum; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					sum += i;
				}
			}

			return sum;
		}

		public long GetSumOfMultiples3Or5_v1(int supremum)
		{
			long sum = 0;

			for (int i = 3; i < supremum; i += 3)
			{
				if (i % 5 != 0)
				{
					sum += i;
				}
			}

			for (int i = 5; i < supremum; i += 5)
			{
				sum += i;
			}

			return sum;
		}
	}
}
