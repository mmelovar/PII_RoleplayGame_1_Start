//--------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Characters
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

        int damage = power - GetDefenseValue();
        
        if (damage <= 0)
        {
            return;
        }

        Health -= damage;

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

    /// <summary>
    /// Realiza un ataque contra otro personaje objetivo.
    /// </summary>
    /// <param name="target">El personaje que recibirá el ataque.</param>
    public virtual void Attack(Character target)
        {
            if (target == null) 
            {
                ArgumentNullException.ThrowIfNull(target);
            }

            if (this.Health <= 0) 
            {
                return; // Un personaje derrotado no puede atacar
            }

            target.ReceiveAttack(this.GetAttackValue());
        }
    public abstract int GetAttackValue();
    public abstract int GetDefenseValue();
}
}