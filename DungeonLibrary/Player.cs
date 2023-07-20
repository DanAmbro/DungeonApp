using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public sealed class Player : Character
    {
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public int Score { get; set; }
        
        public Player(string name, int hitChance, int block, int life, int maxLife, Race playerRace, Weapon equippedWeapon) : base(name, hitChance, block, maxLife, life) 
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;
        
        }

        private static string GetRaceDesc(Race race)
        {
            switch (race)
            {
                case Race.Human:
                    return "Human";
                case Race.Nautolan:
                    return "Nautolan";
                case Race.Mustafarian:
                    return "Mustafarian";
                case Race.Wookie:
                    return "Wookie";
                case Race.Zabrak:
                    return "Zabrak";
                case Race.Cyborg:
                    return "Cyborg";
                default:
                    return "";
            }
        }//end getRaceDesc()
        public override string ToString()
        {
            return base.ToString() + $"\nWeapon: \n{EquippedWeapon}\n" +
                $"Description: \n{GetRaceDesc(PlayerRace)}";
        }

        //CalcDamage() override -> return a random number between the EquippedWeapon's MinDamage and MaxDamage properties.
        public override int CalcDamage()
        {
            //throw new NotImplementedException();
            Random rand = new Random();
            //.Next() 0 to int.MaxValue
            //.Next(int value) 0 to value - 1
            //.Next(int value1, int value2) value1 to value2 - 1
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //Upper bound is exclusive, so we add 1 to the max damage.
            return damage;
        }
        //CalcHitChance() override -> return the HitChance + EquippedWeapon's BonusHitChance property.
        public override int CalcHitChance()
        {
            int chance = HitChance + EquippedWeapon.BonusHitChance;
            return chance;
        }
    }
}
