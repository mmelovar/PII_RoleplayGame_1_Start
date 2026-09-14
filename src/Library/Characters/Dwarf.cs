using System;

namespace Library.Characters
{
    public class Dwarf : Character
    {
        public Dwarf(string name, int health, int attackValue, int defenseValue)
            : base("Dwarf", name, health, attackValue, defenseValue)
        {
        }

        public virtual void GetItem(Items.Item item)
        {
            if (item == null) ArgumentNullException.ThrowIfNull(item);
            if (item.Type != "Shield" && item.Type != "Axe" && item.Type != "Helmet" && item.Type != "Bow")
            {
                throw new ArgumentException("El item debe ser de tipo 'Shield', 'Axe', 'Helmet' o 'Bow'.");
            }

            this.AttackValue += item.AttackValue;
            this.DefenseValue += item.DefenseValue;
        }
        public virtual void DropItem(Items.Item item)
        {
            if (item == null) ArgumentNullException.ThrowIfNull(item);

            this.AttackValue -= item.AttackValue;
            this.DefenseValue -= item.DefenseValue;
        }

    }
}