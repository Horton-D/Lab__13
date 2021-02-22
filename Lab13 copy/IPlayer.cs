using System;
namespace Lab13
{
    public interface IPlayer
    {

        
        public string Name { get; set; }
        

        string GenerateRPS();
    }
}
