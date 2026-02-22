namespace Kalkulacka
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calc kalkulacka = new Calc();
            Console.WriteLine("Soucet :" + kalkulacka.Secti(4, 5));
            Console.WriteLine("Rozdil :" + kalkulacka.Odectil(4, 5));
        }
    }
}


