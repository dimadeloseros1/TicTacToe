using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Actions;
using Tic_Tac_Toe.Interface;

namespace Tic_Tac_Toe.Implementations
{
    /// <summary>
    /// This implementation will prompt the user to choose one of the numbers on the board
    /// </summary>
    public class PlayerNum : IPlayer
    {
        public int ChooseYourNum { get; set; }
        public int ChosenNum()
        {
            ChooseYourNum = ConsoleIO.ChoosePosition();
            return ChooseYourNum;
        }

    }
}
