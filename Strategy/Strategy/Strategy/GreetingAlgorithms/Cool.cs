using System;
using System.Collections.Generic;
using System.Linq;
using Strategy.GreetingAlgorithms;

namespace Strategy.Algorithms
{
	public class Cool : IGreeting
	{
		public IEnumerable<string> Execute(IEnumerable<string> inputList)
		{
			return inputList.Select (item => string.Format("Hey yo {0},", item));
		}
	}
}

