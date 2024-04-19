```mermaid 

classDiagram
    class Character {
        - Weapon[] weapons
        + string Name
        + void Fight()
    }

    class Enemy {
        + Enemy(name: string)
    }

    class Player {
        + Player(name: string)
    }

    class Weapon {
        - float power
        + Weapon(power: float)
    }

  