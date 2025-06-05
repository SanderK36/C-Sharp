namespace IntroUnitTesting.Test
{
    public class StatsTest
    {

        [Test]
        public void TestWithTwoNumbers()
        {
            // Arrange
            var stats = new Stats();

            // Act
            stats.Add(3);
            stats.Add(4);

            // Assert
            Assert.AreEqual(2, stats.Count);
            Assert.AreEqual(7, stats.Sum);
            Assert.AreEqual(4, stats.Max);
            Assert.AreEqual(3, stats.Min);
            Assert.AreEqual(3.5, stats.Mean, 0.0001);
        }

        [Test]
        public void TestWithThreeNumbers()
        {
            // Arrange
            var stats = new Stats();

            // Act
            stats.Add(2);
            stats.Add(4);
            stats.Add(9);

            // Assert
            Assert.AreEqual(3, stats.Count);
            Assert.AreEqual(15, stats.Sum);
            Assert.AreEqual(9, stats.Max);
            Assert.AreEqual(2, stats.Min);
            Assert.AreEqual(5, stats.Mean, 0.0001);
        }

        [Test]
        public void TestEmptyStats()
        {
            // Arrange
            var stats = new Stats();

            // Act

            // Assert
            Assert.AreEqual(0, stats.Count);
            Assert.AreEqual(0, stats.Sum);
            Assert.IsNull(stats.Max);
            Assert.IsNull(stats.Min);
            Assert.AreEqual(float.NaN, stats.Mean);
       }


    }
}