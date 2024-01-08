using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac_Toe.Interface;

namespace Tic_Tac_Toe.Workflow
{
    /// <summary>
    /// This class will contain the game logic, the heart of the application if you will.
    /// 1: We have to create a method that will place the symbols (X/O) on the board
    /// 2: We will create a method that will report the result of a player attempting to place a symbol
    /// 3: We will create a private field of a interface type.
    /// 4: We will create a constructor which will implement the interface inside of it
    /// </summary>
    public class GameManager
    {
        private char[] board = { ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ' };
        private IPlayer _player;

        public GameManager(IPlayer player)
        {
            _player = player;
        }

        public void DisplayBoard()
        {
            Console.WriteLine($"{board[0]} | {board[1]} | {board[2]}");
            Console.WriteLine("--+---+--");
            Console.WriteLine($"{board[3]} | {board[4]} | {board[5]}");
            Console.WriteLine("--+---+--"); 
            Console.WriteLine($"{board[6]} | {board[7]} | {board[8]}");
        }

        public PlacementResult SymbolPlacement(int position, char symbol)
        {
            if (position < 1 || position > 9 || board[position - 1] != ' ')
            {
                return PlacementResult.InvalidOffGrid;
            }

            if (board[position - 1] != ' ')
            {
                return PlacementResult.InvalidOverlap;
            }

            board[position - 1] = symbol;
            Console.WriteLine($"\n{symbol}, choose a position: {position}");
            DisplayBoard();


            if (CheckForWin(symbol))
            {
                DisplayBoard();
                Console.WriteLine($"{symbol} wins!");
                return symbol == 'X' ? PlacementResult.XWins : PlacementResult.OWins;
            }

            if (CheckForDraw())
            {
                Console.WriteLine("Game is a draw!");
                return PlacementResult.Draw;
            }

            return PlacementResult.SymbolPlaced;
        }

        public bool CheckForWin(char symbol)
        {
            // Checking for rows
            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == symbol && board[i + 1] == symbol && board[i + 2] == symbol)
                {
                    return true;
                }
            }

            // Checking for columns
            for (int i = 0; i < 3; i++)
            {
                if (board[i] == symbol && board[i + 3] == symbol && board[i + 6] == symbol)
                {
                    return true;
                }
            }

            // Checking diagonal lines
            if ((board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                (board[2] == symbol && board[4] == symbol && board[6] == symbol))
            {
                return true;
            }
            return false;
        }

        public bool CheckForDraw()
        {
            for (int i = 0; i < board.Length; i++)
            {
                if (board[i] == ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}
