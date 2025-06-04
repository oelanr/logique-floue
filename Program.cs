using System.Threading.Tasks.Dataflow;

namespace logiquefloue
{
    class Program
    {
        static void Main(string[] args)
        {
            FuzzySet froid = new FuzzySet(0, 10, 20);
            FuzzySet moyen = new FuzzySet(15, 25, 35);
            FuzzySet chaud = new FuzzySet(30, 40, 50);

            Console.Write("Entrer température : ");
            string input = Console.ReadLine();
            double temperature = double.Parse(input);

            double degFroid = froid.Membership(temperature);
            double degMoyen = moyen.Membership(temperature);
            double degChaud = chaud.Membership(temperature);

            
            Console.WriteLine($"Température : {temperature}°C");
            Console.WriteLine($"Degré Froid : {degFroid}");
            Console.WriteLine($"Degré Moyen : {degMoyen}");
            Console.WriteLine($"Degré Chaud : {degChaud}");
        }
    }
}