namespace ThirdParty
{
    /// <summary>
    /// Custom implementation of IAdder interface for sake of demonstration in
    /// composition
    /// </summary>
    public class MultiplyFirstBBy5Adder : IAdder
    {
        /// <summary>
        /// This method is returning a+b , but first it's multiplay b value by 5
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b * 5;
        }
    }

}
