using MagicDestroyers.Equipments.Armors;
using MagicDestroyers.Equipments.Weapons;
using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        private int abilityPoint, healthPoints, level;
        private string faction, name;
        private ClothRobe armor;
        private Staff weapon;
        public int AbilityPoint
        {
            get
            {
                return abilityPoint;
            }
            set
            {
                if (value <= 13 && value >= 0)
                {
                    abilityPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The Mage cant have more than 13 or less than 0!");
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
        public ClothRobe Armor
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
        public Staff Weapon
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
        public Mage() : this("Mage", 1) { }
        public Mage(string name, int level) : this(name, level, 100) { }
        public Mage(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "spellcaster"; this.AbilityPoint = 20; this.Weapon = new Staff(); this.Armor = new ClothRobe(); }
        private void ArcaneWrath() { }
        private void Firewall() { }
        private void Meditation() { }
    }

    public class Necromancer
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
                if (value <= 15 && value >= 0)
                {
                    abilityPoint = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The Necromancer cant have more than 15 or less than 0!");
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
        public Necromancer() : this("Necromancer", 1) { }
        public Necromancer(string name, int level) : this(name, level, 100) { }
        public Necromancer(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "spellcaster"; this.AbilityPoint = 20; this.Weapon = new Sword(); this.Armor = new LightLeatherVest(); }
        private void ShadowRage() { }
        private void VampireTouch() { }
        private void BoneShield() { }
    }

    public class Druid
    {
        private int abilityPoint, healthPoints, level;
        private string faction, name;
        private LightLeatherVest armor;
        private Staff weapon;
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
                    throw new ArgumentOutOfRangeException(string.Empty, "The Druid cant have more than 20 or less than 0!");
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
        public Staff Weapon
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
        public Druid() : this("Druid", 1) { }
        public Druid(string name, int level) : this(name, level, 100) { }
        public Druid(string name, int level, int healthPoints)
        { this.Name = name; this.Level = level; this.HealthPoints = healthPoints; this.Faction = "spellcaster"; this.AbilityPoint = 20; this.Weapon = new Staff(); this.Armor = new LightLeatherVest(); }
        private void Moonfire() { }
        private void Starburst() { }
        private void OneWithTheNature() { }
    }
}
