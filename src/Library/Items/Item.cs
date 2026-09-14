//--------------------------------------------------------------------------------
// <copyright file="Item.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------
namespace Library.Items
{
    /// <summary>
    /// Representa un elemento o equipamiento del juego.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase <see cref="Item"/>.
        /// </summary>
        /// <param name="type">El tipo de elemento.</param>
        /// <param name="name">El nombre del elemento.</param>
        /// <param name="attackValue">El valor de ataque.</param>
        /// <param name="defenseValue">El valor de defensa.</param>
        public Item(string type, string name, int attackValue, int defenseValue)
        {
            this.Type = type;
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
        }

        /// <summary>
        /// Obtiene o establece el tipo del elemento.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del elemento.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Obtiene o establece el valor de ataque del elemento.
        /// </summary>
        public int AttackValue { get; set; }

        /// <summary>
        /// Obtiene o establece el valor de defensa del elemento.
        /// </summary>
        public int DefenseValue { get; set; }
    }
}
