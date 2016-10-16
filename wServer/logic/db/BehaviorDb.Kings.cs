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
        private _ Kings = () => Behav()
        .Init("White King",
                new State("Attacks",
                        new State("Taunt",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("We shall unite forces in order to defeat this foe!"),
                            new TimedTransition(2100, "Attack1")
                              ),
                        new State("Attack1",
                            new Shoot(10, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 1900),
                            new Shoot(10, projectileIndex: 1, count: 12, shootAngle: 30, coolDown: 1000, coolDownOffset: 500),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 2200),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 3500),
                            new Shoot(10, projectileIndex: 2, count: 9, shootAngle: 20, coolDown: 4700),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 5900),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 6100),
                            new Follow(1, range: 3),
                            new TimedTransition(2100, "checkforking")
                              ),
                            new State("checkforking",
                            new EntitiesNotExistsTransition(9999, "Taunt2", "Black King"),
                            new TimedTransition(2100, "Attack1")
                        ),
                        new State("Taunt2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("Checkmate!"),
                            new TimedTransition(2100, "Attack2")
                            ),
                        new State("Attack2",
                          new Flash(0xb50000, 1, 5000),
                            new Shoot(10, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 700),
                            new Follow(1, range: 4),
                            new Shoot(10, projectileIndex: 1, count: 12, shootAngle: 30, coolDown: 800, coolDownOffset: 500),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 900),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 1000),
                            new Shoot(10, projectileIndex: 2, count: 9, shootAngle: 20, coolDown: 1200),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 1400),
                            new Shoot(10, projectileIndex: 2, count: 5, shootAngle: 10, coolDown: 1550)
                        )
                    )
            )
            .Init("Black King",
                new State("Attacks",
                        new State("Taunt",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("We shall unite forces in order to defeat this foe!"),
                            new TimedTransition(2100, "Attack1")
                              ),
                        new State("Attack1",
                            new Shoot(10, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 1800),
                            new Follow(1, range: 3),
                            new Shoot(10, projectileIndex: 1, count: 12, shootAngle: 30, coolDown: 1000, coolDownOffset: 500),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 2200),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 3500),
                            new Shoot(10, projectileIndex: 2, count: 9, shootAngle: 20, coolDown: 4700),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 5900),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 6100),
                            new TimedTransition(2100, "checkforking")
                              ),
                            new State("checkforking",
                            new EntitiesNotExistsTransition(9999, "Taunt2", "White King"),
                            new TimedTransition(2100, "Attack1")
                        ),
                        new State("Taunt2",
                            new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                            new Taunt("Checkmate!"),
                            new TimedTransition(2100, "Attack2")
                              ),
                        new State("Attack2",
                          new Flash(0xb50000, 1, 5000),
                            new Shoot(10, projectileIndex: 0, count: 8, shootAngle: 45, coolDown: 700),
                            new Follow(1, range: 4),
                            new Shoot(10, projectileIndex: 1, count: 12, shootAngle: 30, coolDown: 800, coolDownOffset: 500),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 900),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 1000),
                            new Shoot(10, projectileIndex: 2, count: 9, shootAngle: 20, coolDown: 1200),
                            new Shoot(10, projectileIndex: 2, count: 7, shootAngle: 15, coolDown: 1400),
                            new Shoot(10, projectileIndex: 2, count: 6, shootAngle: 15, coolDown: 1500)
                        )
                    )
                );
    }
}