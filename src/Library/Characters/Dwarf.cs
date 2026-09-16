//--------------------------------------------------------------------------------
// <copyright file="Dwarf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Characters

{
     /// <summary>
    /// Representa un personaje de tipo Enano (Dwarf).
    /// </summary>
    public class Dwarf : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Dwarf"/>.
        /// </summary>
        /// <param name="name">El nombre del enano.</param>
        /// <param name="health">La vida del enano.</param>
        /// <param name="attackValue">El valor de ataque base del enano.</param>
        /// <param name="defenseValue">El valor de defensa base del enano.</param>
        public Dwarf(string name, int health, int attackValue, int defenseValue)
            : base("Dwarf", name, health, attackValue, defenseValue)
        {
        }
        
        /// <summary>
        /// Equipa un elemento válido para el enano (Shield, Axe, Helmet o Bow) y suma sus atributos.
        /// </summary>
        /// <param name="item">El elemento a equipar.</param>
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

        /// <summary>
        /// Desequipa un elemento y resta sus atributos del enano.
        /// </summary>
        /// <param name="item">El elemento a desequipar.</param>
        public virtual void DropItem(Items.Item item)
        {
            if (item == null) ArgumentNullException.ThrowIfNull(item);

            this.AttackValue -= item.AttackValue;
            this.DefenseValue -= item.DefenseValue;
        }

    }
}