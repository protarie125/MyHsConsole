﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HsConsole.Game.Enum
{
    static class HsEnum
    {
        public enum CardType
        {
            None = 0,
            Minion,
            Spell,
            //Hero
        }

        public enum Race
        {
            None = 0,
            Murloc,
        }

        public enum ClassType
        {
            None = 0,
            Neutral,
            Mage,
        }

        public enum EffectTarget
        {
            None = 0,
            Any = 1,
            Friendly, FriendlyHero, FriendlyMinion, AllFriendlyMinions, AllOtherFriendlyMinions,
            Enemy, EnemyHero, EnemyMinion, AllEnemyMinions,
            Character, AllCharacters,
            Hero,
            Minion, AllMinions, AllOtherMinions,
        }
    }
}
