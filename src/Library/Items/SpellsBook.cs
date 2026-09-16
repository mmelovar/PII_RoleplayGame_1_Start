//--------------------------------------------------------------------------------
// <copyright file="SpellsBook.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Library.Items
{
    /// <summary>
    /// Representa un libro de hechizos que almacena una lista de hechizos.
    /// Su poder de ataque y defensa se calcula a partir de los hechizos que contiene (Patrón Expert).
    /// </summary>
    public class SpellsBook : Item
    {
        private List<Spell> spells = new List<Spell>();

        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="SpellsBook"/>.
        /// </summary>
        /// <param name="name">El nombre del libro de hechizos.</param>
        public SpellsBook(string name)
            : base("SpellsBook", name, 0, 0)
        {
        }

        /// <summary>
        /// Obtiene la lista de hechizos contenidos en el libro.
        /// </summary>
        public List<Spell> Spells
        {
            get
            {
                return this.spells;
            }
        }

        /// <summary>
        /// Agrega un hechizo al libro de hechizos y suma su ataque y defensa al libro.
        /// </summary>
        /// <param name="spell">El hechizo a agregar.</param>
        public void AddSpell(Spell spell)
        {
            if (spell == null)
            {
                ArgumentNullException.ThrowIfNull(spell);
            }

            this.spells.Add(spell);
            this.AttackValue += spell.AttackValue;
            this.DefenseValue += spell.DefenseValue;
        }

        /// <summary>
        /// Remueve un hechizo del libro de hechizos y resta su ataque y defensa del libro.
        /// </summary>
        /// <param name="spell">El hechizo a remover.</param>
        public void RemoveSpell(Spell spell)
        {
            if (spell == null)
            {
                ArgumentNullException.ThrowIfNull(spell);
            }

            if (this.spells.Remove(spell))
            {
                this.AttackValue -= spell.AttackValue;
                this.DefenseValue -= spell.DefenseValue;
            }
        }
    }
}
