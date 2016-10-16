using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;
using wServer.realm;
using wServer.realm.entities;
using wServer.realm.entities.player;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Witch = () => Behav()
        .Init("Swamp Witch",
                new State("Attacks",
                    new State("Taunts",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new State("Idle",
                        new PlayerWithinTransition(10, "Taunt1")
                    ),
                    new State("Taunt1",
                        new Taunt("Nham, Nham, Nham, we have visitors"),
                        new TimedTransition(3000, "Taunt2")
                    ),
                    new State("Taunt2",
                        new Taunt("Now it's COOKING time!"),
                        new TimedTransition(3000, "Attack1")
                    )
                ),
                    new State("Attack1",
                        new HpLessTransition(0.66, "Attack2"),
                        new HpLessTransition(0.33, "Attack3"),
                        new State("Quadforce1",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 0, coolDown: 200),
                            new TimedTransition(200, "Quadforce2")
                            ),
                        new State("Quadforce2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 5, coolDown: 200),
                            new TimedTransition(200, "Quadforce3")
                            ),
                        new State("Quadforce3",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 10, coolDown: 200),
                            new TimedTransition(200, "Quadforce4")
                            ),
                        new State("Quadforce4",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 15, coolDown: 200),
                            new TimedTransition(200, "Quadforce5")
                            ),
                        new State("Quadforce5",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, projectileIndex: 2, coolDown: 1000),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 20, coolDown: 200),
                            new TimedTransition(200, "Quadforce6")
                            ),
                        new State("Quadforce6",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 25, coolDown: 200),
                            new TimedTransition(200, "Quadforce7")
                            ),
                        new State("Quadforce7",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 30, coolDown: 200),
                            new TimedTransition(200, "Quadforce8")
                            ),
                        new State("Quadforce8",
                            new Shoot(10, projectileIndex: 3, coolDown: 1000),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 35, coolDown: 200),
                            new TimedTransition(200, "Quadforce9")
                            ),
                        new State("Quadforce9",
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 40, coolDown: 200),
                            new TimedTransition(200, "Quadforce10")
                            ),
                        new State("Quadforce10",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, projectileIndex: 2, coolDown: 1000),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 45, coolDown: 200),
                            new TimedTransition(200, "Quadforce11")
                            ),
                        new State("Quadforce11",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 50, coolDown: 200),
                            new TimedTransition(200, "Quadforce12")
                            ),
                        new State("Quadforce12",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 55, coolDown: 200),
                            new TimedTransition(200, "Quadforce13")
                            ),
                        new State("Quadforce13",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 60, coolDown: 200),
                            new TimedTransition(200, "Quadforce14")
                            ),
                        new State("Quadforce14",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 65, coolDown: 200),
                            new TimedTransition(200, "Quadforce15")
                            ),
                        new State("Quadforce15",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, projectileIndex: 2, coolDown: 1000),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 70, coolDown: 200),
                            new TimedTransition(200, "Quadforce16")
                            ),
                        new State("Quadforce16",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 75, coolDown: 200),
                            new TimedTransition(200, "Quadforce17")
                            ),
                        new State("Quadforce17",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 80, coolDown: 200),
                            new TimedTransition(200, "Quadforce18")
                            ),
                        new State("Quadforce18",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 85, coolDown: 200),
                            new TimedTransition(200, "Quadforce19")
                            ),
                        new State("Quadforce19",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 95, coolDown: 200),
                            new TimedTransition(200, "Quadforce20")
                            ),
                        new State("Quadforce20",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Shoot(10, projectileIndex: 2, coolDown: 1000),
                            new Shoot(0, projectileIndex: 0, count: 8, shootAngle: 45, fixedAngle: 100, coolDown: 200),
                            new TimedTransition(200, "Quadforce1")
                            )
                        ),
                new State("Attack2",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                        new TossObject("Cauldron", 4, 0, coolDown: 9999999, randomToss: false),
                        new TossObject("Cauldron", 4, 90, coolDown: 9999999, randomToss: false),
                        new TossObject("Cauldron", 4, 180, coolDown: 9999999, randomToss: false),
                        new TossObject("Cauldron", 4, 270, coolDown: 9999999, randomToss: false),
                        new TimedTransition(2100, "checkforcauldrons")
                        ),
                    new State("checkforcauldrons",
                        new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                       new EntitiesNotExistsTransition(9999, "Attack3", "Cauldron")
                        ),
                new State("Attack3",
                    new Taunt("See my worst poison!"),
                    new Charge(2, 10f, 3000),
                    new Shoot(25, projectileIndex: 1, count: 3, predictive: 0.1, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 2, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1450, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 2, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1550, coolDownOffset: 1350),
                    new Shoot(25, projectileIndex: 1, count: 5, predictive: 0.2, shootAngle: 15, coolDown: 1650, coolDownOffset: 1350)
                             )
                ),
                new MostDamagers(2,
                new ItemLoot("Potion of Speed", 2),
                new Threshold(0.2,
                new ItemLoot("Potion of Mana", 0.2),
                new TierLoot(12, ItemType.Weapon, 0.08),
                new TierLoot(12, ItemType.Armor, 0.15),
                new TierLoot(13, ItemType.Armor, 0.10),
                new TierLoot(5, ItemType.Ring, 0.2),
                new TierLoot(5, ItemType.Ability, 0.4),
                new TierLoot(6, ItemType.Ability, 0.1)
                ),
                new Threshold(0.5,
                new ItemLoot("Staff of the Maleficient Paragon", 0.055),
                new ItemLoot("Skull of the Blightcaster", 0.07),
                new ItemLoot("Robe of Putrefaction", 0.07),
                new ItemLoot("Ring of Decay", 0.08)
                  )
                 )
                
            )
                .Init("Cauldron",
                new State(
                    new State("PROTECT!",
                        new Orbit(0.3, 3, 20, "Swamp Witch"),
                        new Shoot(8.4, count: 3, projectileIndex: 0, shootAngle: 10, coolDown: 100)
                        )
                    ),
                    new Threshold(0.05,
                    new ItemLoot("Potion of Speed", 0.008),
                    new TierLoot(12, ItemType.Weapon, 0.0007),
                    new TierLoot(12, ItemType.Armor, 0.0017),
                    new TierLoot(13, ItemType.Armor, 0.0007),
                    new TierLoot(5, ItemType.Ring, 0.0027),
                    new TierLoot(5, ItemType.Ability, 0.0017),
                    new TierLoot(6, ItemType.Ability, 0.0007)

              )
        );
    }
}