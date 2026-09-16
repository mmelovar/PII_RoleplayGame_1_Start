using NUnit.Framework;
using Library.Items;

namespace LibraryTests.Items
{
   
    public class AxeTest
    {
        private Axe _axe;

        [SetUp]
        public void SetUp()
        {
            _axe = new Axe("Hyper_X", 10, 5);
        }

        [Test]
        public void AxeHasCorrectName()
        {
            Assert.That(_axe.Name, Is.EqualTo("Hyper_X"));
        }

        [Test]
        public void AxeHasCorrectAttackValue()
        {
            Assert.That(_axe.AttackValue, Is.EqualTo(10));
        }

        [Test]
        public void AxeHasCorrectDefenseValue()
        {
            Assert.That(_axe.DefenseValue, Is.EqualTo(5));
        }
    }
}