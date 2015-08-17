using System;
using System.Collections.Generic;
using Strategy.GreetingAlgorithms;

namespace Strategy
{
	public class Client
	{
	    private readonly IGreeting greetingStrategy;

	    public Client (IGreeting greetingStrategy)
	    {
	        this.greetingStrategy = greetingStrategy;
	    }

	    public IEnumerable<string> ProcessNames(IEnumerable<string> names) 
		{

			return greetingStrategy.Execute (names);
		}
	}
}
	