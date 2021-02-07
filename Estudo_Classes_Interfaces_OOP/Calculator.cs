using System.Linq;

namespace Estudo_Classes_Interfaces_OOP
{
	public class Calculator
	{
		public int Add(params int[] numbers)
		{
			/*
			var sum = 0;
			foreach (var number in numbers)
			{
				sum += number;
			}
			*/
			var sum = numbers.Sum(x => x);
			return sum;
		}
	}
}
