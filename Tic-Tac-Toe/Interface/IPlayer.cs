using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe.Interface
{
    public interface IPlayer
    {
        int ChooseYourNum { get; }
        int ChosenNum();
    }
}
