using StigeSpilletTDD.Console;

namespace StigeSpilletTDD.Test
{
    public class GameTest
    {
        [Test]
        public void TestStartAt0()
        {
            var game = new Game(4);
            var position = game.GetPlayerPositions(0);
            Assert.AreEqual(0, position);
        }

        [Test]
        public void TestInitialMove()
        {
            var game = new Game(4);
            game.Move(0, 4);
            var position = game.GetPlayerPositions(0);
            Assert.AreEqual(4, position);
        }

        [Test]
        public void TestMultiplePlayerPosition()
        {
            var game = new Game(2);
            game.Move(0, 3);
            game.Move(1, 4);
            Assert.AreEqual(3, game.GetPlayerPositions(0));
            Assert.AreEqual(4, game.GetPlayerPositions(1));
        }

        [TestCase(1, 40)]
        [TestCase(36, 52)]
        [TestCase(24, 5)]
        public void TestLadder(int posFrom, int posTo)
        {
            var game = new Game(1);
            game.Move(0, posFrom);
            Assert.AreEqual(posTo, game.GetPlayerPositions(0));
        }

        [Test]

        public void TestDiceMax6()
        {
            var game = new Game(1);
            game.Move(0, 7);
            Assert.AreEqual(0, game.GetPlayerPositions(0));
        }

        [Test]

        public void TestNotWinning()
        {
            var game = new Game(1);
            game.Move(0, 2);
            var winner = game.GetWinner();
            Assert.IsNull(winner);
        }

        [Test]

        public void TestWinning()
        {
            var game = new Game(1);
            game.Move(0, 1);
            game.Move(0, 3);
            game.Move(0, 3);
            game.Move(0, 6);
            game.Move(0, 2);
            var winner = game.GetWinner();
            Assert.AreEqual(0, winner);
        }
    }
}