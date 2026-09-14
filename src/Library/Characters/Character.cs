namespace Ucu.Poo.RolePlayGame
{
public abstract class Character
{
    // Atributos / Propiedades públicas (+ en UML)
    public string Name { get; protected set; }
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set;}
    public int BaseAttack { get; protected set; }
    public int BaseDefense { get; protected set; }

    // Constructor que exige la firma del UML
    protected Character(string name, int health, int baseAttack, int baseDefense)
    {
        Name = name;
        MaxHealth = health;
        Health = health;
        BaseAttack = baseAttack;
        BaseDefense = baseDefense;
    }

    public void ReceiveAttack(int power)
    {
        if (power <= 0)
        {
            return;
        }

        Health -= power;

        if (Health < 0)
        {
            Health = 0;
        }
    }
    public void Cure(int points)
    {
        if (points <= 0)
        {
            return;
        }

        if (Health + points >= MaxHealth)
        {
            Health = MaxHealth;
            return;
        }

        Health += points;
    }

    public virtual void Attack(string name)
    {
        // Lógica para atacar a un objetivo por nombre
    }
    public abstract int GetAttackValue();
    public abstract int GetDefenseValue();
}
}