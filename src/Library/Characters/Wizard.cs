//--------------------------------------------------------------------------------
// <copyright file="Wizard.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using Library.Items;

namespace Library.Characters
{
    /// <summary>
    /// Representa un personaje Mago (Wizard).
    /// Puede equipar un báculo (Staff) y un libro de hechizos (SpellsBook).
    /// </summary>
    public class Wizard : Character
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Wizard"/>.
        /// </summary>
        /// <param name="name">El nombre del mago.</param>
        /// <param name="health">La vida inicial del mago.</param>
        /// <param name="attackValue">El valor de ataque base del mago.</param>
        /// <param name="defenseValue">El valor de defensa base del mago.</param>
        public Wizard(string name, int health, int attackValue, int defenseValue)
            : base("Wizard", name, health, attackValue, defenseValue)
        {
        }

        /// <summary>
        /// Obtiene o establece el báculo mágico equipado.
        /// </summary>
        public Staff Staff { get; set; }

        /// <summary>
        /// Obtiene o establece el libro de hechizos equipado.
        /// </summary>
        public SpellsBook SpellsBook { get; set; }

        /// <summary>
        /// Equipa un elemento válido (Staff o SpellsBook).
        /// Suma el ataque y la defensa del elemento al mago.
        /// </summary>
        /// <param name="item">El elemento a equipar.</param>
        public virtual void SetItem(Item item)
        {
            if (item == null)
            {
                ArgumentNullException.ThrowIfNull(item);
            }

            if (item.Type != "Staff" && item.Type != "SpellsBook")
            {
                throw new ArgumentException("El mago solo puede equipar un 'Staff' o un 'SpellsBook'.", nameof(item));
            }

            Staff staff = item as Staff;
            if (staff != null)
            {
                this.Staff = staff;
            }

            SpellsBook spellsBook = item as SpellsBook;
            if (spellsBook != null)
            {
                this.SpellsBook = spellsBook;
            }

            this.AttackValue += item.AttackValue;
            this.DefenseValue += item.DefenseValue;
        }

        /// <summary>
        /// Alias de SetItem para mantener compatibilidad con la convención de Dwarf (GetItem).
        /// </summary>
        /// <param name="item">El elemento a equipar.</param>
        public virtual void GetItem(Item item)
        {
            this.SetItem(item);
        }

        /// <summary>
        /// Desequipa un elemento si está actualmente equipado y descuenta sus valores de ataque y defensa.
        /// </summary>
        /// <param name="item">El elemento a desequipar.</param>
        public virtual void DropItem(Item item)
        {
            if (item == null)
            {
                ArgumentNullException.ThrowIfNull(item);
            }

            if (this.Staff == item)
            {
                this.Staff = null;
                this.AttackValue -= item.AttackValue;
                this.DefenseValue -= item.DefenseValue;
            }
            else if (this.SpellsBook == item)
            {
                this.SpellsBook = null;
                this.AttackValue -= item.AttackValue;
                this.DefenseValue -= item.DefenseValue;
            }
        }
    }
}
