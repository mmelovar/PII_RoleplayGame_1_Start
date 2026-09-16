using NUnit.Framework;
using Library.Characters;

namespace LibraryTests.Characters
{
   
    public class DwarfTest
    {
        private Dwarf _dwarf;

        [SetUp]
        public void SetUp()
        {
            _dwarf = new Dwarf("Alonso", 100, 10, 5);
        }

        [Test]
        public void DwarfHasCorrectName()
        {
            Assert.That(_dwarf.Name, Is.EqualTo("Alonso"));
        }

        [Test]
        public void DwarfHasCorrectHealth()
        {
            Assert.That(_dwarf.Health, Is.EqualTo(100));
        }

        [Test]
        public void DwarfHasCorrectAttackValue()
        {
            Assert.That(_dwarf.AttackValue, Is.EqualTo(10));
        }

        [Test]
        public void DwarfHasCorrectDefenseValue()
        {
            Assert.That(_dwarf.DefenseValue, Is.EqualTo(5));
        }

        [Test]
        public void DwarfTypeIsCorrect()
        {
            Assert.That(_dwarf.Type, Is.EqualTo("Dwarf"));
        }

        [Test]
        public void DwarfReceivesAttack_WhenAttacked_ReducesHealth()
        {
            _dwarf.ReceiveAttack(20);
            Assert.That(_dwarf.Health, Is.EqualTo(85));
        }

        [Test]
        public void DwarfReceivesItem_WhenItemReceived_IncreasesStats()
        {
            var axe = new Library.Items.Axe("Axe of Destiny", 5, 2);
            _dwarf.GetItem(axe);
            Assert.That(_dwarf.AttackValue, Is.EqualTo(15));
            Assert.That(_dwarf.DefenseValue, Is.EqualTo(7));
        }

        [Test]
        public void DwarfDropsItem_WhenItemDropped_DecreasesStats()
        {
            var axe = new Library.Items.Axe("Axe of Destiny", 5, 2);
            _dwarf.GetItem(axe);
            _dwarf.DropItem(axe);
            Assert.That(_dwarf.AttackValue, Is.EqualTo(10));
            Assert.That(_dwarf.DefenseValue, Is.EqualTo(5));
        }
    }
}