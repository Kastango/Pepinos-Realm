using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ StrangeGod = () => Behav()
            .Init("Urgle God",
                new State(
                    new Prioritize(
                        new StayCloseToSpawn(0.8, 3),
                        new Wander(0.5)
                        ),
                        new Shoot(8.4, count: 1, projectileIndex: 0, shootAngle: 10, coolDown: 1400),
                    new State("idle",
                        new PlayerWithinTransition(10.5, "toss_horizontal_traps")
                        ),
                    new State("toss_horizontal_traps",
                        new Shoot(8.4, count: 40, projectileIndex: 2, shootAngle: 10, coolDown: 100),
                        new TossObject("Left Horizontal Trap", 9, 230, 100000),
                        new TossObject("Left Horizontal Trap", 10, 180, 100000),
                        new TossObject("Left Horizontal Trap", 9, 140, 100000),
                        new Shoot(8.4, count: 6, projectileIndex: 1, shootAngle: 10, coolDown: 100),
                        new TimedTransition(800, "toss_vertical_traps")
                        ),
                    new State("toss_vertical_traps",
                        new TossObject("Top Vertical Trap", 8, 200, 100000),
                        new TossObject("Top Vertical Trap", 10, 240, 100000),
                        new TossObject("Top Vertical Trap", 10, 280, 100000),
                        new TossObject("Top Vertical Trap", 8, 320, 100000),
                        new Shoot(8.4, count: 6, projectileIndex: 1, shootAngle: 10, coolDown: 100),
                        new TimedTransition(800, "toss_diagonal_traps")
                        ),
                    new State("toss_diagonal_traps",
                        new TossObject("45-225 Diagonal Trap", 2, 45, 100000),
                        new TossObject("45-225 Diagonal Trap", 7, 45, 100000),
                        new TossObject("45-225 Diagonal Trap", 11, 225, 100000),
                        new TossObject("45-225 Diagonal Trap", 6, 225, 100000),
                        new TossObject("135-315 Diagonal Trap", 2, 135, 100000),
                        new TossObject("135-315 Diagonal Trap", 7, 135, 100000),
                        new TossObject("135-315 Diagonal Trap", 11, 315, 100000),
                        new TossObject("135-315 Diagonal Trap", 6, 315, 100000),
                        new Shoot(8.4, count: 8, projectileIndex: 1, shootAngle: 15, coolDown: 100),
                        new TimedTransition(600, "wait")
                        ),
                    new State("wait",
                        new TimedTransition(1000, "idle")
                        )
                    ),
                new Threshold(0.01,
                new TierLoot(10, ItemType.Weapon, 0.6),
                new TierLoot(11, ItemType.Weapon, 0.1),
                new TierLoot(11, ItemType.Armor, 0.5),
                new TierLoot(12, ItemType.Armor, 0.2),
                new TierLoot(5, ItemType.Ring, 0.3),
                new TierLoot(5, ItemType.Ability, 0.4),
                new ItemLoot("Potion of Defense", 0.4),
                new ItemLoot("Potion of Wisdom", 0.5),
                new ItemLoot("Potion of Speed", 0.5),
                new ItemLoot("Potion of Mana", 0.1)
                ),
                new Threshold(0.05,
                new ItemLoot("Enervation Bow", 0.004),
                new ItemLoot("Urgle Trap", 0.01),
                new ItemLoot("Austere Armor", 0.0086),
                new ItemLoot("Urgal Amulet", 0.05)
            )
        );
    }
}