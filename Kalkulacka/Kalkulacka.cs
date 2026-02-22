namespace Kalkulacka
{
    public class Calc
    {
        public int Secti(int a, int b)
        {
            return a + b;
        }
        public int Odectil(int a, int b)
        {
            return a - b;
        }

        public int Nasob(int a, int b)
        {
            return a * b;
        }

        public int Deleni(int a, int b)
        {            
            if (b == 0)
            {
                throw new DivideByZeroException("Nelze dělit nulou.");
            }
            return a / b;
        }
    }
}
