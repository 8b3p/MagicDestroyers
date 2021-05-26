using System;


namespace MagicDestroyers.Equipments.Armors
{
    public class Chainlink
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }

    }

    public class LightLeatherVest
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
    }

    public class ClothRobe
    {
        private int armorPoints;
        public int ArmorPoints
        {
            get
            {
                return armorPoints;
            }
            set
            {
                if (value >= 1)
                {
                    armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "It has to be at least 1!");
                }
            }
        }
    }
}
