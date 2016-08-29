using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Astor = () => Behav()
    .Init("Astor",
                new State(
                    new State("circle",
                        new Prioritize(
                            new StayAbove(0.4, 60),
                            new Follow(4, 11, 3.5, 1000, 5000),
                            new Orbit(1.9, 3.5, 12),
                            new Wander(0.4)
                            ),
                        new Shoot(4, predictive: 0.1, coolDown: 500),
                        new TimedTransition(3000, "dart_away")
                        ),
                    new State("dart_away",
                        new Prioritize(
                            new StayAbove(0.4, 60),
                            new StayBack(2, 5),
                            new Wander(0.4)
                            ),
                        new Shoot(25, projectileIndex: 0, count: 20, shootAngle: 20, coolDown: 2000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 1, count: 6, predictive: 0.2, shootAngle: 15, coolDown: 1550, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 2, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1550, coolDownOffset: 1350),
                        new TimedTransition(1600, "circle")
                    )
                ),
                new Threshold(0.05,
                new TierLoot(10, ItemType.Weapon, 0.22),
                new TierLoot(11, ItemType.Weapon, 0.05),
                new TierLoot(11, ItemType.Armor, 0.22),
                new TierLoot(12, ItemType.Armor, 0.12),
                new TierLoot(13, ItemType.Armor, 0.02),
                new TierLoot(5, ItemType.Ring, 0.1),
                new TierLoot(5, ItemType.Ability, 0.21)
                ),
                new Threshold(0.01,
                new ItemLoot("Falling Star Sword", 0.004),
                new ItemLoot("Stardust Helm", 0.001),
                new ItemLoot("Constellation Armor", 0.008),
                new ItemLoot("Comet Ring", 0.07)
            )
        );
    }
}