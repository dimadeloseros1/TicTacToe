using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Actions;
using Tic_Tac_Toe.Implementations;
using Tic_Tac_Toe.Interface;

namespace Tic_Tac_Toe.Workflow
{
    /// <summary>
    /// This is the workflow class which is encharge of orchestrating the application
    /// 
    /// </summary>
    public static class App
    {
        public static void Run()
        {
            GameManager gm;
            Console.WriteLine("Welcome to Tic-Tac-Toe!");
            do
            {
                char placeTheSymbol = ConsoleIO.ChooseOption("Choose Human or Computer (H/C): ") ? 'X' : 'O';

                Console.WriteLine("Here are the positions of the grid:");
                
                if (placeTheSymbol == 'X')
                {
                    gm = new GameManager(new PlayerNum());
                }
                else
                {
                    gm = new GameManager(new ComputerNum());
                }
                
                PlacementResult result;
                char symbol;
                do
                {
                    int num = ConsoleIO.ChoosePosition();   
                    result = gm.SymbolPlacement(num, placeTheSymbol);

                    placeTheSymbol = (placeTheSymbol == 'X') ? 'O' : 'X';

                } while (result != PlacementResult.XWins || result != PlacementResult.OWins);
            } while (ConsoleIO.PlayAgain());
        }
    }
}
