using System;
namespace Lab_13
{
    public interface IPlayer
    {

        public string Name { get; set; }


        string GenerateRPS();
    }
}
