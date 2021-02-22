using System;
namespace Lab13
{
    public class RockPlayer:IPlayer
    {
        public RockPlayer()
        {

        }

        

        public string Name { get ; set; }
        public string Pick { get; set; }
      

       

        public string GenerateRPS()
        {
            throw new NotImplementedException();
        }
    }
}
