using System;
namespace Lab13
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Pick { get; set; }

        public RandomPlayer(string name)
        {
            Name = name;
        }

        public string GenerateRPS()
        {

            var random = new Random();
            RPS randomEnum = (RPS)random.Next(1, 3);

            return $"{randomEnum}";
        }
    }
}
