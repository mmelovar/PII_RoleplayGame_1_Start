namespace Ucu.Poo.RolePlayGame
{
public class Character
{
    // Atributos / Propiedades públicas (+ en UML)
    public string Name { get; set; }
    public int AttackValue { get; set; }
    public int DefenseValue { get; set; }
    public int Health { get; set; }

    // Constructor que exige la firma del UML
    public Character(string type, string name, int health, int attackValue, int defenseValue)
    {
        Name = name;
        Health = health;
        AttackValue = attackValue;
        DefenseValue = defenseValue;
    }

    public virtual void ReceiveAttack(int power)
    {
        Health -= power;
    }

    public virtual void Cure(int points)
    {
        Health += points;
    }

    public virtual void Attack(string name)
    {
        // Lógica para atacar a un objetivo por nombre
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