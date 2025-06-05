using Unittesting_Kalkulator_Oppgave;
using NUnit.Framework;
namespace KalkulatorTest
{
    public class Tests
    {
        [Test]
        public void LeggSammen()
        {
            var kalkulator = new Kalkulator();
            int a = 5;
            int b = 3;

            int sum = kalkulator.LeggSammen(a, b);
            Assert.That(sum, Is.EqualTo(8));
        }

        [Test]
        public void LeggSammenNegativeTall()
        {
            var kalkulator = new Kalkulator();
            int sum = kalkulator.LeggSammen(-2, -3);
            Assert.That(sum, Is.EqualTo(-5));
        }

        [Test]
        public void TrekkFra()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.TrekkFra(5, 3);
            Assert.That(resultat, Is.EqualTo(2));
        }

        [Test]
        public void TrekkFraNegativeTall()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.TrekkFra(-2, -3);
            Assert.That(resultat, Is.EqualTo(1));
        }

        [Test]
        public void Multipliser()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.Multipliser(5, 3);
            Assert.That(resultat, Is.EqualTo(15));
        }

        [Test]
        public void MultipliserMedNull()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.Multipliser(5, 0);
            Assert.That(resultat, Is.EqualTo(0));
        }

        [Test]
        public void Divider()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.Divider(6, 2);
            Assert.That(resultat, Is.EqualTo(3));
        }

        [Test]
        public void DividerNegativeTall()
        {
            var kalkulator = new Kalkulator();
            int resultat = kalkulator.Divider(-6, -2);
            Assert.That(resultat, Is.EqualTo(3));
        }

        [Test]
        public void DividerMedNull()
        {
            var kalkulator = new Kalkulator();
            Assert.Throws<ArgumentException>(() => kalkulator.Divider(10, 0), "Cannot divide by zero");
        }
    }
}