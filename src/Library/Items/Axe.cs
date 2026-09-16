//--------------------------------------------------------------------------------
// <copyright file="Axe.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace Library.Items
{
    /// <summary>
    /// Representa un hacha (Axe) que puede ser utilizada por los enanos.
    /// </summary>
    public class Axe : Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Axe"/>.
        /// </summary>
        /// <param name="name">El nombre del hacha.</param>
        /// <param name="attackValue">El valor de ataque del hacha.</param>
        /// <param name="defenseValue">El valor de defensa del hacha.</param>
        public Axe(string name, int attackValue, int defenseValue) : base("Axe", name, attackValue, defenseValue)
        {
        }
    }
}

