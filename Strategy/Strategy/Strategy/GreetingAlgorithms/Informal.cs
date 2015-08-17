using System.Collections.Generic;
using System.Linq;
using Strategy.GreetingAlgorithms;

namespace Strategy.Algorithms
{
	public class Informal : IGreeting
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select(item => string.Format("Hi {0},", item));
		}
	}
}

