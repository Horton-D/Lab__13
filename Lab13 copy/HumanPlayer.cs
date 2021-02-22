using System;
namespace Lab13
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public string Pick { get; set; }



        public HumanPlayer()

        {

        }

        public HumanPlayer(string name, string pick)
        {
            Name = name;
            Pick = pick;
        }
         
       

    public string GenerateRPS()
        {
           

            return $"{Name} :{Pick }";
        }
    }
}
