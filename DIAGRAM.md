```mermaid

classDiagram
    class Character {
        +string Name
        +int AttackValue
        +int DefenseValue
        +int Health
        +Character(type, name, health, attackvalue, defensevalue)
        +ReceiveAttack(int power)
        +Cure(int points)
        +Attack(string name)
        +GetAttackValue()
        +GetDefenseValue()
    }

    class Wizard {
        +SpellsBook SpellsBook
        +Staff Staff
        +SetItem(Item Item)
        +DropItem(Item Item)
    }

    class Dwarf {
        +Axe Axe
        +Shield Shield
        +Helmet Helmet
        +Bow Bow
        +SetItem(Item Item)
        +DropItem(Item Item)
    }

    class Elve {
        +Sword Sword
        +Bow Bow
        +Armor Armor
        +Helmet Helmet
        +SetItem(Item Item)
        +DropItem(Item Item)
    }

    class SpellsBook {
        ICollection~Spell~ Spell
        +AddSpell(Spell spell)
    }

    class Staff {
    }

    class Spell {
    }

    class Axe {
    }

    class Shield {
    }

    class Helmet {
    }

    class Bow {
    }

    class Sword {
    }

    class Armor {
    }

    class Item {
        +string Name
        +int AttackValue
        +int DefenseValue
        +Item(type, name, attackvalue, defensevalue)
    }

    %% Herencia (Generalización)
    Character <|-- Wizard : es
    Character <|-- Dwarf : es
    Character <|-- Elve : es

    Axe --|> Item : es
    Shield --|> Item : es
    Helmet --|> Item : es
    Bow --|> Item : es
    Sword --|> Item : es
    Armor --|> Item : es
    Staff --|> Item : es
    SpellsBook --|> Item : es
    Spell --|> Item : es

    %% Asociaciones / Composiciones de Equipamiento
    Wizard --> SpellsBook
    Wizard --> Staff

    Dwarf --> Axe : tiene
    Dwarf --> Shield : tiene
    Dwarf --> Helmet : tiene
    Dwarf --> Bow : tiene

    Elve --> Sword :tiene
    Elve --> Bow : tiene
    Elve --> Armor : tiene
    Elve --> Helmet : tiene

    %% Relación entre SpellsBook y Spell
    SpellsBook "1" --> "*" Spell : contiene