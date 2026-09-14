namespace Ucu.Poo.RolePlayGame
{
public class Elf : Character
{
    public Sword Sword { get; protected set; }
    public Bow Bow { get; protected set; }
    public Armor Armor { get; protected set; }
    public Helmet Helmet { get; protected set; }

    public Elf(string name, int health, int baseAttack, int baseDefense)
        : base(name, health, baseAttack, baseDefense)
    {
    }

    public override int GetAttackValue()
    {
        int total = BaseAttack;

        if (Sword != null)
        {
            total += Sword.AttackValue;
        }

        if (Bow != null)
        {
            total += Bow.AttackValue;
        }

        return total;
    }

    public override int GetDefenseValue()
    {
        int total = BaseDefense;

        if (Armor != null)
        {
            total += Armor.DefenseValue;
        }

        if (Helmet != null)
        {
            total += Helmet.DefenseValue;
        }

        return total;
    }
}
}