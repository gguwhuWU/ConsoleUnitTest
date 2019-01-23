namespace ConsoleUnitTest
{
    public class Service : IService
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Multiply(int x, int y)
        {
            return x * y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divided(int x, int y)
        {
            return x / y;
        }

        public double Divided(double x, double y)
        {
            return x / y;
        }

        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
