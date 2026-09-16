//--------------------------------------------------------------------------------
// <copyright file="Dwarf.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
using System;
using Library.Items;

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
        /// <param name="baseAttack">El valor de ataque base del enano.</param>
        /// <param name="baseDefense">El valor de defensa base del enano.</param>
        public Dwarf(string name, int health, int baseAttack, int baseDefense)
            : base(name, health, baseAttack, baseDefense)
        {
        }
        
        
        public Axe Axe { get; protected set; }
        public Shield Shield { get; protected set; }
        public Bow Bow { get; protected set; }
        public Helmet Helmet { get; protected set; }

        
        public override int GetAttackValue()
        {
            int total = BaseAttack;

            if (Axe != null)
            {
                total += Axe.AttackValue;
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

            if (Shield != null)
            {
                total += Shield.DefenseValue;
            }

            if (Helmet != null)
            {
                total += Helmet.DefenseValue;
            }

            return total;
        }

        public void EquipAxe(Axe axe)
        {
            if (axe == null)
            {
                throw new ArgumentNullException(nameof(axe), "El hacha no puede ser nula.");
            }
            Axe = axe;
        }

        public void EquipShield(Shield shield)
        {
            if (shield == null)
            {
                throw new ArgumentNullException(nameof(shield), "El escudo no puede ser nulo.");
            }
            Shield = shield;
        }

        public void EquipBow(Bow bow)
        {
            if (bow == null)
            {
                throw new ArgumentNullException(nameof(bow), "El arco no puede ser nulo.");
            }
            Bow = bow;
        } 

        public void EquipHelmet(Helmet helmet)
        {
            if (helmet == null)
            {
                throw new ArgumentNullException(nameof(helmet), "El casco no puede ser nulo.");
            }
            Helmet = helmet;
        }

        public void UnequipAxe()
        {
            Axe = null;
        }
        public void UnequipShield()
        {
            Shield = null;
        }
        public void UnequipBow()
        {
            Bow = null;
        }
        public void UnequipHelmet()
        {
            Helmet = null;
        }
}
}