using System;
using System.Collections.Generic;
using System.Linq;
using TheSlum.Interfaces;

namespace TheSlum
{
    public class Healer : Character, IHeal
    {
        private int healingPoints;

        private const int HealingPointsDefault = 60;
        private const int HealhtPointsDefault = 75;
        private const int DeffencePointsDefault = 50;
        private const int RangeDefault = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealhtPointsDefault, DeffencePointsDefault, team, RangeDefault)
        {
            this.HealingPoints = HealingPointsDefault;
        }
        public int HealingPoints
        {
            get
            {
                return this.healingPoints;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Healing points of Healer cannot be 0 or negative");
                }
                this.healingPoints = value;
            }
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var healerList = targetsList.OrderBy(x => x.HealthPoints);

            foreach (var character in healerList)
            {
                if (character.Team == this.Team && character.Id != this.Id && character.IsAlive)
                {
                    return character;
                }
            }
            return null;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            return base.ToString() + ", Healing: " + this.healingPoints;

        }
    }
}

