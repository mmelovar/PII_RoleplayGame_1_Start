using System;
namespace Library.Items
{
    public class Shield : Item
    {
        public Shield(string name, int attackValue, int defenseValue) : base("Shield", name, attackValue, defenseValue)
        {
        }
    }
}