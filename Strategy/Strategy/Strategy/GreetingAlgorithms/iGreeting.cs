using System.Collections.Generic;

namespace Strategy.GreetingAlgorithms
{
    public interface IGreeting
    {
        IEnumerable<string> Execute(IEnumerable<string> inputList);
    }
}
