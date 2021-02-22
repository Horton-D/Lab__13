using System;
namespace Lab_13
{
    public class RpsApp : IPlayer
    {
        public RpsApp()
        {
        }

        public string Name { get; set; }
        public string Pick { get; set; }
        public RPS PLayerCHoice { get; set; }
        public RPS ComputerChoice { get; set; }





        public string GenerateRPS()
        {
            throw new NotImplementedException();
        }
    }
}
