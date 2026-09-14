using System;
namespace Library.Characters
{
    public class Character
    {
        public Character(string type, string name, int health, int attackValue, int defenseValue)
        {
            this.Type = type;
            this.Name = name;
            this.Health = health;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }
    public string Type { get; set; }
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int Health { get; set; }
    public virtual void ReceiveAttack(int power)
    {
        Health -= power;
    }
    public virtual void Cure(int points)
    {
        Health += points;
    }
    public virtual void Attack(Character target)
    {
        if (target == null) ArgumentNullException.ThrowIfNull(target);

        if (this.Health <= 0) return; // Un personaje derrotado no puede atacar

        int attackPower = this.GetAttackValue();
        target.ReceiveAttack(attackPower);
    }
    public virtual int GetAttackValue()
    {
        return AttackValue;
    }
    public virtual int GetDefenseValue()
    {
        return DefenseValue;
    }
}
}