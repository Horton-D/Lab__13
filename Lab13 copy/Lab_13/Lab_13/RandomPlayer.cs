using System;
namespace Lab_13
{
    public class RandomPlayer : IPlayer
    {
        public  RandomPlayer()
        {

        }
        
            public string Name { get; set; }
            public string Pick { get; set; }

           
            public string GenerateRPS()
            {

                var random = new Random();
                RPS randomEnum = (RPS)random.Next(1, 3);

                return $"{randomEnum}";
            }
        }
    }
