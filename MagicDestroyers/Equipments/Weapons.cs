using System;


namespace MagicDestroyers.Equipments.Weapons
{
    public class Sword
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
        private void Bloodthirst() { }
    }

    public class Axe
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
        private void HackNSlash() { }
    }

    public class Hammer
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
        private void Stun() { }
    }

    public class Staff
    {
        private int damage;
        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
        private void Empower() { }
    }
}
