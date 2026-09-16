//--------------------------------------------------------------------------------
// <copyright file="Character.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje base en el juego de rol.
    /// Contiene las características y comportamientos comunes a todos los personajes.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Character"/>.
        /// </summary>
        /// <param name="type">El tipo o raza del personaje.</param>
        /// <param name="name">El nombre del personaje.</param>
        /// <param name="health">La vida del personaje.</param>
        /// <param name="attackValue">El valor de ataque del personaje.</param>
        /// <param name="defenseValue">El valor de defensa del personaje.</param>
        public Character(string type, string name, int health, int attackValue, int defenseValue)
        {
            this.Type = type;
            this.Name = name;
            this.Health = health;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }

        /// <summary>
        /// Obtiene o establece el tipo o raza del personaje.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del personaje.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el valor de ataque del personaje.
        /// </summary>
        public int AttackValue { get; set; }

        /// <summary>
        /// Obtiene o establece el valor de defensa del personaje.
        /// </summary>
        public int DefenseValue { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad de vida del personaje.
        /// </summary>
        public int Health { get; set; }

        /// <summary>
        /// Recibe un ataque y disminuye la vida del personaje en la cantidad indicada.
        /// </summary>
        /// <param name="power">La cantidad de daño a recibir.</param>
        public virtual void ReceiveAttack(int power)
        {
            Health -= power;
        }

        /// <summary>
        /// Cura al personaje aumentando su vida en la cantidad indicada.
        /// </summary>
        /// <param name="points">La cantidad de puntos de vida a recuperar.</param>
        public virtual void Cure(int points)
        {
            Health += points;
        }

        /// <summary>
        /// Realiza un ataque contra otro personaje objetivo.
        /// </summary>
        /// <param name="target">El personaje que recibirá el ataque.</param>
        public virtual void Attack(Character target)
        {
            if (target == null) ArgumentNullException.ThrowIfNull(target);

            if (this.Health <= 0) return; // Un personaje derrotado no puede atacar

            int attackPower = this.GetAttackValue();
            target.ReceiveAttack(attackPower);
        }

        /// <summary>
        /// Obtiene el valor de ataque del personaje.
        /// </summary>
        /// <returns>El valor de ataque.</returns>
        public virtual int GetAttackValue()
        {
            return AttackValue;
        }

        /// <summary>
        /// Obtiene el valor de defensa del personaje.
        /// </summary>
        /// <returns>El valor de defensa.</returns>
        public virtual int GetDefenseValue()
        {
            return DefenseValue;
        }
    }
}