using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Ozone = () => Behav()
    .Init("Ozone",
                new State(
                      new Wander(0.5),
                    new Charge(2.0, 10f, 4000),
                    new Shoot(25, projectileIndex: 0, count: 30, shootAngle: 10, coolDown: 1000, coolDownOffset: 3000),
                    new Shoot(25, projectileIndex: 1, count: 3, predictive: 0.1, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 2, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1450, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 3, count: 2, predictive: 0.2, shootAngle: 5, coolDown: 1550, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 2, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1650, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 1, count: 5, predictive: 0.2, shootAngle: 15, coolDown: 1750, coolDownOffset: 1350),
                    new Grenade(9, 80, 8, coolDown: 3000)
                ),
                new MostDamagers(3,
                    new ItemLoot("Potion of Attack", 2),
                    new ItemLoot("Potion of Wisdom", 1)
                ),
                new Threshold(0.05,
                new TierLoot(11, ItemType.Weapon, 0.1),
                new TierLoot(12, ItemType.Armor, 0.12),
                new TierLoot(5, ItemType.Ring, 0.2),
                new TierLoot(5, ItemType.Ability, 0.21)
                ),
                new Threshold(0.01,
                new ItemLoot("Dragon Hunter Bow", 0.01),
                new ItemLoot("Aerial Trap", 0.1),
                new ItemLoot("Cloud Armor", 0.06),
                new ItemLoot("Ring of Storms", 0.06)
                )
          );
    }
}