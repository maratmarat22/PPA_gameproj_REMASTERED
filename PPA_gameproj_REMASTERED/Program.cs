using PPA_gameproj_REMASTERED.factories;

namespace PPA_gameproj_REMASTERED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var humanUnitFactory = new HumanUnitFactory();
            var infantryman = humanUnitFactory.CreateInfantryman();
            Console.WriteLine(infantryman.ToString());
        }
    }
}
