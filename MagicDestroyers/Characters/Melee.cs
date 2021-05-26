using MagicDestroyers.Equipments.Armors;
using MagicDestroyers.Equipments.Weapons;
using System;

namespace MagicDestroyers.Characters.Melee
{
    public class Worrior
    {
        private int abilityPoint, healthPoints, level;
        private string faction, name;
        private Chainlink armor;
        private Axe weapon;
        public int AbilityPoint
        {
            get
            {
                return abilityPoint;
            }
            set
            {
                if (value <= 10 && value >= 0)
                {
                    abilityPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The Worrior cant have more than 10 or less than 0! ");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 10)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 10");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 1");
                }
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
/*              if (value == "melee" && value == "spellcaster") 
                {     
                */faction = value;/*
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "There's only melee and spellcasters"); 
                }*/
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Chainlink Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public Axe Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Worrior() : this("Worrior", 1) { }
        public Worrior(string name, int level) : this(name, level, 100) { }
        public Worrior(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "melee"; this.AbilityPoint = 10; this.Weapon = new Axe(); this.Armor = new Chainlink(); }
        private void Strike() { }
        private void Execute() { }
        private void SkinHarden() { }
    }

    public class Knight
    {
        private int abilityPoint, healthPoints, level;
        private string faction, name;
        private Chainlink armor;
        private Hammer weapon;
        public int AbilityPoint
        {
            get
            {
                return abilityPoint;
            }
            set
            {
                if (value <= 15 && value >= 0)
                {
                    abilityPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The Knight cant have more than 15 or less than 0!");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 10)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 10");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 1");
                }
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "melee" && value == "spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "There's only melee and spellcasters");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Chainlink Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public Hammer Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Knight() : this("Knight", 1) { }
        public Knight(string name, int level) : this(name, level, 100) { }
        public Knight(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "melee"; this.AbilityPoint = 20; this.Weapon = new Hammer(); this.Armor = new Chainlink(); }
        private void HolyBlow() { }
        private void PurifySoul() { }
        private void RighteousWings() { }
    }

    public class Assassin
    {
        private int abilityPoint, healthPoints, level;
        private string faction, name;
        private LightLeatherVest armor;
        private Sword weapon;
        public int AbilityPoint
        {
            get
            {
                return abilityPoint;
            }
            set
            {
                if (value <= 20 && value >= 0)
                {
                    abilityPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The Assassin cant have more than 20 or less than 0!");
                }
            }
        }
        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value >= 10)
                {
                    healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 10");
                }
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1)
                {
                    level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Must be at least 1");
                }
            }
        }
        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value == "melee" && value == "spellcaster")
                {
                    faction = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "There's only melee and spellcasters");
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public LightLeatherVest Armor
        {
            get
            {
                return armor;
            }
            set
            {
                armor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }
        public Assassin() : this("Assassin", 1) { }
        public Assassin(string name, int level) : this(name, level, 100) { }
        public Assassin(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "melee"; this.AbilityPoint = 20; this.Weapon = new Sword(); this.Armor = new LightLeatherVest(); }
        private void Raze() { }
        private void BleedToDeath() { }
        private void Survival() { }
    }
}
