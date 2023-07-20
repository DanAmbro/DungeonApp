using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character
    {
        private int _minDamage;

        public int MaxDamage { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage can't exceed Max and can't be less than 1
                _minDamage = (value > 0 && value < MaxDamage) ? value : 1;
            }
        }

        public string Description { get; set; }
        
        public Monster(string name, int hitChance, int block, int maxLife, int life, int maxDamage, int minDamage, string description)
            : base(name, hitChance, block, maxLife, life)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Monster()
        {
            //added so we can create "default" monster subtypes
            //Name = "Baby Goblin"
            //HitChance = 15
            //Goblin babyGoblin = new Goblin()
        }

        public override string ToString()
        {
            return $"*********** MONSTER ***********\n" +
                $"{base.ToString()}\n" +
                $"Damage: {MinDamage} - {MaxDamage}\n" +
                $"Description: {Description}";
        }

        public override int CalcDamage()
        {
            //throw new NotImplementedException();
            return new Random().Next(MinDamage, MaxDamage + 1);//+1 because it's exclusive
        }

        public static Monster GetMonster()
        {
            //TODO Come back to replace these monsters with your own monster subtypes later.
            Tribble t1 = new Tribble();
            Tribble t2 = new Tribble("Tribble", "Found on Station K-7, Watch out for over-multiplying", 25, 25, 70, 0, 5, 5, true);
            ConduitWorm c1 = new ConduitWorm();
            ConduitWorm c2 = new ConduitWorm("Conduit Worm", "They are a problem on Coruscant", 35, 35, 50, 10, 5, 10, 10, 10);
            StoneMite s1 = new StoneMite();
            StoneMite s2 = new StoneMite("Stone Mite", "They eat metal, not stone", 35, 35, 75, 0, 5, 15, true);
            Mynock m1 = new Mynock();
            Mynock m2 = new Mynock("Mynock", "Han Solo hated these things.", 25, 25, 50, 5, 10, 15, false);
            Fyrnock f1 = new Fyrnock();
            Fyrnock f2 = new Fyrnock("Fyrnock", "They hide in the shadows", 40, 40, 55, 15, 5, 10, 15, 10);

            //Add the Monsters to a Collection:
            Monster[] monsters =
            {
                    t1,
                    t2, t2, t2, t2, t2, t2, t2, t2,
                    c1,
                    c2, c2, c2, c2, c2, c2, c2,
                    s1,
                    s2, s2, s2, s2, s2,
                    m1,
                    m2, m2,m2,
                    f1,
                    f2, f2, f2,
                };

            Random rand = new Random();
            int index = rand.Next(monsters.Length);
            Monster monster = monsters[index];
            return monster;

            //return monsters[new Random().Next(monsters.Count)];
        }
    }
}
