using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Interface;

namespace Tic_Tac_Toe.Implementations
{
    /// <summary>
    /// Computer implementatio will have a Random method that will return a number from 1 to 9.
    /// </summary>
    public class ComputerNum : IPlayer
    {
        public int ChooseYourNum { get; }
        private Random _rand = new Random();
        public int ChosenNum()
        {
            return _rand.Next(1, 10);
        }
    }
}
