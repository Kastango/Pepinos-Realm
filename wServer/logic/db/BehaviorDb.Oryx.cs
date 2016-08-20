using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using wServer.realm;
using wServer.logic.attack;
using wServer.logic.movement;
using wServer.logic.loot;
using wServer.logic.taunt;
using wServer.logic.cond;

namespace wServer.logic
{
    partial class BehaviorDb
    {
        static _ Oryx = Behav()
            .Init(0x1740, Behaves("Oryx the Mad God 1",
                    new RunBehaviors(
                        IfExist.Instance(-1, NullBehavior.Instance,
                            new RunBehaviors(
                                new QueuedBehavior(
                                    CooldownExact.Instance(400)
                                ),
                                Once.Instance(new SimpleTaunt("Fools! I still have {HP} hitpoints!")),
                                new QueuedBehavior(new SetKey(-1, 1))

                            )
                        ),
                        IfEqual.Instance(-1, 1,
                            new RunBehaviors(
                            Once.Instance(SpawnMinionImmediate.Instance(0x1749, 10, 0, 4)),
                            Cooldown.Instance(800, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 4, 0, projectileIndex: 4)),
                            Reproduce.Instance(0x1749, 10, 1500, 4),
                                //new QueuedBehavior(HpLesserPercent.Instance(0.90f, new SetKey(-1, 2)))
                            new QueuedBehavior(Cooldown.Instance(20000, new SetKey(-1, 2)))
                            )
                        ),
                        IfEqual.Instance(-1, 2,
                            new RunBehaviors(
                                Once.Instance(new SimpleTaunt("BE SILENT!!!")),
                                Timed.Instance(2500, Flashing.Instance(200, 0xf389E13)),
                                Once.Instance(TossEnemy.Instance(24 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(48 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(72 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(96 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(120 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(144 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(168 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(192 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(216 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(240 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(264 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(288 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(312 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(336 * (float)Math.PI / 180, 9, 0x1748)),
                                Once.Instance(TossEnemy.Instance(360 * (float)Math.PI / 180, 9, 0x1748)),
                                Cooldown.Instance(900, RingAttack.Instance(15, 20, 0, projectileIndex: 6)),
                                //Cooldown.Instance(1200, Once.Instance(RingAttack.Instance(40, 2, 0, projectileIndex: 14))),
                                //Cooldown.Instance(700, Once.Instance(RingAttack.Instance(18, 2, 0, projectileIndex: 13))),
                                Cooldown.Instance(3000, ThrowAttack.Instance(4, 5, 240)),
                                Cooldown.Instance(2500, ThrowAttack.Instance(4, 8, 150)),
                                new QueuedBehavior(Cooldown.Instance(45000, new SetKey(-1, 3)))
                            ))
                        ),
                        IfEqual.Instance(-1, 3,
                            new RunBehaviors(
                                Once.Instance(new SimpleTaunt("My Artifacts will protect me!")),
                                Timed.Instance(2500, Flashing.Instance(200, 0xf389E13)),
                                Cooldown.Instance(1500, RingAttack.Instance(3, 10, 0, projectileIndex: 9)),
                                Cooldown.Instance(2000, RingAttack.Instance(10, 10, 0, projectileIndex: 8)),
                                Cooldown.Instance(500, RingAttack.Instance(10, 10, 0, projectileIndex: 7)),
                                //Inner Elements
                                Once.Instance(
                                new RunBehaviors(
                                TossEnemy.Instance(0 * (float)Math.PI / 180, 2, 0x174a),
                                TossEnemy.Instance(90 * (float)Math.PI / 180, 2, 0x174b),
                                TossEnemy.Instance(180 * (float)Math.PI / 180, 2, 0x174c),
                                TossEnemy.Instance(270 * (float)Math.PI / 180, 2, 0x174d),
                                //Outer Elements
                                TossEnemy.Instance(0 * (float)Math.PI / 180, 9, 0x174e),
                                TossEnemy.Instance(90 * (float)Math.PI / 180, 9, 0x174e),
                                TossEnemy.Instance(180 * (float)Math.PI / 180, 9, 0x174e),
                                TossEnemy.Instance(270 * (float)Math.PI / 180, 9, 0x174e)
                                )),
                                new QueuedBehavior(Cooldown.Instance(55000, new SetKey(-1, 4)))
                            )),

                            IfEqual.Instance(-1, 4,
                            new RunBehaviors(
                                Once.Instance(new SimpleTaunt("I am the master of this existence!")),
                                Timed.Instance(2500, Flashing.Instance(200, 0xf389E13)),
                                Timed.Instance(7000, Cooldown.Instance(2000, RingAttack.Instance(10, 20, 0, projectileIndex: 16))),
                                Cooldown.Instance(900, RingAttack.Instance(15, 20, 0, projectileIndex: 6)),
                                Once.Instance(TossEnemy.Instance(360 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(45 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(90 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(135 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(180 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(225 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(315 * (float)Math.PI / 180, 8, 0x1742)),
                                Once.Instance(TossEnemy.Instance(360 * (float)Math.PI / 180, 8, 0x1742))
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 0 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 18 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 36 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 54 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 72 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 90 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 108 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 126 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 144 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 162 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 180 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 198 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 216 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 234 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 252 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 270 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 288 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 306 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 324 * (float)Math.PI / 180, projectileIndex: 0))),
                                Cooldown.Instance(250, new RunBehaviors(RingAttack.Instance(3, offset: 342 * (float)Math.PI / 180, projectileIndex: 0)))
                            )),

                    loot: new LootBehavior(LootDef.Empty,
                        Tuple.Create(100, new LootDef(0, 2, 0, 2,
                            Tuple.Create(0.001, (ILoot)new TierLoot(4, ItemType.Ability)),
                            Tuple.Create(0.005, (ILoot)new TierLoot(5, ItemType.Ability)),

                            Tuple.Create(0.05, (ILoot)new TierLoot(8, ItemType.Armor)),
                            Tuple.Create(0.05, (ILoot)new TierLoot(9, ItemType.Armor)),
                            Tuple.Create(0.025, (ILoot)new TierLoot(10, ItemType.Armor)),
                            Tuple.Create(0.005, (ILoot)new TierLoot(11, ItemType.Armor)),
                            Tuple.Create(0.001, (ILoot)new TierLoot(12, ItemType.Armor)),

                            Tuple.Create(0.05, (ILoot)new TierLoot(8, ItemType.Weapon)),
                            Tuple.Create(0.05, (ILoot)new TierLoot(9, ItemType.Weapon)),
                            Tuple.Create(0.005, (ILoot)new TierLoot(10, ItemType.Weapon)),
                            Tuple.Create(0.001, (ILoot)new TierLoot(11, ItemType.Weapon)),

                            Tuple.Create(0.2, (ILoot)new TierLoot(5, ItemType.Ring)),
                            Tuple.Create(0.5, (ILoot)new TierLoot(4, ItemType.Ring)),
                            Tuple.Create(0.7, (ILoot)new TierLoot(3, ItemType.Ring)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Def)),
                            Tuple.Create(0.5, (ILoot)new StatPotionLoot(StatPotion.Att))
                    )))
                    
            ))
            .Init(0x1748, Behaves("Ring Element",
            new RunBehaviors(
                        Timed.Instance(20000, Cooldown.Instance(700, RingAttack.Instance(8, 100, 0, projectileIndex: 0))),
                        Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                        CooldownExact.Instance(19000,
                        new RunBehaviors( 
                            Despawn.Instance
                            ))
                        ))

        )
        .Init(0x1749, Behaves("Minion of Oryx",
            new RunBehaviors(
                SimpleWandering.Instance(3),
                Cooldown.Instance(700, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Cooldown.Instance(700, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 1))
                        ))
                        )
                        .Init(0x174a, Behaves("Guardian Element 1",
            new RunBehaviors(
                Circling.Instance(2, 10, 20, 0x1740),
                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                Cooldown.Instance(850, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Cooldown.Instance(30000, SetSize.Instance(200)),
                CooldownExact.Instance(40000,
                        new RunBehaviors(
                            Despawn.Instance
                            ))
                        ))
                        )
                        .Init(0x174b, Behaves("Guardian Element 2",
            new RunBehaviors(
                Circling.Instance(2, 10, 20, 0x1740),
                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                Cooldown.Instance(850, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Cooldown.Instance(30000, SetSize.Instance(200)),
                CooldownExact.Instance(40000,
                        new RunBehaviors(
                            Despawn.Instance
                            ))
                        ))
                        )
                        .Init(0x174c, Behaves("Guardian Element 3",
            new RunBehaviors(
                Circling.Instance(2, 10, 20, 0x1740),
                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                Cooldown.Instance(850, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Cooldown.Instance(30000, SetSize.Instance(200)),
                CooldownExact.Instance(40000,
                        new RunBehaviors(
                            Despawn.Instance
                            ))
                        ))
                        )
                        .Init(0x174d, Behaves("Guardian Element 4",
            new RunBehaviors(
                Circling.Instance(2, 10, 20, 0x1740),
                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                Cooldown.Instance(850, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Cooldown.Instance(30000, SetSize.Instance(200)),
                CooldownExact.Instance(40000,
                        new RunBehaviors(
                            Despawn.Instance
                            ))
                        ))
                        )
                        .Init(0x174e, Behaves("Outer Guardian Element",
            new RunBehaviors(
                Circling.Instance(12, 10, 15, 0x1740),
                Cooldown.Instance(850, MultiAttack.Instance(10, 15 * (float)Math.PI / 180, 3, 0, projectileIndex: 0)),
                Once.Instance(SetConditionEffect.Instance(ConditionEffectIndex.Invulnerable)),
                CooldownExact.Instance(40000,
                        new RunBehaviors(
                            Despawn.Instance
                            ))
                        ))
                        );
    }
}