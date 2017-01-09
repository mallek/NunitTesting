namespace NunitTesting
{
    public class SimpleCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            //bug here for demo
            return a * b;
        }
    }
}
