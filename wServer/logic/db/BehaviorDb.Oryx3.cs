using wServer.logic.behaviors;
using wServer.logic.loot;
using wServer.logic.transitions;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        private _ Oryx3 = () => Behav()
            .Init("Oryx the Mad God 3",
            new State(
                new State("Taunts",
                    new ConditionalEffect(ConditionEffectIndex.Invulnerable),
                    new State("Idle",
                        new PlayerWithinTransition(10, "Taunt1")
                    ),
                    new State("Taunt1",
                        new Taunt("Mischevious runts. I will destroy you once and for all."),
                        new TimedTransition(3000, "Taunt2")
                    ),
                    new State("Taunt2",
                        new Taunt("You have killed me many times."),
                        new TimedTransition(3000, "Taunt3")
                    ),
                    new State("Taunt3",
                        new Taunt("I have been humiliated over and over again."),
                        new TimedTransition(3000, "Taunt4")
                    ),
                    new State("Taunt4",
                        new Taunt("Now, I will slaughter you into a million pieces."),
                        new TimedTransition(3000, "Taunt5")
                    ),
                    new State("Taunt5",
                        new Taunt("Your life is worthless!"),
                        new TimedTransition(3000, "Taunt6")
                    ),
                    new State("Taunt6",
                        new Taunt("Prepare to die!"),
                        new TimedTransition(3000, "Attack1")
                    )
                ),
                new State("Attacks",
                    new State("Attack1",
                        new Shoot(25, projectileIndex: 6, count: 20, shootAngle: 20, coolDown: 4000, coolDownOffset: 4000),
                        new Shoot(25, projectileIndex: 4, count: 2, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 5, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 2, count: 2, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 6, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 0, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 1, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new Shoot(25, projectileIndex: 3, count: 3, predictive: 0.2, shootAngle: 15, coolDown: 1350, coolDownOffset: 1350),
                        new HpLessTransition(.25, "Attack2")
                    ),
                    new State("Attack2",
                        new Taunt("I must live on!"),
                        new Shoot(25, projectileIndex: 6, count: 8, shootAngle: 45, coolDown: 2000, coolDownOffset: 2000),
                        new Shoot(25, projectileIndex: 6, count: 3, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 2, count: 2, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 4, count: 2, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 5, count: 3, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 3, count: 3, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new Shoot(25, projectileIndex: 0, count: 3, predictive: 0.2, shootAngle: 25, coolDown: 1000, coolDownOffset: 1000),
                        new HpLessTransition(0.02, "Death")
                    ),
                    new State("Death",
                        new Taunt("I'm such a weakling...")
                    )
                )
            )
        );
    }
}