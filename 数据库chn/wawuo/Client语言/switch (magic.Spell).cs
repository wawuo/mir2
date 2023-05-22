            switch (magic.Spell)
            {  //Warrior
                case Spell.Fencing:
                    SkillButton.Hint = string.Format("剑术 \n\n打击的准确性将按照以下方式提高\nwith practice level.\n被动技能\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.Slaying:
                    SkillButton.Hint = string.Format("攻杀剑术 \n\n命中准确度和破坏力将根据\n技能等级水平增加.\n被动技能\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.Thrusting:
                    SkillButton.Hint = string.Format("Dark Damage\nThrusting \n\nIncreases the reach of your hits destructive power\nwill increase in accordance with practive level.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.Rage:
                    SkillButton.Hint = string.Format("内力 \n\n法力消耗 {2}\n\n强化你的内力以提高其能量，在一定时间内增加攻击力和持续时间.\n攻击力和持续时间将取决于技能等级.\n技能使用后需要等待再次使用.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.ProtectionField:
                    SkillButton.Hint = string.Format("武力盾 \n\n法力消耗 {2}\n\n集中内力并将其扩散到你身体的所有部位。这将加强对敌人的保护。防御力和持续时间将取决于技能水平。\n一旦技能被使用，你将不得不等待再次使用它。\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.HalfMoon:
                    SkillButton.Hint = string.Format("风暴\n半月剑法 \n\n对面前一个半圆型范围造成伤害.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.FlamingSword:
                    SkillButton.Hint = string.Format("火灾伤害\n烈火剑法 \n\n通过召唤火之精灵\n注入武器造成额外伤害\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.ShoulderDash:
                    SkillButton.Hint = string.Format("野蛮冲撞 \n\n战士可以通过用肩膀冲锋来推开敌人，\n如果他们撞到障碍物，即造成伤害.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.CrossHalfMoon:
                    SkillButton.Hint = string.Format("风暴 \n圆月弯弓 \n\n一个战士使用两波强大的半月之力，\n对站在他们旁边的所有暴徒造成伤害.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.TwinDrakeBlade:
                    SkillButton.Hint = string.Format("Dark Damage\nTwinDrakeBlade \n\nThe art of making multiple power attacks. It has a\nlow chance of stunning the mob temporarly. Stunned\nmobs get 1.5 times more damage inflicted.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.Entrapment:
                    SkillButton.Hint = string.Format("Entrapment \n\nParalyses mobs and draws them to the caster.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.LionRoar:
                    SkillButton.Hint = string.Format("LionRoar \n\nParalyses mobs , duration increases with skill level.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                case Spell.CounterAttack:
                    SkillButton.Hint = string.Format("CounterAttack \n\n法力消耗 {2}\n\nIncreases AC and AMC for a short period of time\nChance to defend an attack and counter.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.ImmortalSkin:
                    SkillButton.Hint = string.Format("ImmortalSkin \n\n法力消耗 {2}\n\nIncrease defense to reduce attacks.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Fury:
                    SkillButton.Hint = string.Format("Fury \n\n法力消耗 {2}\n\n提高战士的准确度，持续一段时间.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SlashingBurst:
                    SkillButton.Hint = string.Format("SlashingBurst \n\n法力消耗 {2}\n\nAllows The Warrior to Jump 1 Space Over a Obejct or Monster.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.BladeAvalanche:
                    SkillButton.Hint = string.Format("Ice Damage\nBladeAvalanche \n\n3-Way Thrusting.\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0);
                    break;
                //Wizard
                case Spell.FireBall:
                    SkillButton.Hint = string.Format("Fireball \n\n瞬间施法 \n法力消耗 {2}\n\nElements of fire are gathered to form\na fireball. Throw at monsters for damage.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.ThunderBolt:
                    SkillButton.Hint = string.Format("Thundebolt \n\n瞬间施法 \n法力消耗 {2}\n\nStrikes the foe with a lightning bolt \ninflicting high damage.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.GreatFireBall:
                    SkillButton.Hint = string.Format("GreatFireBall \n\n瞬间施法 \n法力消耗 {2}\n\nStronger then fire ball, Great Fire Ball\nwill fire up the mobs.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Repulsion:
                    SkillButton.Hint = string.Format("Repulsion \n\n瞬间施法 \n法力消耗 {2}\n\nPush away mobs useing the power of fire.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.HellFire:
                    SkillButton.Hint = string.Format("Hellfire \n\n瞬间施法 \n法力消耗 {2}\n\nShoots out a streak of fire attack\nthe monster in front.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Lightning:
                    SkillButton.Hint = string.Format("Lightning \n\n瞬间施法 \n法力消耗 {2}\n\nShoots out a steak of lightning to attack\nthe monster in front.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.ElectricShock:
                    SkillButton.Hint = string.Format("ElectrickShock \n\n瞬间施法 \n法力消耗 {2}\n\nStrong shock wave hits the mob and the\nmob will not be able to move or the mob\nwill get confused and fight for you.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Teleport:
                    SkillButton.Hint = string.Format("Teleport \n\n瞬间施法 \n法力消耗 {2}\n\nTeleport to a random spot.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FireWall:
                    SkillButton.Hint = string.Format("FireWall \n\n瞬间施法 \n法力消耗 {2}\n\nThis skill will build a fire wall at a designated\nspot to attack the monster passing the area.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FireBang:
                    SkillButton.Hint = string.Format("FireBang \n\n瞬间施法 \n法力消耗 {2}\n\nFirebang will burst out fire at a designated spot to\nburn all the monster within the area.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.ThunderStorm:
                    SkillButton.Hint = string.Format("Thunderstorm \n\n瞬间施法 \n法力消耗 {2}\n\nThis skill will make a thunder storm with in a designated area \nto attack the monster with in.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MagicShield:
                    SkillButton.Hint = string.Format("MagicShield \n\n瞬间施法 \n法力消耗 {2}\n\nThis skill will use Mp to create protective\nlayer around you\nAttack will be absorbed by the protective layer\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.TurnUndead:
                    SkillButton.Hint = string.Format("TurnUndead \n\n瞬间施法 \n法力消耗 {2}\n\nThis magic will bring birght light into \npower and attack undead monsters\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.IceStorm:
                    SkillButton.Hint = string.Format("IceStorm \n\nInstant Castin\n法力消耗 {2}\n\nThis skill will make an ice storm with in a designated \narea to attack the monsters with in\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FlameDisruptor:
                    SkillButton.Hint = string.Format("FlameDisruptor \n\n瞬间施法 \n法力消耗 {2}\n\nFlame from the underground will be brought\ninto surface to attack the mobs.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FrostCrunch:
                    SkillButton.Hint = string.Format("FrostCrunch \n\n瞬间施法 \n法力消耗 {2}\n\nFreeze the elements in the air around the \nmonster to slow them down\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Mirroring:
                    SkillButton.Hint = string.Format("Mirroring \n\n瞬间施法 \n法力消耗 {2}\n\nCreate a mirror image of yourself to attack\nthe monsters together\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FlameField:
                    SkillButton.Hint = string.Format("FlameField \n\n瞬间施法 \n法力消耗 {2}\n\nA powerful spell of fire is used to \ndamage surrounding enemies.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Vampirism:
                    SkillButton.Hint = string.Format("Vampirism \n\n瞬间施法 \n法力消耗 {2}\n\nUsing Mp take away monsters Hp to\nincrease your Hp.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Blizzard:
                    SkillButton.Hint = string.Format("Blizzard \n\nChanneling Casting\n法力消耗 {2}\n\nConcentrate inner force and spreads it to all\nthe parts of your body.This will enhance the\nprotection from enemies. Defense power and duration\ntime will depend on the skill level. Once the skill\nhas been used, you will have to wait to use it again.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MeteorStrike:
                    SkillButton.Hint = string.Format("MeteorStrike \n\nChanneling Casting\n法力消耗 {2}\n\nAttacks all monsters within 5x5 square area with lumps \nof fire falling from the sky.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.IceThrust:
                    SkillButton.Hint = string.Format("IceThrust \n\nInstant CastingMana Cost {2}\n\nAttack monsters by creating an ice pillar.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MagicBooster:
                    SkillButton.Hint = string.Format("MagicBooster \n\nLasting EffectMana Cost {2}\n\nIncrease magical damage, but comsume additional MP.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FastMove:
                    SkillButton.Hint = string.Format("FastMove \n\nChanneling Casting\n法力消耗 {2}\n\nIncrease movemoent with rooted skills.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.StormEscape:
                    SkillButton.Hint = string.Format("StormEscape \n\nChanneling Casting\n法力消耗 {2}\n\nParalyze nearby enemies and teleport to the designated location.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Blink:
                    SkillButton.Hint = string.Format("Blink \n\n瞬间施法 \n法力消耗 {2}\n\nTeleport to a random spot near you.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                //Taoist
                case Spell.SpiritSword:
                    SkillButton.Hint = string.Format("SpiritSword \n\nIncreases the chance of hitting the target in\n melee combat.\n被动技能\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Healing:
                    SkillButton.Hint = string.Format("Healing \n\n瞬间施法 \n法力消耗 {2}\n\nHeals a single target \nrecovering HP over time.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Poisoning:
                    SkillButton.Hint = string.Format("Poisoning \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Poison Powder\n\nThrow poison at mobs to weaken them.\nUse green poison to weaken Hp.\nUse red poison to weaken defense.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SoulFireBall:
                    SkillButton.Hint = string.Format("SoulFireBall \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nPut power into a scroll and throw it at \na mob. The scroll will burst into fire.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SoulShield:
                    SkillButton.Hint = string.Format("SoulShield \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nBless the partymembers to strengthen there magic\ndefence.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.BlessedArmour:
                    SkillButton.Hint = string.Format("BlessedArmour \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nBless the partymemebers to strenghten there defence.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.TrapHexagon:
                    SkillButton.Hint = string.Format("TrapHexagon \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nTrap the monster with this magical power\n to stop them from moving. Any damages\nfrom outside source will allow the monsters\nto move again.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SummonSkeleton:
                    SkillButton.Hint = string.Format("SummonSkeleton \n\n\n瞬间施法 \n法力消耗 {2}\n\nSummons a Powerful AOE Skeleton, Which will Fight Side By Side With You\n\nRequired Items: Amulet.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Hiding:
                    SkillButton.Hint = string.Format("Hiding \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nMobs will not be able to spot you for a short\nmoment.Mobs will notice you if you start\nto move around.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MassHiding:
                    SkillButton.Hint = string.Format("MassHiding \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nMobs will not be able to spot you or your \nparty members for a short moment. \nMobs will notice you and your party if \nyou start to move around.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Revelation:
                    SkillButton.Hint = string.Format("Revelation \n\n瞬间施法 \n法力消耗 {2}\n\nYou will be able to read Hp of others\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MassHealing:
                    SkillButton.Hint = string.Format("MassHealing \n\n瞬间施法 \n法力消耗 {2}\n\nHeal all injured players in the specified\narea by surrounding them with mana.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SummonShinsu:
                    SkillButton.Hint = string.Format("SummonShinsu \n\n瞬间施法 \n法力消耗 {2}\n\nSummons a Dog, That Will fight Side By Side with you.\nRequired Items: Amulet.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.UltimateEnhancer:
                    SkillButton.Hint = string.Format("UltimateEnhancer \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nAbsorb the energy from the surroundings to increase the stats.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.EnergyRepulsor:
                    SkillButton.Hint = string.Format("EnergyRepulsor \n\n瞬间施法 \n法力消耗 {2}\n\nConcentrate your energy for one big blast to push away the monsters around you.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Purification:
                    SkillButton.Hint = string.Format("Purification \n\n瞬间施法 \n法力消耗 {2}\n\nHelp others to recover from poisoning and\nparalysis useing this skill.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SummonHolyDeva:
                    SkillButton.Hint = string.Format("SummonHolyDeva \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nSummon a holy spirit.This holy spirit will\nuse strong thunder to attack monsters.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Curse:
                    SkillButton.Hint = string.Format("Curse \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet + Poison\n\nReduces mob attacks (Attack Speed, DC ,MC ,SC)\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Hallucination:
                    SkillButton.Hint = string.Format("Hallucination \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nThe monster will only see hallucination \nand attack anyone on the way\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Reincarnation:
                    SkillButton.Hint = string.Format("Reincarnation \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nRevives a dead players\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.PoisonCloud:
                    SkillButton.Hint = string.Format("PoisonCloud \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: GreenPoison\n\nThrow the amulet and a very strong\npoison cloud will appear in the area.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.EnergyShield:
                    SkillButton.Hint = string.Format("EnergyShield \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet\n\nCreate an enegy shield to heal immediately when attacked by monsters.\n当前技能等级\n {0}\n\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Plague:
                    SkillButton.Hint = string.Format("Plague \n\n瞬间施法 \n法力消耗 {2}\n\nRequired Items: Amulet + Poison\n\nDecreases targets MP and inflict target with various debuffs\nExample: Stun , Curse , Poison and Slow.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.HealingCircle:
                    SkillButton.Hint = string.Format("HealingCircle \n\n瞬间施法 \n法力消耗 {2}\n\nTreatment area friendly target, and the enemy caused spell damage.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.PetEnhancer:
                    SkillButton.Hint = string.Format("PetEnhancer \n\n瞬间施法 \n法力消耗 {2}\n\nStrengthening pets defense and power.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;

                //Assassin
                case Spell.FatalSword:
                    SkillButton.Hint = string.Format("FatalSword \n\nIncrease attack damage on the monsters.\nalso increases accuracy a little.\n被动技能\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.DoubleSlash:
                    SkillButton.Hint = string.Format("DoubleSlash \n\n法力消耗 {2}\n\nSlash the monster twice in a quick motion\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Haste:
                    SkillButton.Hint = string.Format("Haste \n\n法力消耗 {2}\n\nIncrease the attack speed\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FlashDash:
                    SkillButton.Hint = string.Format("FlashDash \n\n法力消耗 {2}\n\nAttack a monster with quick slash and\nparalize the monster\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.HeavenlySword:
                    SkillButton.Hint = string.Format("HeavenlySword \n\n法力消耗 {2}\n\nAttack monsters with in 2 steps radius\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.FireBurst:
                    SkillButton.Hint = string.Format("FireBurst \n\n法力消耗 {2}\n\nPush away mobs surrounding you\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Trap:
                    SkillButton.Hint = string.Format("Trap \n\nInstant casting CoolTime 60 secs\n\n法力消耗 {2}\n\nTrap the monster for a short while.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MoonLight:
                    SkillButton.Hint = string.Format("Moonlight \n\n法力消耗 {2}\n\nHide yourself from monster by turning invisible\nGreater damage is done when you attack monster using\nthis skill.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MPEater:
                    SkillButton.Hint = string.Format("MpEater \n\nPassive\n法力消耗 {2}\n\nAbsord monsters MP to recharge your MP\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.SwiftFeet:
                    SkillButton.Hint = string.Format("SwiftFeet \n\n法力消耗 {2}\n\nIncreased Runing Speed\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.LightBody:
                    SkillButton.Hint = string.Format("LightBody \n\n法力消耗 {2}\n\nLighten your body using this skill and move faster\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.PoisonSword:
                    SkillButton.Hint = string.Format("PoisonSword \n\n法力消耗 {2}\n\nPoison the monsters with a slash of you\nsword.Poison effect will damage the monster\nover time.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.DarkBody:
                    SkillButton.Hint = string.Format("DarkBody \n\n法力消耗 {2}\n\nCreate an illusion of yourself to attack\nthe monster while you become invisible.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.CrescentSlash:
                    SkillButton.Hint = string.Format("CrescentSlash \n\n法力消耗 {2}\n\nBurst out of the power of your sword and attack all monsters around you.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.Hemorrhage:
                    SkillButton.Hint = string.Format("Hemorrhage \n\n法力消耗 {2}\n\nPassive\nChance to deal cristical damage and inflict bleeding damage.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;
                case Spell.MoonMist:
                    SkillButton.Hint = string.Format("Moon Mist\nActive\n\n法力消耗 {2}\n\nAbility to hide your self from Monster\nYour first attack will be stronger than normal.\n\n当前技能等级\n {0}\n下次升级 {1}", Magic.Level, Magic.Level == 0 ? Magic.Level1 : Magic.Level == 1 ? Magic.Level2 : Magic.Level == 2 ? Magic.Level3 : 0, Magic.BaseCost);
                    break;

                default:

                    break;
            }