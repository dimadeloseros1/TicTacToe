using NUnit.Framework;
using NUnit.Framework.Legacy;
using Tic_Tac_Toe.Implementations;
using Tic_Tac_Toe.Workflow;

namespace Tic_Tac_Toe.Tests
{
    [TestFixture]
    public class GameTests
    {
        public static GameManager Manager()
        {
            return new GameManager(new PlayerNum());
            
        }

        [Test]
        public void CheckingTrue()
        {
            GameManager manager = Manager();
            var result = manager.SymbolPlacement(1, 'X');

            ClassicAssert.AreEqual(PlacementResult.SymbolPlaced, result);
        }

        [Test]
        public void CheckingIfOfGrid()
        {
            GameManager manager = Manager();
            var result = manager.SymbolPlacement(11, 'O');

            ClassicAssert.AreEqual(PlacementResult.InvalidOffGrid, result);
        }

        [Test]
        public void CheckingOverlap()
        {
            GameManager managing = Manager();
            var result = managing.SymbolPlacement(8, ' ');

            ClassicAssert.IsNotNull(result);
        }
    }
}