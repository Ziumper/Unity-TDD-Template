using System;

namespace ThirdParty
{
    [Serializable] //it's serializable so it can be created inside editor if needed
    public class Calculator : ICalculator
    {
        IAdder _adder;

        //Include more interfaces ass parameters to
        //constructor so it contains more complex logic
        //to proivde calculations
        public Calculator(IAdder adder) { _adder = adder; }

        //Can be used by mono behaviour
        public Calculator()
        {
            _adder = new Adder(); //defualt implementation
        }

        public int Add(int a, int b)
        {
            return _adder.Add(a, b);
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

}
